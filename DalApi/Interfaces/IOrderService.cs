using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DO.Models;

namespace DalApi.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        Order GetOrder(int key);
        void UpdateOrderStatus(int key, Status_Order status_Order);
        List<Order> GetOrders();

        //public delegate bool Predicate<T>(T obj);
    }
}
