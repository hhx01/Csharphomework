namespace WinOrderManage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Seek = new System.Windows.Forms.Button();
            this.cbx_seek = new System.Windows.Forms.ComboBox();
            this.txtBox_insert = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_DelItem = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivablesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeMoneyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btn_Change);
            this.flowLayoutPanel1.Controls.Add(this.btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.btn_Sort);
            this.flowLayoutPanel1.Controls.Add(this.cbx_seek);
            this.flowLayoutPanel1.Controls.Add(this.txtBox_insert);
            this.flowLayoutPanel1.Controls.Add(this.btn_Seek);
            this.flowLayoutPanel1.Controls.Add(this.btn_return);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(833, 58);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 13);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 27);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(87, 13);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 27);
            this.btn_Change.TabIndex = 1;
            this.btn_Change.Text = "修改";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(168, 13);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 27);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(249, 13);
            this.btn_Sort.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 27);
            this.btn_Sort.TabIndex = 3;
            this.btn_Sort.Text = "排序";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Seek
            // 
            this.btn_Seek.Location = new System.Drawing.Point(616, 13);
            this.btn_Seek.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Seek.Name = "btn_Seek";
            this.btn_Seek.Size = new System.Drawing.Size(75, 27);
            this.btn_Seek.TabIndex = 4;
            this.btn_Seek.Text = "查询";
            this.btn_Seek.UseVisualStyleBackColor = true;
            this.btn_Seek.Click += new System.EventHandler(this.btn_Seek_Click);
            // 
            // cbx_seek
            // 
            this.cbx_seek.FormattingEnabled = true;
            this.cbx_seek.Items.AddRange(new object[] {
            "订单号",
            "客户名",
            "商品名"});
            this.cbx_seek.Location = new System.Drawing.Point(330, 15);
            this.cbx_seek.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cbx_seek.Name = "cbx_seek";
            this.cbx_seek.Size = new System.Drawing.Size(97, 23);
            this.cbx_seek.TabIndex = 6;
            // 
            // txtBox_insert
            // 
            this.txtBox_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBox_insert.Location = new System.Drawing.Point(433, 14);
            this.txtBox_insert.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtBox_insert.Name = "txtBox_insert";
            this.txtBox_insert.Size = new System.Drawing.Size(177, 25);
            this.txtBox_insert.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1349, 416);
            this.splitContainer1.SplitterDistance = 828;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 416);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.orderTimeDataGridViewTextBoxColumn1,
            this.customeNameDataGridViewTextBoxColumn1,
            this.orderNumDataGridViewTextBoxColumn1,
            this.totalMoneyDataGridViewTextBoxColumn1,
            this.receivablesDataGridViewTextBoxColumn1,
            this.changeMoneyDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.orderBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(824, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(OrderManage.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargoNameDataGridViewTextBoxColumn,
            this.cargoNumDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderItemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(516, 416);
            this.dataGridView2.TabIndex = 1;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderManage.OrderItem);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btn_AddItem);
            this.flowLayoutPanel2.Controls.Add(this.btn_DelItem);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(895, 9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(211, 58);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(3, 10);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(96, 29);
            this.btn_AddItem.TabIndex = 0;
            this.btn_AddItem.Text = "添加明细";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_DelItem
            // 
            this.btn_DelItem.Location = new System.Drawing.Point(105, 10);
            this.btn_DelItem.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_DelItem.Name = "btn_DelItem";
            this.btn_DelItem.Size = new System.Drawing.Size(94, 29);
            this.btn_DelItem.TabIndex = 1;
            this.btn_DelItem.Text = "删除明细";
            this.btn_DelItem.UseVisualStyleBackColor = true;
            this.btn_DelItem.Click += new System.EventHandler(this.btn_DelItem_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.btn_out);
            this.flowLayoutPanel3.Controls.Add(this.btn_in);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1167, 9);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(188, 58);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(3, 10);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(86, 29);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "导出订单";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(95, 10);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(86, 29);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "导入订单";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(697, 13);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(104, 27);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "返回全部";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "订单名";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn1
            // 
            this.orderTimeDataGridViewTextBoxColumn1.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn1.HeaderText = "订单时间";
            this.orderTimeDataGridViewTextBoxColumn1.Name = "orderTimeDataGridViewTextBoxColumn1";
            this.orderTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customeNameDataGridViewTextBoxColumn1
            // 
            this.customeNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomeName";
            this.customeNameDataGridViewTextBoxColumn1.HeaderText = "客户名";
            this.customeNameDataGridViewTextBoxColumn1.Name = "customeNameDataGridViewTextBoxColumn1";
            this.customeNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderNumDataGridViewTextBoxColumn1
            // 
            this.orderNumDataGridViewTextBoxColumn1.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn1.HeaderText = "订单号";
            this.orderNumDataGridViewTextBoxColumn1.Name = "orderNumDataGridViewTextBoxColumn1";
            this.orderNumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalMoneyDataGridViewTextBoxColumn1
            // 
            this.totalMoneyDataGridViewTextBoxColumn1.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn1.HeaderText = "总金额";
            this.totalMoneyDataGridViewTextBoxColumn1.Name = "totalMoneyDataGridViewTextBoxColumn1";
            this.totalMoneyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // receivablesDataGridViewTextBoxColumn1
            // 
            this.receivablesDataGridViewTextBoxColumn1.DataPropertyName = "Receivables";
            this.receivablesDataGridViewTextBoxColumn1.HeaderText = "实收金额";
            this.receivablesDataGridViewTextBoxColumn1.Name = "receivablesDataGridViewTextBoxColumn1";
            this.receivablesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // changeMoneyDataGridViewTextBoxColumn1
            // 
            this.changeMoneyDataGridViewTextBoxColumn1.DataPropertyName = "ChangeMoney";
            this.changeMoneyDataGridViewTextBoxColumn1.HeaderText = "找零";
            this.changeMoneyDataGridViewTextBoxColumn1.Name = "changeMoneyDataGridViewTextBoxColumn1";
            this.changeMoneyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cargoNameDataGridViewTextBoxColumn
            // 
            this.cargoNameDataGridViewTextBoxColumn.DataPropertyName = "CargoName";
            this.cargoNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.cargoNameDataGridViewTextBoxColumn.Name = "cargoNameDataGridViewTextBoxColumn";
            // 
            // cargoNumDataGridViewTextBoxColumn
            // 
            this.cargoNumDataGridViewTextBoxColumn.DataPropertyName = "CargoNum";
            this.cargoNumDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.cargoNumDataGridViewTextBoxColumn.Name = "cargoNumDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 498);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "订单管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Seek;
        private System.Windows.Forms.TextBox txtBox_insert;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_DelItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.ComboBox cbx_seek;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivablesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeMoneyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}

