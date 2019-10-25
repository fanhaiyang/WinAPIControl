namespace WindowsFormView
{
    partial class Form2
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
            this.But_OK = new System.Windows.Forms.Button();
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.OpenForm3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // But_OK
            // 
            this.But_OK.Location = new System.Drawing.Point(54, 54);
            this.But_OK.Name = "But_OK";
            this.But_OK.Size = new System.Drawing.Size(86, 29);
            this.But_OK.TabIndex = 0;
            this.But_OK.Text = "确定";
            this.But_OK.UseVisualStyleBackColor = true;
            this.But_OK.Click += new System.EventHandler(this.But_OK_Click);
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(19, 20);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(86, 29);
            this.Btn_Cancle.TabIndex = 1;
            this.Btn_Cancle.Text = "取消";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // OpenForm3
            // 
            this.OpenForm3.Location = new System.Drawing.Point(54, 133);
            this.OpenForm3.Name = "OpenForm3";
            this.OpenForm3.Size = new System.Drawing.Size(86, 30);
            this.OpenForm3.TabIndex = 2;
            this.OpenForm3.Text = "打开Form3";
            this.OpenForm3.UseVisualStyleBackColor = true;
            this.OpenForm3.Click += new System.EventHandler(this.OpenForm3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Cancle);
            this.groupBox1.Location = new System.Drawing.Point(163, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenForm3);
            this.Controls.Add(this.But_OK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_OK;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.Button OpenForm3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

