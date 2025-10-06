namespace WindowsForms
{
    partial class PaginaMain
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
            mnsListas = new MenuStrip();
            listasToolStripMenuItem = new ToolStripMenuItem();
            mnuUsuarios = new ToolStripMenuItem();
            mnuCursos = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            mnsListas.SuspendLayout();
            SuspendLayout();
            // 
            // mnsListas
            // 
            mnsListas.Items.AddRange(new ToolStripItem[] { listasToolStripMenuItem });
            mnsListas.Location = new Point(0, 0);
            mnsListas.Name = "mnsListas";
            mnsListas.Size = new Size(800, 24);
            mnsListas.TabIndex = 0;
            mnsListas.Text = "menuStrip1";
            // 
            // listasToolStripMenuItem
            // 
            listasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuarios, mnuCursos, mnuSalir });
            listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            listasToolStripMenuItem.Size = new Size(48, 20);
            listasToolStripMenuItem.Text = "Listas";
            listasToolStripMenuItem.Click += listasToolStripMenuItem_Click;
            // 
            // mnuUsuarios
            // 
            mnuUsuarios.Name = "mnuUsuarios";
            mnuUsuarios.Size = new Size(119, 22);
            mnuUsuarios.Text = "Usuarios";
            mnuUsuarios.Click += mnuUsuarios_Click;
            // 
            // mnuCursos
            // 
            mnuCursos.Name = "mnuCursos";
            mnuCursos.Size = new Size(119, 22);
            mnuCursos.Text = "Cursos";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(119, 22);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // PaginaMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnsListas);
            IsMdiContainer = true;
            Name = "PaginaMain";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            Shown += PaginaMain_Shown;
            mnsListas.ResumeLayout(false);
            mnsListas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsListas;
        private ToolStripMenuItem listasToolStripMenuItem;
        private ToolStripMenuItem mnuUsuarios;
        private ToolStripMenuItem mnuCursos;
        private ToolStripMenuItem mnuSalir;
    }
}
