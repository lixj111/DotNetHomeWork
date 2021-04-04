using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public static class OrderService
    {
        public static List<Order> orders = new List<Order>();

        public static bool AddOrder(Order order)
        {
            if (order == null || order.Products == null)
                throw new ArgumentException("该订单不存在！");
            if (orders.Where(ode => ode.OrderID == order.OrderID).Any())
            { return false; }
            orders.Add(order);
            return true;
        }

        public static void DeleteOrder(int OrderID)
        {
            var deleteorder = orders.Where(ode => ode.OrderID == OrderID).FirstOrDefault();
            if(deleteorder == null)
            {
                throw new InvalidOperationException("要删除的订单不存在！");
            }
            orders.Remove(deleteorder);
        }

        public static void UpdateOrder(Order order)
        {
            if (order == null || order.Products == null)
                throw new ArgumentException("参数为空！");
            var updateorder = orders.Where(ode => ode.OrderID == order.OrderID).FirstOrDefault();
            if (updateorder == null)
                throw new InvalidOperationException("该订单不存在！");
            if (!string.IsNullOrEmpty(order.ClientName))
            {
                updateorder.ClientName = order.ClientName;
            }
            if (order.TotalPrice > 0)
            {
                updateorder.TotalPrice = order.TotalPrice;
            }
            if (order.Products != null && order.Products.Length > 0)
            {
                updateorder.Products = order.Products;
            }
        }

        public static IEnumerable<Order> QueryById(int selectId)
        {
            var query = from ord in orders
                        where ord.OrderID == selectId
                        select ord;
            return query;
        }
        public static IEnumerable<Order> QueryByClientName(string selectCname)
        {
            var query = from ord in orders
                        where ord.ClientName == selectCname
                        select ord;
            return query;
        }
        public static IEnumerable<Order> QueryByProductId(int selectPId)
        {
            var query = from ord in orders
                        where ord.Products.Where(pd => pd.ProductID == selectPId).Any()
                        select ord;
            return query;
        }
        public static IEnumerable<Order> QueryByProductName(string selectPname)
        {
            var query = from ord in orders
                        where ord.Products.Where(pd => pd.ProductName == selectPname).Any()
                        select ord;
            return query;
        }
        public static IEnumerable<Order> QueryByProductPrice(double selectPprice)
        {
            var query = from ord in orders
                        where ord.Products.Where(pd => pd.ProductPrice == selectPprice).Any()
                        select ord;
            return query;
        }
        public static IEnumerable<Order> QueryAll()
        {
            return from ord in orders
                   orderby ord.OrderID
                   select ord;
        }
    }
}
