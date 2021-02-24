﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductsListed = "Ürünler listelendi!";
        public static string ProductCountCategoryError = "Bir categoryden en fazla 10 adet yapabilirsiniz!";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var!";
        public static string CategoryLimitExceded = "Kategori sayısı 15 den fazla olduğu için yeni ürün ekleyemezsiniz!";
    }
}
