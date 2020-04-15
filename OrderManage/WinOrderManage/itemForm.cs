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
    public partial class itemForm : Form
    {
        OrderItem item = new OrderItem();
        Order order;

        public itemForm(Order order)
        {
            InitializeComponent();
            this.order = order;
            txt_cargoName.DataBindings.Add("Text", item, "cargoName");
            txt_cargoNum.DataBindings.Add("Text", item, "cargoNum");
            txt_unitPrice.DataBindings.Add("Text", item, "unitPrice");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.cargoName = txt_cargoName.Text;
            item.cargoNum = Convert.ToUInt32(txt_cargoNum.Text);
            item.unitPrice = Convert.ToUInt32(txt_unitPrice.Text);
            order.AddItems(item);
            Close();
        }
    }
}
