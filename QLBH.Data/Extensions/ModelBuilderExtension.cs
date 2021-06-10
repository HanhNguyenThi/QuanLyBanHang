using QLBH.Data.Entities;
using QLBH.Data.Enums;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of QLBH" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is home keyword of QLBH" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of QLBH" });
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId=null,
                    SortOrder=1,
                    Status=Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active,
                 },
                  new Category()
                  {
                      Id = 3,
                      IsShowOnHome = true,
                      ParentId = null,
                      SortOrder = 3,
                      Status = Status.Active,
                  });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id=1,CategoryId=1,Name="Áo nam",LanguageId="vi-VN",SeoAlias="ao-nam",
                    SeoDescriptions="Sản phẩm áo thời trang nam",SeoTitle="Sản phẩm áo thời trang nam"},
                new CategoryTranslation(){Id = 2,CategoryId = 1,Name = "Men Shirt",LanguageId = "en-US",SeoAlias = "Men-Shirt",
                    SeoDescriptions = "The shirt product for men",SeoTitle = "The shirt product for men"},
                new CategoryTranslation(){Id = 3,CategoryId = 2,Name = "Áo nữ",LanguageId = "vi-VN",SeoAlias = "ao-nu",
                    SeoDescriptions = "Sản phẩm áo thời trang nữ",SeoTitle = "Sản phẩm áo thời trang nữ"},
                new CategoryTranslation(){Id = 4,CategoryId = 2,Name = "WoMen Shirt",LanguageId = "en-US",SeoAlias = "WoMen-Shirt",
                    SeoDescriptions = "The shirt product for women",SeoTitle = "The shirt product for men"},
                new CategoryTranslation() {Id = 5,CategoryId = 3,Name = "Áo bé trai",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescriptions = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Men-Shirt",
                    SeoDescriptions = "The shirt product for men",
                    SeoTitle = "The shirt product for men"
                },
                }
    }
}
