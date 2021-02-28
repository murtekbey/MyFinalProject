using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem şuan bakımdadır.";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün daha önce eklenmiş";
        public static string CategoryLimitExceeded = "Mevcut kategori sayısı 15'i geçtiği için yeni ürün ekleme yapılamaz.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Kullanıcı başarıyla giriş yaptı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}
