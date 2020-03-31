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
        //�������ݡ���������ϸ
        OrderItem itemOne = new OrderItem("Ǧ��", 5, 1);
        OrderItem itemTwo = new OrderItem("�ֱ�", 10, 50);
        OrderItem itemThree = new OrderItem("Բ���", 20, 2);
        OrderItem itemFour = new OrderItem("��Ƥ��", 20, 2);
        OrderItem itemFive = new OrderItem("����", 200, 10);
        OrderItem itemSix = new OrderItem("����", 300, 5);

        //�������ݡ�������
        Order order1 = new Order("�ľ�", "hhx", 600);
        Order order2 = new Order("�˶�����", "Tom", 5000);
        Order order3 = new Order("����", "hhx", 3000);


        [TestInitialize]
        public void TeseInitialize()
        {
           
        }

        //��Ӷ�������������
        [TestMethod]
        public void AddOrderTest1()
        {
            OrderService service = new OrderService();
            order1.AddItems(itemFive);
            service.AddOrder(order1);

            Assert.IsTrue(service.saveList.Count == 1&& service.saveList[0] == order1);
        }

        //��Ӷ������ն���
        [TestMethod]
        public void AddOrderTest2()
        {
            OrderService service = new OrderService();
            Order order4 = new Order();
            service.AddOrder(order4);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order4);
        }

        //��Ӷ������ظ�����
        [TestMethod]
        public void AddOrderTest3()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order1);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order1);
        }

        //ɾ������,��������
        [TestMethod]
        public void DelOrder1()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);

            service.DelOrder(order1.OrderNum);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order2);
        }

        //ɾ������������������
        [TestMethod]
        public void DelOrder2()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);

            service.DelOrder(2334);

            Assert.IsTrue(service.saveList.Count == 2 && service.saveList[0] == order1&&service.saveList[1]==order2);
        }

        //�޸Ķ�������������
        [TestMethod]
        public void ChangeOrderTest1()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);

            service.ChangeOrder(order1.OrderNum, order2);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order2);
        }
        
        //�޸Ķ���������������
        [TestMethod]
        public void ChangeOrderTest2()
        {
            OrderService service = new OrderService();
            service.AddOrder(order1);

            service.ChangeOrder(120304, order2);

            Assert.IsTrue(service.saveList.Count == 1 && service.saveList[0] == order1);
        }

        //��ѯ��������������
        [TestMethod]
        public void FindOrderTest1()
        {
            Order order1 = new Order("�ľ�", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("�˶�����", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("����", "hhx", 3000);
            OrderService service = new OrderService();
            order1.AddItems(itemOne);
            order2.AddItems(itemTwo);
            order3.AddItems(itemThree);
            service.AddOrder(order1);
            service.AddOrder(order2);

            List<Order> getResult1 = new List<Order>();
            List<Order> getResult2 = new List<Order>();
            List<Order> getResult3 = new List<Order>();

            //�����Ų�ѯ
            getResult1 = service.FindOrder(order1.orderNum);
            //��Ʒ���ƺͿͻ�����ѯ
            getResult2 = service.FindOrder("Ǧ��");
            getResult3 = service.FindOrder("hhx");

            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1);
            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1 );
            Assert.IsTrue(getResult1.Count == 1 && getResult1[0] == order1);
        }

        //��ѯ����������������
        [TestMethod]
        public void FindOrderTest2()
        {
            Order order1 = new Order("�ľ�", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("�˶�����", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("����", "hhx", 3000);
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
            

            //�����Ų�ѯ
            getResult1 = service.FindOrder(120303);
            //��Ʒ���ƺͿͻ�����ѯ
            getResult2 = service.FindOrder("����");
            getResult3 = service.FindOrder("hh");

            Assert.IsTrue(getResult1.Count == 0 );
            Assert.IsTrue(getResult1.Count == 0);
            Assert.IsTrue(getResult1.Count == 0);
        }

        //��������Ĭ������
        [TestMethod]
        public void DefSortTest()
        {
            Order order1 = new Order("�ľ�", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("�˶�����", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("����", "hhx", 3000);
            OrderService service = new OrderService();

            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

          bool result = service.DefSort();

            Assert.IsTrue(result);
            Assert.IsTrue(service.saveList[0] == order1 && service.saveList[1] == order2 && service.saveList[2] == order3);
        }

        //���������Զ���
        [TestMethod]
        public void SelfDefSortTest()
        {
            Order order1 = new Order("�ľ�", "hhx", 600);
            Thread.Sleep(1000);
            Order order2 = new Order("�˶�����", "Tom", 5000);
            Thread.Sleep(1000);
            Order order3 = new Order("����", "hhx", 3000);
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
