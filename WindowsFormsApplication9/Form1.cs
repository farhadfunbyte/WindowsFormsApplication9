using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Test
            label1.Visible = true;
            button1.Enabled = false;

            string result = await Task.Run(() => Fucn1());

            button1.Enabled = true;
            label1.Visible = false;

            MessageBox.Show(result);
        }

        private string Fucn1()
        {

            for (int i = 10; i < 1000000000; i++)
            {
                var a = Math.Sqrt(i);
            }

            return "Done";
        }

    }
}
