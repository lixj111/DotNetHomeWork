using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class ProductDetails
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public ProductDetails(int pid, string pname, double pprice)
        {
            ProductID = pid;
            ProductName = pname;
            ProductPrice = pprice;
        }

        public override bool Equals(object obj)
        {
            var pro = obj as ProductDetails;
            return pro != null && ProductID == pro.ProductID
                               && ProductName == pro.ProductName
                               && ProductPrice == pro.ProductPrice;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();//??
        }

        public override string ToString()
        {
            return ProductID + "：" + '\t' + ProductName + "价格为：" + ProductPrice +  "元"; 
        }
    }
}
