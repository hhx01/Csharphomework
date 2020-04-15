namespace WinOrderManagement
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddOrder_btn = new System.Windows.Forms.Button();
            this.ChangOrder_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Sort_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Seek_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.AddOrder_btn);
            this.flowLayoutPanel1.Controls.Add(this.ChangOrder_btn);
            this.flowLayoutPanel1.Controls.Add(this.Delete_btn);
            this.flowLayoutPanel1.Controls.Add(this.Sort_btn);
            this.flowLayoutPanel1.Controls.Add(this.Seek_btn);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddOrder_btn
            // 
            this.AddOrder_btn.Location = new System.Drawing.Point(3, 10);
            this.AddOrder_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.AddOrder_btn.Name = "AddOrder_btn";
            this.AddOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.AddOrder_btn.TabIndex = 0;
            this.AddOrder_btn.Text = "添加";
            this.AddOrder_btn.UseVisualStyleBackColor = true;
            // 
            // ChangOrder_btn
            // 
            this.ChangOrder_btn.Location = new System.Drawing.Point(84, 10);
            this.ChangOrder_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.ChangOrder_btn.Name = "ChangOrder_btn";
            this.ChangOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.ChangOrder_btn.TabIndex = 1;
            this.ChangOrder_btn.Text = "修改";
            this.ChangOrder_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(165, 10);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "删除";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Sort_btn
            // 
            this.Sort_btn.ForeColor = System.Drawing.Color.Black;
            this.Sort_btn.Location = new System.Drawing.Point(246, 10);
            this.Sort_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Sort_btn.Name = "Sort_btn";
            this.Sort_btn.Size = new System.Drawing.Size(75, 23);
            this.Sort_btn.TabIndex = 3;
            this.Sort_btn.Text = "排序";
            this.Sort_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20, 10, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 25);
            this.textBox1.TabIndex = 4;
            // 
            // Seek_btn
            // 
            this.Seek_btn.Location = new System.Drawing.Point(327, 10);
            this.Seek_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Seek_btn.Name = "Seek_btn";
            this.Seek_btn.Size = new System.Drawing.Size(75, 23);
            this.Seek_btn.TabIndex = 5;
            this.Seek_btn.Text = "查询";
            this.Seek_btn.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-1, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(822, 398);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 459);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddOrder_btn;
        private System.Windows.Forms.Button ChangOrder_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Sort_btn;
        private System.Windows.Forms.Button Seek_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

