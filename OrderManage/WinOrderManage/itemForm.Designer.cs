namespace WinOrderManage
{
    partial class itemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cargoNum = new System.Windows.Forms.TextBox();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.txt_cargoName = new System.Windows.Forms.TextBox();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.lbl_cargoNum = new System.Windows.Forms.Label();
            this.lbl_cargoName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(327, 266);
            this.groupBox2.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 272);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "itemForm";
            this.Text = "订单明细";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cargoNum;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.TextBox txt_cargoName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.Label lbl_cargoNum;
        private System.Windows.Forms.Label lbl_cargoName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}