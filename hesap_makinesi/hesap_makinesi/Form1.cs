using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(number1.Text);
            int b = Convert.ToInt32(number2.Text);
            string myOperation = operations.Text;
            if (myOperation == "" + "") reslt_listBox.Items.Add(a + b);
            else if (myOperation == "-") reslt_listBox.Items.Add(a - b);
            else if (myOperation == "*") reslt_listBox.Items.Add(a * b);
            else if (myOperation == "/") reslt_listBox.Items.Add(a / b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}