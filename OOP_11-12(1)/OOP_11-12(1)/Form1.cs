using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_11_12_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ОТЛИЧНО!!!") button1.Text = "УЗНАТЬ ОТВЕТ";
            else button1.Text = "ОТЛИЧНО!!!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
