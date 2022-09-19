using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_calculator
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();


            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;



        }

        private void button14_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;
            var result = new DataTable().Compute(equation, null);
            textBox1.Text = result.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
