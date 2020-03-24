using System;
using System.Threading;
using System.Collections.Generic;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试数据——订单明细
            OrderItem itemOne = new OrderItem("铅笔", 5, 1);
            OrderItem itemTwo = new OrderItem("钢笔", 10, 50);
            OrderItem itemThree = new OrderItem("圆珠笔", 20, 2);
            OrderItem itemFour = new OrderItem("橡皮擦", 20, 2);
            OrderItem itemFive = new OrderItem("篮球", 200,10);
            OrderItem itemSix = new OrderItem("足球", 300, 5);

            //测试数据——订单
            Order order1 = new Order("文具", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("运动器材", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("其他", "hhx", 3000);

            //添加明细
            Console.WriteLine("添加订单明细：");
            order1.AddItems(itemOne);
            order1.AddItems(itemTwo);
            order1.AddItems(itemThree);
            order2.AddItems(itemSix);
            order2.AddItems(itemFive);
            order3.AddItems(itemFive);
            order3.AddItems(itemOne);

            //添加订单
            Console.WriteLine("添加订单：");
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order1);

            //输出订单信息
            Console.WriteLine(service.ToString());

            //删除订单
            Console.WriteLine("删除order2：");
            service.DelOrder(order2.OrderNum);
            //service.DelOrder(2);              //订单号错误删除失败
            Console.WriteLine("当前订单状况:\n{0}", service.ToString());

            //修改订单,将order1修改为order3
            service.ChangeOrder(order1.OrderNum, order3);
            Console.WriteLine("当前订单状况:\n{0}", service.ToString());

            //查询订单，按照订单号
            service.AddOrder(order2);
            service.AddOrder(order1);
            var tmp = service.FindOrder(order1.OrderNum);
            service.SelfDefSort();
            if (tmp.Count != 0)
            {
                for (int n = 0; n < tmp.Count; n++)
                {
                    Console.WriteLine(tmp[n].ToString());
                }
            }
            //订单查询，按照商品名称和客户
            var tmp1=service.FindOrder("其他");
            var tmp2 = service.FindOrder("Tom");
            foreach(Order o in tmp1) { Console.WriteLine("按照商品名：\n{0}",o.ToString()); }
            foreach (Order o in tmp2) { Console.WriteLine("按照客户名：\n{0}",o.ToString()); }

            //订单排序
            Console.WriteLine("未排序：\n{0}", service.ToString());
            service.DefSort();
            Console.WriteLine("默认排序：\n{0}", service.ToString());
            service.SelfDefSort();
            Console.WriteLine("lambda表达式自定义排序：\n{0}", service.ToString());

            Console.Read();

        }
    }
}
