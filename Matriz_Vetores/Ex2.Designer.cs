namespace Matriz_Vetores
{
    partial class Ex2
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
            btnvoltar = new Button();
            btnLimpar = new Button();
            txtapresentarB = new TextBox();
            txtapresentarA = new TextBox();
            btnadicionar = new Button();
            btnapresentar = new Button();
            txtA = new TextBox();
            lblA = new Label();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Segoe UI", 16F);
            btnvoltar.Location = new Point(799, 486);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(234, 51);
            btnvoltar.TabIndex = 15;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16F);
            btnLimpar.Location = new Point(374, 486);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(234, 51);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // txtapresentarB
            // 
            txtapresentarB.Enabled = false;
            txtapresentarB.Font = new Font("Segoe UI", 15F);
            txtapresentarB.Location = new Point(425, 321);
            txtapresentarB.Multiline = true;
            txtapresentarB.Name = "txtapresentarB";
            txtapresentarB.Size = new Size(543, 46);
            txtapresentarB.TabIndex = 13;
            txtapresentarB.Visible = false;
            // 
            // txtapresentarA
            // 
            txtapresentarA.Enabled = false;
            txtapresentarA.Font = new Font("Segoe UI", 15F);
            txtapresentarA.Location = new Point(425, 249);
            txtapresentarA.Multiline = true;
            txtapresentarA.Name = "txtapresentarA";
            txtapresentarA.Size = new Size(543, 46);
            txtapresentarA.TabIndex = 12;
            txtapresentarA.Visible = false;
            // 
            // btnadicionar
            // 
            btnadicionar.Font = new Font("Segoe UI", 14F);
            btnadicionar.Location = new Point(615, 112);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(174, 38);
            btnadicionar.TabIndex = 11;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // btnapresentar
            // 
            btnapresentar.Font = new Font("Segoe UI", 14F);
            btnapresentar.Location = new Point(549, 176);
            btnapresentar.Name = "btnapresentar";
            btnapresentar.Size = new Size(307, 38);
            btnapresentar.TabIndex = 10;
            btnapresentar.Text = "Apresentar Vetores:";
            btnapresentar.UseVisualStyleBackColor = true;
            btnapresentar.Click += btnapresentar_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 15F);
            txtA.Location = new Point(720, 62);
            txtA.Name = "txtA";
            txtA.Size = new Size(223, 34);
            txtA.TabIndex = 9;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 15F);
            lblA.Location = new Point(445, 65);
            lblA.Name = "lblA";
            lblA.Size = new Size(247, 28);
            lblA.TabIndex = 8;
            lblA.Text = "Digite 10 valores positivos:";
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 611);
            Controls.Add(btnvoltar);
            Controls.Add(btnLimpar);
            Controls.Add(txtapresentarB);
            Controls.Add(txtapresentarA);
            Controls.Add(btnadicionar);
            Controls.Add(btnapresentar);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Ex2";
            Text = "Ex2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvoltar;
        private Button btnLimpar;
        private TextBox txtapresentarB;
        private TextBox txtapresentarA;
        private Button btnadicionar;
        private Button btnapresentar;
        private TextBox txtA;
        private Label lblA;
    }
}