namespace CayleyTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.nDepth = new System.Windows.Forms.Label();
            this.ThR = new System.Windows.Forms.Label();
            this.per2L = new System.Windows.Forms.Label();
            this.per1R = new System.Windows.Forms.Label();
            this.leng = new System.Windows.Forms.Label();
            this.ThL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trb_nValue = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.lengValue = new System.Windows.Forms.Label();
            this.per1Value = new System.Windows.Forms.Label();
            this.per2Value = new System.Windows.Forms.Label();
            this.ThRValue = new System.Windows.Forms.Label();
            this.Th2Value = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.Label();
            this.trbLeng = new System.Windows.Forms.TrackBar();
            this.trbPer1 = new System.Windows.Forms.TrackBar();
            this.trbPer2 = new System.Windows.Forms.TrackBar();
            this.trbTh1 = new System.Windows.Forms.TrackBar();
            this.trbTh2 = new System.Windows.Forms.TrackBar();
            this.drawPanel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb_nValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // nDepth
            // 
            this.nDepth.AutoSize = true;
            this.nDepth.Location = new System.Drawing.Point(6, 173);
            this.nDepth.Name = "nDepth";
            this.nDepth.Size = new System.Drawing.Size(82, 15);
            this.nDepth.TabIndex = 1;
            this.nDepth.Text = "递归深度：";
            // 
            // ThR
            // 
            this.ThR.AutoSize = true;
            this.ThR.Location = new System.Drawing.Point(6, 389);
            this.ThR.Name = "ThR";
            this.ThR.Size = new System.Drawing.Size(97, 15);
            this.ThR.TabIndex = 2;
            this.ThR.Text = "右分支角度：";
            // 
            // per2L
            // 
            this.per2L.AutoSize = true;
            this.per2L.Location = new System.Drawing.Point(6, 335);
            this.per2L.Name = "per2L";
            this.per2L.Size = new System.Drawing.Size(112, 15);
            this.per2L.TabIndex = 3;
            this.per2L.Text = "左分支长度比：";
            // 
            // per1R
            // 
            this.per1R.AutoSize = true;
            this.per1R.Location = new System.Drawing.Point(6, 281);
            this.per1R.Name = "per1R";
            this.per1R.Size = new System.Drawing.Size(112, 15);
            this.per1R.TabIndex = 4;
            this.per1R.Text = "右分支长度比：";
            // 
            // leng
            // 
            this.leng.AutoSize = true;
            this.leng.Location = new System.Drawing.Point(6, 227);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(82, 15);
            this.leng.TabIndex = 5;
            this.leng.Text = "主干长度：";
            // 
            // ThL
            // 
            this.ThL.AutoSize = true;
            this.ThL.ForeColor = System.Drawing.Color.Black;
            this.ThL.Location = new System.Drawing.Point(6, 443);
            this.ThL.Name = "ThL";
            this.ThL.Size = new System.Drawing.Size(97, 15);
            this.ThL.TabIndex = 6;
            this.ThL.Text = "左分支角度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "画笔颜色：";
            // 
            // trb_nValue
            // 
            this.trb_nValue.Location = new System.Drawing.Point(68, 163);
            this.trb_nValue.Maximum = 20;
            this.trb_nValue.Name = "trb_nValue";
            this.trb_nValue.Size = new System.Drawing.Size(144, 56);
            this.trb_nValue.TabIndex = 8;
            this.trb_nValue.Scroll += new System.EventHandler(this.trb_nValue_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nDepth);
            this.groupBox1.Controls.Add(this.leng);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.per1R);
            this.groupBox1.Controls.Add(this.ThL);
            this.groupBox1.Controls.Add(this.per2L);
            this.groupBox1.Controls.Add(this.ThR);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 511);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.lengValue);
            this.groupBox2.Controls.Add(this.per1Value);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.per2Value);
            this.groupBox2.Controls.Add(this.ThRValue);
            this.groupBox2.Controls.Add(this.Th2Value);
            this.groupBox2.Controls.Add(this.nValue);
            this.groupBox2.Controls.Add(this.trbLeng);
            this.groupBox2.Controls.Add(this.trbPer1);
            this.groupBox2.Controls.Add(this.trbPer2);
            this.groupBox2.Controls.Add(this.trbTh1);
            this.groupBox2.Controls.Add(this.trbTh2);
            this.groupBox2.Controls.Add(this.trb_nValue);
            this.groupBox2.Location = new System.Drawing.Point(133, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 511);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "红色",
            "绿色",
            "蓝色",
            "黑色",
            "褐色",
            "紫色"});
            this.comboBoxColor.Location = new System.Drawing.Point(12, 117);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 23);
            this.comboBoxColor.TabIndex = 20;
            this.comboBoxColor.Text = "默认值";
            // 
            // lengValue
            // 
            this.lengValue.AutoSize = true;
            this.lengValue.Location = new System.Drawing.Point(9, 219);
            this.lengValue.Name = "lengValue";
            this.lengValue.Size = new System.Drawing.Size(15, 15);
            this.lengValue.TabIndex = 19;
            this.lengValue.Text = "0";
            // 
            // per1Value
            // 
            this.per1Value.AutoSize = true;
            this.per1Value.Location = new System.Drawing.Point(9, 275);
            this.per1Value.Name = "per1Value";
            this.per1Value.Size = new System.Drawing.Size(15, 15);
            this.per1Value.TabIndex = 18;
            this.per1Value.Text = "0";
            // 
            // per2Value
            // 
            this.per2Value.AutoSize = true;
            this.per2Value.Location = new System.Drawing.Point(9, 331);
            this.per2Value.Name = "per2Value";
            this.per2Value.Size = new System.Drawing.Size(15, 15);
            this.per2Value.TabIndex = 17;
            this.per2Value.Text = "0";
            // 
            // ThRValue
            // 
            this.ThRValue.AutoSize = true;
            this.ThRValue.Location = new System.Drawing.Point(9, 387);
            this.ThRValue.Name = "ThRValue";
            this.ThRValue.Size = new System.Drawing.Size(15, 15);
            this.ThRValue.TabIndex = 16;
            this.ThRValue.Text = "0";
            // 
            // Th2Value
            // 
            this.Th2Value.AutoSize = true;
            this.Th2Value.Location = new System.Drawing.Point(9, 443);
            this.Th2Value.Name = "Th2Value";
            this.Th2Value.Size = new System.Drawing.Size(15, 15);
            this.Th2Value.TabIndex = 15;
            this.Th2Value.Text = "0";
            // 
            // nValue
            // 
            this.nValue.AutoSize = true;
            this.nValue.Location = new System.Drawing.Point(9, 163);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(15, 15);
            this.nValue.TabIndex = 14;
            this.nValue.Text = "0";
            // 
            // trbLeng
            // 
            this.trbLeng.Location = new System.Drawing.Point(68, 219);
            this.trbLeng.Maximum = 300;
            this.trbLeng.Name = "trbLeng";
            this.trbLeng.Size = new System.Drawing.Size(144, 56);
            this.trbLeng.TabIndex = 13;
            this.trbLeng.Scroll += new System.EventHandler(this.trbLeng_Scroll);
            // 
            // trbPer1
            // 
            this.trbPer1.Location = new System.Drawing.Point(68, 275);
            this.trbPer1.Maximum = 100;
            this.trbPer1.Name = "trbPer1";
            this.trbPer1.Size = new System.Drawing.Size(144, 56);
            this.trbPer1.TabIndex = 12;
            this.trbPer1.Scroll += new System.EventHandler(this.trbPer1_Scroll);
            // 
            // trbPer2
            // 
            this.trbPer2.Location = new System.Drawing.Point(68, 331);
            this.trbPer2.Maximum = 100;
            this.trbPer2.Name = "trbPer2";
            this.trbPer2.Size = new System.Drawing.Size(144, 56);
            this.trbPer2.TabIndex = 11;
            this.trbPer2.Scroll += new System.EventHandler(this.trbPer2_Scroll);
            // 
            // trbTh1
            // 
            this.trbTh1.Location = new System.Drawing.Point(68, 387);
            this.trbTh1.Maximum = 180;
            this.trbTh1.Name = "trbTh1";
            this.trbTh1.Size = new System.Drawing.Size(144, 56);
            this.trbTh1.TabIndex = 10;
            this.trbTh1.Scroll += new System.EventHandler(this.trbTh1_Scroll);
            // 
            // trbTh2
            // 
            this.trbTh2.Location = new System.Drawing.Point(68, 443);
            this.trbTh2.Maximum = 180;
            this.trbTh2.Name = "trbTh2";
            this.trbTh2.Size = new System.Drawing.Size(144, 56);
            this.trbTh2.TabIndex = 9;
            this.trbTh2.Scroll += new System.EventHandler(this.trbTh2_Scroll);
            // 
            // drawPanel1
            // 
            this.drawPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel1.AutoScroll = true;
            this.drawPanel1.AutoSize = true;
            this.drawPanel1.BackColor = System.Drawing.Color.White;
            this.drawPanel1.Location = new System.Drawing.Point(6, 11);
            this.drawPanel1.Name = "drawPanel1";
            this.drawPanel1.Size = new System.Drawing.Size(419, 494);
            this.drawPanel1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.drawPanel1);
            this.groupBox3.Location = new System.Drawing.Point(357, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 511);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trb_nValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nDepth;
        private System.Windows.Forms.Label ThR;
        private System.Windows.Forms.Label per2L;
        private System.Windows.Forms.Label per1R;
        private System.Windows.Forms.Label leng;
        private System.Windows.Forms.Label ThL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trb_nValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trbLeng;
        private System.Windows.Forms.TrackBar trbPer1;
        private System.Windows.Forms.TrackBar trbPer2;
        private System.Windows.Forms.TrackBar trbTh1;
        private System.Windows.Forms.Label lengValue;
        private System.Windows.Forms.Label per1Value;
        private System.Windows.Forms.Label per2Value;
        private System.Windows.Forms.Label ThRValue;
        private System.Windows.Forms.Label Th2Value;
        private System.Windows.Forms.Label nValue;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TrackBar trbTh2;
        private System.Windows.Forms.Panel drawPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

