namespace WindowsFormsControl
{
    partial class Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonTxt = new System.Windows.Forms.TextBox();
            this.FormName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RunRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PannelName = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "目标按钮文字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "目标窗口名：";
            // 
            // ButtonTxt
            // 
            this.ButtonTxt.Location = new System.Drawing.Point(98, 127);
            this.ButtonTxt.Name = "ButtonTxt";
            this.ButtonTxt.Size = new System.Drawing.Size(257, 21);
            this.ButtonTxt.TabIndex = 8;
            this.ButtonTxt.Text = "Apply";
            // 
            // FormName
            // 
            this.FormName.Location = new System.Drawing.Point(87, 56);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(268, 21);
            this.FormName.TabIndex = 9;
            this.FormName.Text = "AIRWAY - Navigation/ Airway Maintenance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "执行频率（毫秒/次）";
            // 
            // RunRate
            // 
            this.RunRate.Location = new System.Drawing.Point(134, 22);
            this.RunRate.Name = "RunRate";
            this.RunRate.Size = new System.Drawing.Size(61, 21);
            this.RunRate.TabIndex = 13;
            this.RunRate.Text = "3000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "容器名称：";
            // 
            // PannelName
            // 
            this.PannelName.Location = new System.Drawing.Point(87, 92);
            this.PannelName.Name = "PannelName";
            this.PannelName.Size = new System.Drawing.Size(268, 21);
            this.PannelName.TabIndex = 17;
            this.PannelName.Text = "TUIAPanel";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(214, 182);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(51, 36);
            this.Stop.TabIndex = 18;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 250);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PannelName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RunRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonTxt);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.button1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ButtonTxt;
        private System.Windows.Forms.TextBox FormName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RunRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PannelName;
        private System.Windows.Forms.Button Stop;
    }
}