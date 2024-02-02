namespace TongXunRuanJian_KeHU
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
            this.txtDK = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btn_QD = new System.Windows.Forms.Button();
            this.Xiaoxi = new System.Windows.Forms.Label();
            this.HaoYoulist = new System.Windows.Forms.ListBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.btn_Fs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDK
            // 
            this.txtDK.Location = new System.Drawing.Point(373, 35);
            this.txtDK.Margin = new System.Windows.Forms.Padding(4);
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(118, 25);
            this.txtDK.TabIndex = 6;
            this.txtDK.Text = "10086";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(107, 35);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(213, 25);
            this.txtIP.TabIndex = 7;
            this.txtIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "端口";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 39);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 15);
            this.label.TabIndex = 5;
            this.label.Text = "IPV4";
            // 
            // btn_QD
            // 
            this.btn_QD.Location = new System.Drawing.Point(831, 35);
            this.btn_QD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QD.Name = "btn_QD";
            this.btn_QD.Size = new System.Drawing.Size(156, 29);
            this.btn_QD.TabIndex = 3;
            this.btn_QD.Text = "建立连接";
            this.btn_QD.UseVisualStyleBackColor = true;
            this.btn_QD.Click += new System.EventHandler(this.btn_QD_Click);
            // 
            // Xiaoxi
            // 
            this.Xiaoxi.AutoSize = true;
            this.Xiaoxi.ForeColor = System.Drawing.Color.Red;
            this.Xiaoxi.Location = new System.Drawing.Point(16, 536);
            this.Xiaoxi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xiaoxi.Name = "Xiaoxi";
            this.Xiaoxi.Size = new System.Drawing.Size(97, 15);
            this.Xiaoxi.TabIndex = 8;
            this.Xiaoxi.Text = "自动消息提示";
            // 
            // HaoYoulist
            // 
            this.HaoYoulist.FormattingEnabled = true;
            this.HaoYoulist.ItemHeight = 15;
            this.HaoYoulist.Location = new System.Drawing.Point(63, 89);
            this.HaoYoulist.Margin = new System.Windows.Forms.Padding(4);
            this.HaoYoulist.Name = "HaoYoulist";
            this.HaoYoulist.Size = new System.Drawing.Size(257, 349);
            this.HaoYoulist.TabIndex = 9;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(329, 89);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(656, 349);
            this.txtMsg.TabIndex = 10;
            // 
            // txtFS
            // 
            this.txtFS.Location = new System.Drawing.Point(63, 465);
            this.txtFS.Margin = new System.Windows.Forms.Padding(4);
            this.txtFS.Name = "txtFS";
            this.txtFS.Size = new System.Drawing.Size(707, 25);
            this.txtFS.TabIndex = 11;
            // 
            // btn_Fs
            // 
            this.btn_Fs.Location = new System.Drawing.Point(831, 462);
            this.btn_Fs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fs.Name = "btn_Fs";
            this.btn_Fs.Size = new System.Drawing.Size(156, 29);
            this.btn_Fs.TabIndex = 3;
            this.btn_Fs.Text = "确认";
            this.btn_Fs.UseVisualStyleBackColor = true;
            this.btn_Fs.Click += new System.EventHandler(this.btn_Fs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "昵称";
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(565, 35);
            this.txtNC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(232, 25);
            this.txtNC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txtFS);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.HaoYoulist);
            this.Controls.Add(this.Xiaoxi);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.txtDK);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_Fs);
            this.Controls.Add(this.btn_QD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDK;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_QD;
        private System.Windows.Forms.Label Xiaoxi;
        private System.Windows.Forms.ListBox HaoYoulist;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.Button btn_Fs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNC;
    }
}

