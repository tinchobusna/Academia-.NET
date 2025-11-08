namespace WindowsForms
{
    partial class PonerNotas
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
            cursoLabel = new Label();
            buttonPonerNota = new Button();
            dataGridViewAlumnos = new DataGridView();
            buttonFiltrar = new Button();
            comboBoxCursos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new Point(10, 20);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new Size(38, 15);
            cursoLabel.TabIndex = 11;
            cursoLabel.Text = "Curso";
            // 
            // buttonPonerNota
            // 
            buttonPonerNota.Location = new Point(512, 16);
            buttonPonerNota.Name = "buttonPonerNota";
            buttonPonerNota.Size = new Size(115, 23);
            buttonPonerNota.TabIndex = 10;
            buttonPonerNota.Text = "Poner Nota";
            buttonPonerNota.UseVisualStyleBackColor = true;
            buttonPonerNota.Click += buttonPonerNota_Click;
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(10, 50);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersWidth = 51;
            dataGridViewAlumnos.Size = new Size(617, 250);
            dataGridViewAlumnos.TabIndex = 9;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(275, 18);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(73, 21);
            buttonFiltrar.TabIndex = 8;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(56, 18);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(214, 23);
            comboBoxCursos.TabIndex = 7;
            // 
            // PonerNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 314);
            Controls.Add(cursoLabel);
            Controls.Add(buttonPonerNota);
            Controls.Add(dataGridViewAlumnos);
            Controls.Add(buttonFiltrar);
            Controls.Add(comboBoxCursos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PonerNotas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cursoLabel;
        private Button buttonPonerNota;
        private DataGridView dataGridViewAlumnos;
        private Button buttonFiltrar;
        private ComboBox comboBoxCursos;
    }
}