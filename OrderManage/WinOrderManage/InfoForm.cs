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
    public partial class InfoForm : Form
    {
        OrderService service;
        Order order;

        public InfoForm( OrderService service,Order order)
        {
            InitializeComponent();
            this.order = order;
            this.service = service;
            txt_Title.DataBindings.Add("Text", order, "Title");
            txt_CustomName.DataBindings.Add("Text", order, "CustomeName");
            txt_Receivables.DataBindings.Add("Text", order, "Receivables");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.AddOrder(order);
            Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
           

        }
    }
}
