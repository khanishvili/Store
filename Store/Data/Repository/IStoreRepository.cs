using Store.Models;
using System.Linq;

namespace Store.Data.Repository
{
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }

        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
