namespace Matriz_Vetores
{
    partial class Frmmenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ex1ToolStripMenuItem = new ToolStripMenuItem();
            ex2ToolStripMenuItem = new ToolStripMenuItem();
            ex3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ex1ToolStripMenuItem, ex2ToolStripMenuItem, ex3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1326, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ex1ToolStripMenuItem
            // 
            ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            ex1ToolStripMenuItem.Size = new Size(36, 20);
            ex1ToolStripMenuItem.Text = "Ex1";
            ex1ToolStripMenuItem.Click += ex1ToolStripMenuItem_Click;
            // 
            // ex2ToolStripMenuItem
            // 
            ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            ex2ToolStripMenuItem.Size = new Size(36, 20);
            ex2ToolStripMenuItem.Text = "Ex2";
            ex2ToolStripMenuItem.Click += ex2ToolStripMenuItem_Click;
            // 
            // ex3ToolStripMenuItem
            // 
            ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            ex3ToolStripMenuItem.Size = new Size(36, 20);
            ex3ToolStripMenuItem.Text = "Ex3";
            // 
            // Frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 556);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Frmmenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ex1ToolStripMenuItem;
        private ToolStripMenuItem ex2ToolStripMenuItem;
        private ToolStripMenuItem ex3ToolStripMenuItem;
    }
}
