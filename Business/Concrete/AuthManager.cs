using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Encryption;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email=userForRegisterDto.Email,
                FirstName=userForRegisterDto.FirstName,
                LastName=userForRegisterDto.LastName,
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt,
                Status=true

            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByEmail(userForLoginDto.Email).Data;
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.WrongPassword);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByEmail(email)!=null)
            {
               return new ErrorResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }

        public IResult ChangePassword(UserForChangingPasswordDto userForChangingPasswordDto)
        {
            var userInfos = _userService.GetById(userForChangingPasswordDto.Id).Data;

            if (!HashingHelper.VerifyPasswordHash(userForChangingPasswordDto.CurrentPassword,
                                                  userInfos.PasswordHash,
                                                  userInfos.PasswordSalt))
            {
                return new ErrorResult(Messages.WrongPassword);
            }

            HashingHelper.CreatePasswordHash(userForChangingPasswordDto.NewPassword,
                                             out byte[] passwordHash,
                                             out byte[] passwordSalt);

            userInfos.PasswordHash = passwordHash;
            userInfos.PasswordSalt = passwordSalt;

            _userService.Update(userInfos);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
