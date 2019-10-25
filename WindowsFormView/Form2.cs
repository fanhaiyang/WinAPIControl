using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void But_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form2【确定】按钮触发");
        }

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form2【取消】按钮触发");
        }

        private void OpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
