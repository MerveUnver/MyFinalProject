using Core.Entities.Concrete;
using Entities.Concrete;
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
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 15 ürün olabilir";
        public static string ProductNameAlreadyExists="Aynı isimde birden fazla ürün eklenemez.";
        public static string CountOfCategoryError="15 den fazla kategory eklenemez.";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="hatalı şifre";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string AccessTokenCreated="token oluşturuldu";
    }
}
