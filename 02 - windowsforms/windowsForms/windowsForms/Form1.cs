using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subtitle_Click(object sender, EventArgs e)
        {

        }

        private void txtidade_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcidade_Click(object sender, EventArgs e)
        {
            int idade =(int) Convert.ToInt64(txtidade.Text);
            if(idade >= 18)
            {
                label2.Text = ("Você é maior de idade");
                MessageBox.Show("Você é maior de idade");
            }else
            {
                label2.Text = ("Você e zé Pequeno");
                MessageBox.Show("Você e zé Pequeno");
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
