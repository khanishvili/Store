using Store.Models;
using System.Linq;

namespace Store.Data.Repository
{

    public interface IOrderRepository {

        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
