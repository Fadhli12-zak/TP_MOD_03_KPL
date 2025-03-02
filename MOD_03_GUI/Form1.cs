using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD_03_GUI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            
            // Tampilkan output di textBoxOutput
            textBoxOutput.Text = $"Selamat datang, {userInput} !";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
