using FormControlManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControl
{
    public partial class Test : Form
    {
        private System.Timers.Timer timer;
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rate = Convert.ToDouble(RunRate.Text.ToString());
            timer = new System.Timers.Timer(rate);
            timer.Elapsed+= new System.Timers.ElapsedEventHandler(Run);
            timer.Enabled = true;
            timer.AutoReset = true;
        }

        void Run(object sender, System.Timers.ElapsedEventArgs e)
        {
            string formName = this.FormName.Text;
            string buttonTxt = ButtonTxt.Text;
            if(string.IsNullOrEmpty(formName) || string.IsNullOrEmpty(buttonTxt))
            {
                MessageBox.Show("目标窗口或按钮名不能为空！");
                return;
            }
            ControlManager manager = new ControlManager();
            string result = manager.BtnClickEvent(formName, buttonTxt);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
