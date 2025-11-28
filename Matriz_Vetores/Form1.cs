namespace Matriz_Vetores
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.Show();
            this.Hide();

        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.Show();
            this.Hide();
        }
    }
}
