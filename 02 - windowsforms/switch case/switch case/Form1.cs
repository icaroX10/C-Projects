using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
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

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes = cbMes.Text;
            int nMes = cbMes.SelectedIndex;
            txtmes.Text = (string) Convert.ToString(nMes);

            switch (nMes)
            {
                case 0:
                    txtmes.Text = cbMes.Text;
                    break;
                case 1:
                    txtmes.Text = cbMes.Text;
                    break;
                case 2:
                    txtmes.Text = cbMes.Text;
                    break;
                case 3:
                    txtmes.Text = cbMes.Text;
                    break;
                case 4:
                    txtmes.Text = cbMes.Text;
                    break;
                case 5:
                    txtmes.Text = cbMes.Text;
                    break;
                case 6:
                    txtmes.Text = cbMes.Text;
                    break;
                case 7:
                    txtmes.Text = cbMes.Text;
                    break;
                case 8:
                    txtmes.Text = cbMes.Text;
                    break;
                case 9:
                    txtmes.Text = cbMes.Text;
                    break;
                case 10:
                    txtmes.Text = cbMes.Text;
                    break;
                case 11:
                    txtmes.Text = cbMes.Text;
                    break;
                default:
                    txtmes.Text = "Não selecionou nda";
                    break;

            }
        }
    }
}
