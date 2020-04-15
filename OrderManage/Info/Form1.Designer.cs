namespace Info
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CustomName = new System.Windows.Forms.TextBox();
            this.txt_Receivables = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Receivables = new System.Windows.Forms.Label();
            this.lbl_CustomName = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cargoNum = new System.Windows.Forms.TextBox();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.txt_cargoName = new System.Windows.Forms.TextBox();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.lbl_cargoNum = new System.Windows.Forms.Label();
            this.lbl_cargoName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(638, 294);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_CustomName);
            this.groupBox1.Controls.Add(this.txt_Receivables);
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Controls.Add(this.lbl_Receivables);
            this.groupBox1.Controls.Add(this.lbl_CustomName);
            this.groupBox1.Controls.Add(this.lbl_Title);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单";
            // 
            // txt_CustomName
            // 
            this.txt_CustomName.Location = new System.Drawing.Point(143, 111);
            this.txt_CustomName.Name = "txt_CustomName";
            this.txt_CustomName.Size = new System.Drawing.Size(100, 25);
            this.txt_CustomName.TabIndex = 5;
            // 
            // txt_Receivables
            // 
            this.txt_Receivables.Location = new System.Drawing.Point(143, 169);
            this.txt_Receivables.Name = "txt_Receivables";
            this.txt_Receivables.Size = new System.Drawing.Size(100, 25);
            this.txt_Receivables.TabIndex = 4;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(143, 53);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(100, 25);
            this.txt_Title.TabIndex = 3;
            // 
            // lbl_Receivables
            // 
            this.lbl_Receivables.AutoSize = true;
            this.lbl_Receivables.Location = new System.Drawing.Point(47, 179);
            this.lbl_Receivables.Name = "lbl_Receivables";
            this.lbl_Receivables.Size = new System.Drawing.Size(52, 15);
            this.lbl_Receivables.TabIndex = 2;
            this.lbl_Receivables.Text = "实付：";
            // 
            // lbl_CustomName
            // 
            this.lbl_CustomName.AutoSize = true;
            this.lbl_CustomName.Location = new System.Drawing.Point(47, 121);
            this.lbl_CustomName.Name = "lbl_CustomName";
            this.lbl_CustomName.Size = new System.Drawing.Size(67, 15);
            this.lbl_CustomName.TabIndex = 1;
            this.lbl_CustomName.Text = "客户名：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(47, 63);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(52, 15);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "订单：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_cargoNum);
            this.groupBox2.Controls.Add(this.txt_unitPrice);
            this.groupBox2.Controls.Add(this.txt_cargoName);
            this.groupBox2.Controls.Add(this.lbl_unitPrice);
            this.groupBox2.Controls.Add(this.lbl_cargoNum);
            this.groupBox2.Controls.Add(this.lbl_cargoName);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 288);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // txt_cargoNum
            // 
            this.txt_cargoNum.Location = new System.Drawing.Point(158, 111);
            this.txt_cargoNum.Name = "txt_cargoNum";
            this.txt_cargoNum.Size = new System.Drawing.Size(100, 25);
            this.txt_cargoNum.TabIndex = 11;
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(158, 169);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(100, 25);
            this.txt_unitPrice.TabIndex = 10;
            // 
            // txt_cargoName
            // 
            this.txt_cargoName.Location = new System.Drawing.Point(158, 53);
            this.txt_cargoName.Name = "txt_cargoName";
            this.txt_cargoName.Size = new System.Drawing.Size(100, 25);
            this.txt_cargoName.TabIndex = 9;
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Location = new System.Drawing.Point(62, 179);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(52, 15);
            this.lbl_unitPrice.TabIndex = 8;
            this.lbl_unitPrice.Text = "单价：";
            // 
            // lbl_cargoNum
            // 
            this.lbl_cargoNum.AutoSize = true;
            this.lbl_cargoNum.Location = new System.Drawing.Point(62, 121);
            this.lbl_cargoNum.Name = "lbl_cargoNum";
            this.lbl_cargoNum.Size = new System.Drawing.Size(52, 15);
            this.lbl_cargoNum.TabIndex = 7;
            this.lbl_cargoNum.Text = "数量：";
            // 
            // lbl_cargoName
            // 
            this.lbl_cargoName.AutoSize = true;
            this.lbl_cargoName.Location = new System.Drawing.Point(62, 63);
            this.lbl_cargoName.Name = "lbl_cargoName";
            this.lbl_cargoName.Size = new System.Drawing.Size(82, 15);
            this.lbl_cargoName.TabIndex = 6;
            this.lbl_cargoName.Text = "商品名称：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 358);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "订单信息";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CustomName;
        private System.Windows.Forms.TextBox txt_Receivables;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Receivables;
        private System.Windows.Forms.Label lbl_CustomName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cargoNum;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.TextBox txt_cargoName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.Label lbl_cargoNum;
        private System.Windows.Forms.Label lbl_cargoName;
        private System.Windows.Forms.Button button1;
    }
}

