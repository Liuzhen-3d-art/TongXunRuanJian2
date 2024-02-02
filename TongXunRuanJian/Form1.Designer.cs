namespace TongXunRuanJian
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
            this.btn_QD = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDK = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Xiaoxi = new System.Windows.Forms.Label();
            this.txtTx = new System.Windows.Forms.TextBox();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.Btn_FS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QD
            // 
            this.btn_QD.Location = new System.Drawing.Point(828, 46);
            this.btn_QD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QD.Name = "btn_QD";
            this.btn_QD.Size = new System.Drawing.Size(156, 29);
            this.btn_QD.TabIndex = 0;
            this.btn_QD.Text = "启动服务器";
            this.btn_QD.UseVisualStyleBackColor = true;
            this.btn_QD.Click += new System.EventHandler(this.btn_QD_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(57, 50);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 15);
            this.label.TabIndex = 1;
            this.label.Text = "IPV4";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(104, 46);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(213, 25);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            // 
            // txtDK
            // 
            this.txtDK.Location = new System.Drawing.Point(497, 46);
            this.txtDK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(213, 25);
            this.txtDK.TabIndex = 2;
            this.txtDK.Text = "10086";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(74, 130);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 394);
            this.listBox1.TabIndex = 3;
            // 
            // Xiaoxi
            // 
            this.Xiaoxi.AutoSize = true;
            this.Xiaoxi.ForeColor = System.Drawing.Color.Red;
            this.Xiaoxi.Location = new System.Drawing.Point(71, 91);
            this.Xiaoxi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xiaoxi.Name = "Xiaoxi";
            this.Xiaoxi.Size = new System.Drawing.Size(97, 15);
            this.Xiaoxi.TabIndex = 4;
            this.Xiaoxi.Text = "自动消息提示";
            // 
            // txtTx
            // 
            this.txtTx.Location = new System.Drawing.Point(344, 130);
            this.txtTx.Multiline = true;
            this.txtTx.Name = "txtTx";
            this.txtTx.Size = new System.Drawing.Size(640, 311);
            this.txtTx.TabIndex = 5;
            // 
            // txtFS
            // 
            this.txtFS.Location = new System.Drawing.Point(344, 485);
            this.txtFS.Name = "txtFS";
            this.txtFS.Size = new System.Drawing.Size(428, 25);
            this.txtFS.TabIndex = 6;
            // 
            // Btn_FS
            // 
            this.Btn_FS.Location = new System.Drawing.Point(828, 480);
            this.Btn_FS.Name = "Btn_FS";
            this.Btn_FS.Size = new System.Drawing.Size(156, 30);
            this.Btn_FS.TabIndex = 7;
            this.Btn_FS.Text = "发送";
            this.Btn_FS.UseVisualStyleBackColor = true;
            this.Btn_FS.Click += new System.EventHandler(this.Btn_FS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.Btn_FS);
            this.Controls.Add(this.txtFS);
            this.Controls.Add(this.txtTx);
            this.Controls.Add(this.Xiaoxi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDK);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_QD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QD;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDK;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Xiaoxi;
        private System.Windows.Forms.TextBox txtTx;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.Button Btn_FS;
    }
}

