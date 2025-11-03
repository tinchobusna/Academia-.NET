namespace WindowsForms
{
    partial class MenuPrincipal
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
            menuStrip1 = new MenuStrip();
            listasToolStripMenuItem = new ToolStripMenuItem();
            cursoToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            comisionToolStripMenuItem = new ToolStripMenuItem();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            planToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            funcionaliadprofesoresToolStripMenuItem = new ToolStripMenuItem();
            ponerNotasToolStripMenuItem = new ToolStripMenuItem();
            funcionalidadAlumnosToolStripMenuItem = new ToolStripMenuItem();
            inscribirseACursoToolStripMenuItem = new ToolStripMenuItem();
            verNotasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listasToolStripMenuItem, funcionaliadprofesoresToolStripMenuItem, funcionalidadAlumnosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // listasToolStripMenuItem
            // 
            listasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cursoToolStripMenuItem, usuarioToolStripMenuItem, comisionToolStripMenuItem, materiaToolStripMenuItem, planToolStripMenuItem, personasToolStripMenuItem, especialidadesToolStripMenuItem, reportesToolStripMenuItem });
            listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            listasToolStripMenuItem.Size = new Size(48, 20);
            listasToolStripMenuItem.Text = "Listas";
            // 
            // cursoToolStripMenuItem
            // 
            cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            cursoToolStripMenuItem.Size = new Size(150, 22);
            cursoToolStripMenuItem.Text = "Cursos";
            cursoToolStripMenuItem.Click += cursoToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(150, 22);
            usuarioToolStripMenuItem.Text = "Usuarios";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // comisionToolStripMenuItem
            // 
            comisionToolStripMenuItem.Name = "comisionToolStripMenuItem";
            comisionToolStripMenuItem.Size = new Size(150, 22);
            comisionToolStripMenuItem.Text = "Comisiones";
            comisionToolStripMenuItem.Click += comisionToolStripMenuItem_Click;
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(150, 22);
            materiaToolStripMenuItem.Text = "Materias";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
            // 
            // planToolStripMenuItem
            // 
            planToolStripMenuItem.Name = "planToolStripMenuItem";
            planToolStripMenuItem.Size = new Size(150, 22);
            planToolStripMenuItem.Text = "Planes";
            planToolStripMenuItem.Click += planToolStripMenuItem_Click;
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(150, 22);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(150, 22);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(150, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // funcionaliadprofesoresToolStripMenuItem
            // 
            funcionaliadprofesoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ponerNotasToolStripMenuItem });
            funcionaliadprofesoresToolStripMenuItem.Name = "funcionaliadprofesoresToolStripMenuItem";
            funcionaliadprofesoresToolStripMenuItem.Size = new Size(152, 20);
            funcionaliadprofesoresToolStripMenuItem.Text = "Funcionalidad profesores";
            // 
            // ponerNotasToolStripMenuItem
            // 
            ponerNotasToolStripMenuItem.Name = "ponerNotasToolStripMenuItem";
            ponerNotasToolStripMenuItem.Size = new Size(180, 22);
            ponerNotasToolStripMenuItem.Text = "Poner notas";
            ponerNotasToolStripMenuItem.Click += ponerNotasToolStripMenuItem_Click;
            // 
            // funcionalidadAlumnosToolStripMenuItem
            // 
            funcionalidadAlumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscribirseACursoToolStripMenuItem, verNotasToolStripMenuItem });
            funcionalidadAlumnosToolStripMenuItem.Name = "funcionalidadAlumnosToolStripMenuItem";
            funcionalidadAlumnosToolStripMenuItem.Size = new Size(143, 20);
            funcionalidadAlumnosToolStripMenuItem.Text = "Funcionalidad alumnos";
            // 
            // inscribirseACursoToolStripMenuItem
            // 
            inscribirseACursoToolStripMenuItem.Name = "inscribirseACursoToolStripMenuItem";
            inscribirseACursoToolStripMenuItem.Size = new Size(180, 22);
            inscribirseACursoToolStripMenuItem.Text = "Inscribirse a curso";
            inscribirseACursoToolStripMenuItem.Click += inscribirseACursoToolStripMenuItem_Click;
            // 
            // verNotasToolStripMenuItem
            // 
            verNotasToolStripMenuItem.Name = "verNotasToolStripMenuItem";
            verNotasToolStripMenuItem.Size = new Size(180, 22);
            verNotasToolStripMenuItem.Text = "Ver notas";
            verNotasToolStripMenuItem.Click += verNotasToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Academia";
            Load += Menu_load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listasToolStripMenuItem;
        private ToolStripMenuItem cursoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem comisionToolStripMenuItem;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem planToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem funcionaliadprofesoresToolStripMenuItem;
        private ToolStripMenuItem ponerNotasToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem funcionalidadAlumnosToolStripMenuItem;
        private ToolStripMenuItem inscribirseACursoToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem verNotasToolStripMenuItem;
    }
}