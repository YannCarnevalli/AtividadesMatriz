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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
            i = 0;
        }
        int[] a = new int[30];
        int[] b = new int[30];
        int i, x = 0;
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (i <= 30)
            {
                x = Convert.ToInt32(txtA.Text);
                a[i] = x;
                b[i] = x * x * x;
                txtA.Clear();
                txtA.Focus();
                i++;
            }
            if (i >= 30)
            {
                MessageBox.Show("Todos os números foram inseridos!");
                txtA.Enabled = false;
                btnadicionar.Enabled = false;
            }
        }

        private void Ex3_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            i = 0;
            btnadicionar.Enabled = true;
            txtA.Enabled = true;
            txtA.Clear();
            txtA.Focus();
            txtsearch.Clear();
            txtnum.Clear();
            txtcubo.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(txtsearch.Text);
            search = search - 1;

            if (search <= 30 && search > -1)
            {
                txtnum.Text = a[search].ToString();
                txtcubo.Text = b[search].ToString();
            }
            else if (search > 30)
            {
                MessageBox.Show("Número inválido");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            txtsearch.Focus();
            txtnum.Clear();
            txtcubo.Clear();
        }
    }
}
