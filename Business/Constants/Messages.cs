using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarListed = "Arabalar listelendi";
        public static string BrandNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTimee = "Sistem bakımda";
        public static string BrandAdd = "Marka eklendi";
        public static string BrandDelete = "Marka silindi";
        public static string CarCountOfBrandError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string BrandIdAlreadyExists = "Bu idde zaten başka bir ürün var";
        public static string AuthorizationDenied = "yetkiniz yok";

        public static string UserRegistered { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string ImagesAdded { get; internal set; }
        public static string ImagesDeleted { get; internal set; }
        public static string ImagesListed { get; internal set; }
        public static string ImagesUpdated { get; internal set; }
        public static string MaxError { get; internal set; }
        public static string CarUpdated { get; internal set; }
    }
}
