namespace Matriz_Vetores
{
    partial class Ex3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnadicionar = new Button();
            txtA = new TextBox();
            lblA = new Label();
            btnvoltar = new Button();
            btnLimpar = new Button();
            lblsearch = new Label();
            txtsearch = new TextBox();
            lblinstrucao = new Label();
            lblnum = new Label();
            label1 = new Label();
            txtnum = new TextBox();
            txtcubo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnsearch = new Button();
            SuspendLayout();
            // 
            // btnadicionar
            // 
            btnadicionar.Font = new Font("Segoe UI", 17F);
            btnadicionar.Location = new Point(645, 100);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(174, 45);
            btnadicionar.TabIndex = 6;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 16F);
            txtA.Location = new Point(601, 58);
            txtA.Name = "txtA";
            txtA.Size = new Size(267, 36);
            txtA.TabIndex = 5;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 17F);
            lblA.Location = new Point(557, 24);
            lblA.Name = "lblA";
            lblA.Size = new Size(339, 31);
            lblA.TabIndex = 4;
            lblA.Text = "Digite 30 valores de um vetor A:";
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Segoe UI", 16F);
            btnvoltar.Location = new Point(1283, 522);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(153, 51);
            btnvoltar.TabIndex = 17;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16F);
            btnLimpar.Location = new Point(1110, 522);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(153, 51);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Resetar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Font = new Font("Segoe UI", 17F);
            lblsearch.Location = new Point(25, 204);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(331, 31);
            lblsearch.TabIndex = 18;
            lblsearch.Text = "Pesquise o número pelo indice:";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 16F);
            txtsearch.Location = new Point(362, 204);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(108, 36);
            txtsearch.TabIndex = 19;
            // 
            // lblinstrucao
            // 
            lblinstrucao.AutoSize = true;
            lblinstrucao.Font = new Font("Segoe UI", 15F);
            lblinstrucao.Location = new Point(476, 208);
            lblinstrucao.Name = "lblinstrucao";
            lblinstrucao.Size = new Size(75, 28);
            lblinstrucao.TabIndex = 20;
            lblinstrucao.Text = "(1 - 30)";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 16F);
            lblnum.Location = new Point(28, 337);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(98, 30);
            lblnum.TabIndex = 21;
            lblnum.Text = "Número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(37, 384);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 22;
            label1.Text = "Cubo:";
            // 
            // txtnum
            // 
            txtnum.Enabled = false;
            txtnum.Font = new Font("Segoe UI", 14F);
            txtnum.Location = new Point(132, 337);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(108, 32);
            txtnum.TabIndex = 23;
            // 
            // txtcubo
            // 
            txtcubo.Enabled = false;
            txtcubo.Font = new Font("Segoe UI", 14F);
            txtcubo.Location = new Point(132, 384);
            txtcubo.Name = "txtcubo";
            txtcubo.Size = new Size(108, 32);
            txtcubo.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(77, 447);
            button1.Name = "button1";
            button1.Size = new Size(149, 37);
            button1.TabIndex = 25;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1276, 503);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 26;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 15F);
            btnsearch.Location = new Point(103, 248);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(232, 39);
            btnsearch.TabIndex = 27;
            btnsearch.Text = "Pesquisar";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 603);
            Controls.Add(btnsearch);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtcubo);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Controls.Add(lblnum);
            Controls.Add(lblinstrucao);
            Controls.Add(txtsearch);
            Controls.Add(lblsearch);
            Controls.Add(btnvoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnadicionar);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Ex3";
            Text = "Ex3";
            Load += Ex3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadicionar;
        private TextBox txtA;
        private Label lblA;
        private Button btnvoltar;
        private Button btnLimpar;
        private Label lblsearch;
        private TextBox txtsearch;
        private Label lblinstrucao;
        private Label lblnum;
        private Label label1;
        private TextBox txtnum;
        private TextBox txtcubo;
        private Button button1;
        private Button button2;
        private Button btnsearch;
    }
}