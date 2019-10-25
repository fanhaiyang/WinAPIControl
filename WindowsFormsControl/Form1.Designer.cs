namespace WindowsFormsControl
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
            this.Ok_Btn = new System.Windows.Forms.Button();
            this.Form3Ok_Btn = new System.Windows.Forms.Button();
            this.Form3Cancle_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancle_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ok_Btn
            // 
            this.Ok_Btn.Location = new System.Drawing.Point(114, 45);
            this.Ok_Btn.Name = "Ok_Btn";
            this.Ok_Btn.Size = new System.Drawing.Size(187, 46);
            this.Ok_Btn.TabIndex = 0;
            this.Ok_Btn.Text = "触发Form2【确定】事件";
            this.Ok_Btn.UseVisualStyleBackColor = true;
            this.Ok_Btn.Click += new System.EventHandler(this.Ok_Btn_Click);
            // 
            // Form3Ok_Btn
            // 
            this.Form3Ok_Btn.Location = new System.Drawing.Point(114, 148);
            this.Form3Ok_Btn.Name = "Form3Ok_Btn";
            this.Form3Ok_Btn.Size = new System.Drawing.Size(187, 43);
            this.Form3Ok_Btn.TabIndex = 2;
            this.Form3Ok_Btn.Text = "触发Form3【确定】事件";
            this.Form3Ok_Btn.UseVisualStyleBackColor = true;
            this.Form3Ok_Btn.Click += new System.EventHandler(this.Form3Ok_Btn_Click);
            // 
            // Form3Cancle_Btn
            // 
            this.Form3Cancle_Btn.Location = new System.Drawing.Point(356, 148);
            this.Form3Cancle_Btn.Name = "Form3Cancle_Btn";
            this.Form3Cancle_Btn.Size = new System.Drawing.Size(187, 43);
            this.Form3Cancle_Btn.TabIndex = 3;
            this.Form3Cancle_Btn.Text = "触发Form3【取消】事件";
            this.Form3Cancle_Btn.UseVisualStyleBackColor = true;
            this.Form3Cancle_Btn.Click += new System.EventHandler(this.Form3Cancle_Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "接口测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormName
            // 
            this.FormName.Location = new System.Drawing.Point(182, 295);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(158, 21);
            this.FormName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "目标窗口名：";
            // 
            // ButtonTxt
            // 
            this.ButtonTxt.Location = new System.Drawing.Point(460, 295);
            this.ButtonTxt.Name = "ButtonTxt";
            this.ButtonTxt.Size = new System.Drawing.Size(158, 21);
            this.ButtonTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "目标按钮文字：";
            // 
            // Cancle_Btn
            // 
            this.Cancle_Btn.Location = new System.Drawing.Point(356, 45);
            this.Cancle_Btn.Name = "Cancle_Btn";
            this.Cancle_Btn.Size = new System.Drawing.Size(186, 46);
            this.Cancle_Btn.TabIndex = 0;
            this.Cancle_Btn.Text = "触发Form2【取消】事件";
            this.Cancle_Btn.UseVisualStyleBackColor = true;
            this.Cancle_Btn.Click += new System.EventHandler(this.Cancle_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 441);
            this.Controls.Add(this.Cancle_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonTxt);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Form3Cancle_Btn);
            this.Controls.Add(this.Form3Ok_Btn);
            this.Controls.Add(this.Ok_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Ok_Btn;
        private System.Windows.Forms.Button Form3Ok_Btn;
        private System.Windows.Forms.Button Form3Cancle_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FormName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ButtonTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancle_Btn;
    }
}

