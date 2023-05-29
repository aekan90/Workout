using ClassLibraryLayer.Core;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryLayer.LinQ
{
    public class LazyEagerLoading
    {
        // Lazy Loading örneği
        public Category GetKategoriWithLazyLoading(int kategoriId)
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Categories.FirstOrDefault(k => k.CategoryId == kategoriId);
            }
        }

        // Eager Loading örneği
        public Category GetKategoriWithEagerLoading(int kategoriId)
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Categories.Include(k => k.Products).FirstOrDefault(k => k.CategoryId == kategoriId);
            }
        }

        //Kullanımı; Bir controller veya consol app içinde denenebilir.
        //LazyEagerLoading lazyEagerLoading = new LazyEagerLoading();
        //Category getCategoryLazy = lazyEagerLoading.GetKategoriWithLazyLoading(1);
        //Category getCategoryEager = lazyEagerLoading.GetKategoriWithEagerLoading(1);
    }
}