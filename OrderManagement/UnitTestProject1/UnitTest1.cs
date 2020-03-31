using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderServiceTest
    {
        //测试数据——订单明细
        OrderItem itemOne = new OrderItem("铅笔", 5, 1);
        OrderItem itemTwo = new OrderItem("钢笔", 10, 50);
        OrderItem itemThree = new OrderItem("圆珠笔", 20, 2);
        OrderItem itemFour = new OrderItem("橡皮擦", 20, 2);
        OrderItem itemFive = new OrderItem("篮球", 200, 10);
        OrderItem itemSix = new OrderItem("足球", 300, 5);

        //测试数据——订单
        Order order1 = new Order("文具", "hhx", 600);
        Order order2 = new Order("运动器材", "Tom", 5000);
        Order order3 = new Order("其他", "hhx", 3000);


        [TestInitialize]
        public void TeseInitialize()
        {
           
        }

        //添加订单，正常订单
        [TestMethod]
        public void AddOrderTest1()
        {
            OrderService service = new OrderService();
            order1.AddItems(itemFive);
            service.AddOrder(order1);

            Assert.IsTrue(service.saveList.Count == 1&& service.saveList[0] == order1);
        }

        //添加订单，空订单
        [TestMethod]
        public void AddOrderTest2()
        {
            OrderService service = new OrderService();
            Order order4 = new Order();
            service.AddOrder(order4);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order4);
        }

        //添加订单，重复订单
        [TestMethod]
        public void AddOrderTest3()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order1);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order1);
        }

        //删除订单,正常订单
        [TestMethod]
        public void DelOrder1()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);

            service.DelOrder(order1.OrderNum);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order2);
        }

        //删除订单，订单不存在
        [TestMethod]
        public void DelOrder2()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);

            service.DelOrder(2334);

            Assert.IsTrue(service.saveList.Count == 2 && service.saveList[0] == order1&&service.saveList[1]==order2);
        }

        //修改订单，正常订单
        [TestMethod]
        public void ChangeOrderTest1()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);

            service.ChangeOrder(order1.OrderNum, order2);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order2);
        }
        
        //修改订单，订单不存在
        [TestMethod]
        public void ChangeOrderTest2()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);

            service.ChangeOrder(120304, order2);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order1);
        }

        //查询订单，订单正常
        [TestMethod]
        public void FindOrderTest1()
        {
            Order order1 = new Order("文具", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("运动器材", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("其他", "hhx", 3000);
            OrderService service = new OrderService();
            order1.AddItems(itemOne);
            order2.AddItems(itemTwo);
            order3.AddItems(itemThree);
            service.AddOrder(order1);
            service.AddOrder(order2);

            List<Order> getResult1 = new List<Order>();
            List<Order> getResult2 = new List<Order>();
            List<Order> getResult3 = new List<Order>();

            //订单号查询
            getResult1 = service.FindOrder(order1.orderNum);
            //商品名称和客户名查询
            getResult2 = service.FindOrder("铅笔");
            getResult3 = service.FindOrder("hhx");

            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1);
            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1 );
            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1);
        }

        //查询订单，订单不存在
        [TestMethod]
        public void FindOrderTest2()
        {
            Order order1 = new Order("文具", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("运动器材", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("其他", "hhx", 3000);
            OrderService service = new OrderService();
            order1.AddItems(itemOne);
            order2.AddItems(itemTwo);
            order3.AddItems(itemThree);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

            List<Order> getResult1 = new List<Order>();
            List<Order> getResult2 = new List<Order>();
            List<Order> getResult3 = new List<Order>();
            

            //订单号查询
            getResult1 = service.FindOrder(120303);
            //商品名称和客户名查询
            getResult2 = service.FindOrder("篮球");
            getResult3 = service.FindOrder("hh");

            Assert.IsTrue(getResult1.Count == 0 );
            Assert.IsTrue(getResult1.Count == 0);
            Assert.IsTrue(getResult1.Count == 0);
        }

        //订单排序，默认排序
        [TestMethod]
        public void DefSortTest()
        {
            Order order1 = new Order("文具", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("运动器材", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("其他", "hhx", 3000);
            OrderService service = new OrderService();

            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

          bool result = service.DefSort();

            Assert.IsTrue(result);
            Assert.IsTrue(service.saveList[0] == order1 && service.saveList[1] == order2 && service.saveList[2] == order3);
        }

        //订单排序，自定义
        [TestMethod]
        public void SelfDefSortTest()
        {
            Order order1 = new Order("文具", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("运动器材", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("其他", "hhx", 3000);
            OrderService service = new OrderService();
            order1.AddItems(itemOne);
            order2.AddItems(itemTwo);
            order3.AddItems(itemThree);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

            bool result = service.SelfDefSort();

            Assert.IsTrue(result);
            Assert.IsTrue(service.saveList[0] == order1 && service.saveList[1] == order3 && service.saveList[2] == order2);
        }
    }
}
