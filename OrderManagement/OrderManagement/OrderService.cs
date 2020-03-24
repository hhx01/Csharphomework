using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    class OrderService
    {
        List<Order> saveList = new List<Order>();
        private uint listCount = 0;

        //添加新订单
        public void AddOrder(Order order1)
        {
            foreach(Order o in saveList)
            {
                if (order1.Equals(o))
                {
                    Console.WriteLine("添加失败！订单重复！");
                    return;
                }
            }
            saveList.Add(order1);
            Console.WriteLine("添加成功！");
        }

        //删除订单
        public void DelOrder(uint orderNum)
        {
            var ord = saveList.Where(s => s.OrderNum == orderNum).ToList();
            if(ord.Count==0)
            {
                Console.WriteLine("抱歉，删除失败！未能查询到相关订单!");
                return;
            }
                saveList.Remove(saveList.Find(delegate (Order o) { return o.OrderNum == orderNum; }));
                Console.WriteLine("删除成功！");
        }

        //修改订单,按照订单号查询并修改
        public void ChangeOrder(uint orderNumber,Order newOrder) {
            for(int n = 0;n<saveList.Count;n++)
            {
                if(saveList[n].OrderNum == orderNumber)
                {
                    saveList[n] = newOrder;
                    return;
                }
            }
            Console.WriteLine("抱歉，未能找到您所修改的订单！");
        }

        //查询订单（按照订单号(orderNum)、商品名称(title)、客户(customeName)等字段进行查询）
        public List<Order> FindOrder(uint orderNum) {
            var order = saveList.Where(s => s.OrderNum == orderNum).ToList();
            if (order.Count==0)
            {
                Console.WriteLine("抱歉,未能查询到相关订单!");
                return order;
            }
            else {
                Console.WriteLine("查询成功！订单内容如下：");
                order.Sort((Order x, Order y) => x.TotalMoney.CompareTo(y.TotalMoney));
                return order;
            }
        }

        public List<Order> FindOrder(string Name)
        {
            var order1 = from n in saveList where n.Title == Name select n;
            var order2 = from n in saveList where n.CustomeName == Name select n;
            if (order1.ToList().Count == 0&&order2.ToList().Count == 0)
            {
                Console.WriteLine("抱歉,未能查询到相关订单!");
                return order1.ToList();
            }
            else
            {
                Console.WriteLine("查询成功！订单内容如下：");
                if (order1.ToList().Count != 0)
                {
                    return order1.ToList();
                }
                else
                {
                    return order2.ToList();
                }
            }
        }

        //ToString
        public override string ToString()
        {
            string tmp = "============================\n";
            foreach (Order o in saveList)
            {
                tmp = tmp + o.ToString() + "\n";
            }
            return tmp;
        }

        //排序,默认按照订单号排序
        public bool DefSort()
        {
            if(saveList.Count == 0)
            {
                return false;
            }
            saveList.Sort();
            return true;
        }

        //自定义排序,按照应付排序
       public bool SelfDefSort()
        {
            if(saveList.Count == 0)
            {
                return false;
            }
            saveList.Sort((Order x,Order y)=>  x.TotalMoney.CompareTo(y.TotalMoney));
            return true;
        }
    }
}
