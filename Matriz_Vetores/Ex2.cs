using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Vetores
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
            i = 0;
        }
        int[] a = new int[10];
        int[] b = new int[10];
        int i, x = 0;

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (i <= 10)
            {
                x = Convert.ToInt32(txtA.Text);
                a[i] = x;
                txtA.Clear();
                txtA.Focus();
                i++;
            }
            if (i >= 10)
            {
                MessageBox.Show("Todos os números foram inseridos!");
                txtA.Enabled = false;
                btnadicionar.Enabled = false;
            }
        }

        private void btnapresentar_Click(object sender, EventArgs e)
        {
            txtapresentarA.Visible = true;
            txtapresentarB.Visible = true;

            for (i = 0; i <= 9; i++)
            {
                b[i] = a[i] * -1;
            }
            for (i = 0; i <= 9; i++)
            {
                txtapresentarA.Text = string.Concat(txtapresentarA.Text, "  ", a[i].ToString());
                txtapresentarB.Text = string.Concat(txtapresentarB.Text, "  ", b[i].ToString());
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            menu.Show();
            this.Hide();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            i = 0;
            btnadicionar.Enabled = true;
            txtA.Enabled = true;
            txtA.Clear();
            txtA.Focus();
            txtapresentarA.Clear();
            txtapresentarB.Clear();
        }
    }
}
