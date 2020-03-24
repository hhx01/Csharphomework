using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class Order:IComparable<Order>
    {
        private string orderTime, customeName,title;
        private  uint orderNum;
        private  double totalMoney, receivables, changeMoney;   //应收、实付、找零

        public string Title { get => title; }
        public string OrderTime { get => orderTime;  }
        public string CustomeName { get => customeName; }
        public uint OrderNum { get => orderNum; }
        public double TotalMoney { get=>totalMoney;}
        public double Receivables { get=>receivables; }
        public double ChangeMoney { get=>changeMoney; }
        
        //存储订单明细
        public List<OrderItem> itemList = new List<OrderItem>();

        public Order(string title,string customeName,double receivables)
        {
            DateTime time = DateTime.Now;
            this.title = title;
            this.orderTime = time.ToString();
            this.customeName = customeName;
            this.orderNum = uint.Parse(time.Day.ToString()+time.Hour.ToString()+time.Minute.ToString()+time.Second.ToString());
            this.receivables = receivables;
            this.totalMoney = 0;
            this.changeMoney = 0;
        }

        //添加明细项
        public void AddItems(OrderItem item)
        {
            foreach(OrderItem oi in itemList)
            {
                if (item.Equals(oi))
                {
                    Console.WriteLine("添加失败！明细重复！");
                    return;
                }
            }
            itemList.Add(item);
            totalMoney += item.Money;
            changeMoney = receivables - totalMoney;
            Console.WriteLine("添加成功！");
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.orderNum == orderNum&&m.customeName == customeName;
        }

        public override string ToString()
        {
            string tmp = "项目："+title+"\n"+"订单号：" + orderNum + "\n" + "时间：" + orderTime + "\t" + "姓名：" + customeName + "\n" + "应收：" + totalMoney +"\t"+ "实付：" + receivables + "\t" + "找零：" + changeMoney+"\n"+"商品名称 ||数量 ||单价 ||金额" + "\n" ;
            foreach (OrderItem i in itemList)
            {
                tmp += i.ToString()+"\n";
            }
            return tmp;
        }

        public int CompareTo(Order other)
        {
            return this.orderNum.CompareTo(other.orderNum);
        }
    }
}
