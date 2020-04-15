using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;

namespace WinOrderManage
{
    public partial class Form1 : Form
    {
        OrderService service = new OrderService();
       // BindingSource source;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderBindingSource1.DataSource = service.saveList;
            dataGridView1.DataSource = orderBindingSource1;
        }

        //添加新订单
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            InfoForm form = new InfoForm(service,order);
            form.ShowDialog();
            orderBindingSource1.ResetBindings(false);
        }

        //添加订单明细
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource1.Current as Order;
            if (currentOrder == null) { MessageBox.Show("请选择订单！", "Error", MessageBoxButtons.OK);return; }
            itemForm form = new itemForm(currentOrder);
            form.ShowDialog();
            orderItemBindingSource.ResetBindings(false);
            orderBindingSource1.ResetBindings(false);
            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK);
        }

        //显示订单明细
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Order currentOrder = orderBindingSource1.Current as Order;
            orderItemBindingSource.DataSource = currentOrder.itemList;
            dataGridView2.DataSource = orderItemBindingSource;
            orderItemBindingSource.ResetBindings(true);
        }

        //修改订单
        private void btn_Change_Click(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource1.Current as Order;
            if(currentOrder == null) { MessageBox.Show("选择要修改的订单！", "Error",MessageBoxButtons.OK); return; }
            InfoForm form = new InfoForm(service, currentOrder);
            form.ShowDialog();
        }

        //删除订单
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource1.Current as Order;
            if (currentOrder == null) { MessageBox.Show("选择要删除的订单！", "Error", MessageBoxButtons.OK); return; }
            service.DelOrder(currentOrder.OrderNum);
            orderBindingSource1.ResetBindings(false);
            MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
        }

        //订单排序
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            bool flag = service.SelfDefSort();
            if (flag)
            {
                orderBindingSource1.ResetBindings(true);
                MessageBox.Show("排序成功", "提示", MessageBoxButtons.OK);
            }
            else MessageBox.Show("排序失败", "提示", MessageBoxButtons.OK);
        }

        //订单查询
        private void btn_Seek_Click(object sender, EventArgs e)
        {
            List<Order> order = new List<Order>();
            string insert = txtBox_insert.Text;
            if(insert == "") { MessageBox.Show("请输入查询关键词！", "提示", MessageBoxButtons.OK);return; }
            switch (cbx_seek.SelectedItem)
            {
                case "订单号":
                    order = service.FindOrder(Convert.ToUInt32(insert));
                    break;
                default:
                   order = service.FindOrder(insert);
                    break;
            }
            orderBindingSource1.DataSource = order;
            dataGridView1.DataSource = orderBindingSource1;
            orderBindingSource1.ResetBindings(false);
        }

        //返回全部订单
        private void btn_return_Click(object sender, EventArgs e)
        {
            orderBindingSource1.DataSource = service.saveList;
            dataGridView1.DataSource = orderBindingSource1;
            orderBindingSource1.ResetBindings(false);
        }

        //删除明细
        private void btn_DelItem_Click(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource1.Current as Order;
            OrderItem item = orderItemBindingSource.Current as OrderItem;
            if(item == null) { MessageBox.Show("请选择要删除的订单明细！", "提示", MessageBoxButtons.OK);return; }
            currentOrder.itemList.Remove(item);
            orderItemBindingSource.ResetBindings(true);
        }

        //导出
        private void btn_out_Click(object sender, EventArgs e)
        {
            service.Export();
            MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK);
        }

        //导入
        private void btn_in_Click(object sender, EventArgs e)
        {
            List<Order> importOrder = new List<Order>();
            importOrder = service.Import();
            foreach(Order o in importOrder) { service.saveList.Add(o); }
            orderItemBindingSource.ResetBindings(true);
            MessageBox.Show("导入成功！", "提示", MessageBoxButtons.OK);
        }
    }
}
