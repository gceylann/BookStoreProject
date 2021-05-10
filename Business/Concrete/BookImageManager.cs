using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BookImageManager : IBookImageService
    {
        IBookImageDal _bookImageDal;

        public BookImageManager(IBookImageDal bookImageDal)
        {
            _bookImageDal = bookImageDal;
        }

        public IResult Add(BookImage bookImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(CheckBookImageCount(bookImage.ImageId));

            if (result!=null)
            {
                return result;
            }

            bookImage.Date = DateTime.Now;
            bookImage.ImagePath = FileHelper.AddFile(file);
            _bookImageDal.Add(bookImage);

            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BookImage bookImage)
        {
            var image = _bookImageDal.Get(img => img.ImageId == bookImage.ImageId);
            if (image == null)
            {
                return new ErrorResult(Messages.BookImageNotFound);
            }
            _bookImageDal.Delete(bookImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<BookImage>> GetAll()
        {
            return new SuccessDataResult<List<BookImage>>(_bookImageDal.GetAll());
        }

        public IDataResult<BookImage> GetById(int BookImageId)
        {
            return new SuccessDataResult<BookImage>(_bookImageDal.Get(img => img.ImageId == BookImageId));
        }

        public IResult Update(BookImage bookImage, IFormFile file)
        {
            var oldImage = _bookImageDal.Get(img => img.ImageId == bookImage.ImageId);

            if (oldImage==null)
            {
                return new ErrorResult(Messages.BookImageNotFound);
            }
            bookImage.Date = DateTime.Now;
            bookImage.ImagePath = FileHelper.UpdateFile(file, oldImage.ImagePath);
            _bookImageDal.Update(bookImage);

            return new SuccessResult(Messages.Updated);
            
        }


        // Business Rules Methods
        private IResult CheckBookImageCount(int bookImageId)
        {
            if (_bookImageDal.GetAll(img => img.ImageId == bookImageId).Count >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
