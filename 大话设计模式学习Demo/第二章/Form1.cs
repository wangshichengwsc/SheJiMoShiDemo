using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price=Convert.ToDouble(this.textBox1.Text) ;
            double number = Convert.ToInt32(this.textBox2.Text);
            string type = comboBox1.Text;
            StrategyContext con = new StrategyContext(type);
            double result = con.jisuan(price*number);
            listBox1.Items.Add(result);
        }
    }
}
