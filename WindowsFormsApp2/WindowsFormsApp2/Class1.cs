using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Class1
    {
        public String orderNO;
        public String OrderItem;
        public int quantity;
        public int price;
        public String Describtion;

        public Class1(String no, string item, String qun, String price, string des)
        {
            this.orderNO = no;
            this.OrderItem = item;
            this.quantity = Convert.ToInt32(qun);
            this.price = Convert.ToInt32(price);
            this.Describtion = des;
        }
        public String mymsg()
        {
            return "This is MGK";
        }
        public void myTexbox(String no,string item,String qun,String price,string des)
        {
            this.orderNO = no;
            this.OrderItem = item;
            this.quantity = Convert.ToInt32(qun);
            this.price = Convert.ToInt32(price);
            this.Describtion = des;
        }
        public String print()
        {
            return this.orderNO +"\n"+ this.OrderItem+"\n"+ this.quantity+"\n"+ this.price+"\n"+ this.Describtion;
        }

    }
}
