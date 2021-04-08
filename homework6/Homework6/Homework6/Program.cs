using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成订单
            //public Order(int id, string cname,params ProductDetails[] products )
            //public ProductDetails(int pid, string pname, double pprice)
            OrderService.AddOrder(new Order(001, "客户1", new ProductDetails(01, "商品1", 67)));
            OrderService.AddOrder(new Order(007, "客户7", new ProductDetails(07, "商品7", 87)));
            OrderService.AddOrder(new Order(006, "客户6", new ProductDetails(06, "商品6", 199)));
            OrderService.AddOrder(new Order(003, "客户3", new ProductDetails(03, "商品3", 53),
                                                          new ProductDetails(04, "商品4", 73),
                                                          new ProductDetails(05, "商品5", 23)));
            Console.WriteLine("所有订单如下：");
            var query1 = OrderService.QueryAll();
            foreach (var q1 in query1)
            {
                Console.WriteLine(q1.ToString());
            }

            //将所有的订单序列化为XML文件
            Console.WriteLine("将所有的订单序列化为XML文件：");
            Console.WriteLine(File.ReadAllText(OrderService.Export(OrderService.orders, "s.xml")));

            Order Tobeload = new Order(010, "客户10", new ProductDetails(10,"商品" , 100), new ProductDetails(11,"商品11", 110));
            List<Order> Neworder = new List<Order>();
            Neworder.Add(Tobeload);
            Console.WriteLine("新产生订单:");
            Console.WriteLine(File.ReadAllText(OrderService.Export(Neworder, "n.xml")));
            OrderService.Import(OrderService.Export(Neworder, "n.xml"));

            Console.WriteLine("加入新产生的订单后，所有订单如下： ");
            var que_2 = OrderService.QueryAll();
            foreach (var theorder in que_2)
            {
                Console.WriteLine(theorder.ToString());
            }


            /*对订单程序中OrderService的各个Public方法添加测试用例
            //查询订单
            Console.WriteLine("订单按订单号查询：");
            var query2 = OrderService.QueryById(003);
            foreach (var q2 in query2)
            {
                Console.WriteLine(q2.ToString());
            }

            Console.WriteLine("订单按客户名查询：");
            var query3 = OrderService.QueryByClientName("客户7");
            foreach (var q3 in query3)
            {
                Console.WriteLine(q3.ToString());
            }

            Console.WriteLine("订单按商品号查询：");
            var query4 = OrderService.QueryByProductId(01);
            foreach (var q4 in query4)
            {
                Console.WriteLine(q4.ToString());
            }

            Console.WriteLine("订单按商品名查询：");
            var query5 = OrderService.QueryByProductName("商品6");
            foreach (var q5 in query5)
            {
                Console.WriteLine(q5.ToString());
            }

            Console.WriteLine("订单按商品价格查询：");
            var query6 = OrderService.QueryByProductPrice(23);
            foreach (var q6 in query6)
            {
                Console.WriteLine(q6.ToString());
            }

            //更改订单
            Console.WriteLine("更改订单：");
            OrderService.UpdateOrder(new Order(001, "客户10", new ProductDetails(10, "商品10", 64)));
            Console.WriteLine("更改后的订单如下：");
            var query7 = OrderService.QueryAll();
            foreach (var q7 in query7)
            {
                Console.WriteLine(q7.ToString());
            }

            //删除订单
            Console.WriteLine("删除订单：");
            OrderService.DeleteOrder(007);
            Console.WriteLine("删除后的订单如下：");
            var query8 = OrderService.QueryAll();
            foreach (var q8 in query8)
            {
                Console.WriteLine(q8.ToString());
            }

            */
        }
    }
}
