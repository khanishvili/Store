using Store.Data;
using Store.Models;
using System.Linq;

namespace Store.Data.Repository
{
    public class StoreRepository : IStoreRepository {
        private StoreDbContext context;

        public StoreRepository(StoreDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public void CreateProduct(Product p) {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteProduct(Product p) {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveProduct(Product p) {
            context.SaveChanges();
        }
    }
}
