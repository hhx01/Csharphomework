namespace WinOrderManage
{
    partial class InfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CustomName = new System.Windows.Forms.TextBox();
            this.txt_Receivables = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Receivables = new System.Windows.Forms.Label();
            this.lbl_CustomName = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 298);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 301);
            this.panel1.TabIndex = 6;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Text = "订单信息";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CustomName;
        private System.Windows.Forms.TextBox txt_Receivables;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Receivables;
        private System.Windows.Forms.Label lbl_CustomName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}