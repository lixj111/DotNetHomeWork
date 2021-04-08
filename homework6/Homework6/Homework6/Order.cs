using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1、在上次作业的OrderService中添加一个Export方法，
   可以将所有的订单序列化为XML文件；
   添加一个Import方法可以从XML文件中载入订单。
2、对订单程序中OrderService的各个Public方法添加测试用例。
 */
namespace Homework6
{
    public class Order
    {
        public int OrderID { get; set; }

        //public string ProductName { get; set; }

        //public string ProductPrice { get; set; }
        public string ClientName { get; set; }
        public double TotalPrice { get; set; }
        public ProductDetails[] Products { get; set; }


        public Order(int id, string cname, params ProductDetails[] products)
        {
            OrderID = id;
            //ProductName = pname;
            ClientName = cname;
            //ProductPrice = pprice;
            Products = products;
            TotalPrice = 0;
            foreach (ProductDetails pd in Products)
            {
                TotalPrice += pd.ProductPrice;
            }
        }


        public override bool Equals(object obj)
        {
            Order ode = obj as Order;
            return ode != null && OrderID == ode.OrderID
                               && ClientName == ode.ClientName
                               && TotalPrice == ode.TotalPrice;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();//??
        }

        public override string ToString()
        {
            string s = "订单ID：" + OrderID + '\t' + "客户姓名：" + ClientName + '\t' + "订单总价：" + TotalPrice + "\t\n";
            foreach (ProductDetails pd in Products) s += pd + "\t\n";
            return s;
        }
    }
}
