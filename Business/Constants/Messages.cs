using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added="Eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string ImageLimitExceded="Fotoğraf limiti aşıldı";
        public static string BookImageNotFound="Kitabın fotoğrafı bulunamadı";
        public static string AuthorizationDenied="Yetkilendirme reddedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt oldundu.";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExist="Bu kullanıcı zaten mevcut";
        public static string WrongPassword = "Yanlış Şifre!";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
