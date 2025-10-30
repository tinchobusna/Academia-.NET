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
            cursoLabel.Location = new Point(12, 27);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new Size(46, 20);
            cursoLabel.TabIndex = 11;
            cursoLabel.Text = "Curso";
            // 
            // buttonPonerNota
            // 
            buttonPonerNota.Location = new Point(12, 408);
            buttonPonerNota.Margin = new Padding(3, 4, 3, 4);
            buttonPonerNota.Name = "buttonPonerNota";
            buttonPonerNota.Size = new Size(131, 31);
            buttonPonerNota.TabIndex = 10;
            buttonPonerNota.Text = "Poner Nota";
            buttonPonerNota.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(12, 67);
            dataGridViewAlumnos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersWidth = 51;
            dataGridViewAlumnos.Size = new Size(705, 333);
            dataGridViewAlumnos.TabIndex = 9;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(314, 24);
            buttonFiltrar.Margin = new Padding(3, 4, 3, 4);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(83, 28);
            buttonFiltrar.TabIndex = 8;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(64, 24);
            comboBoxCursos.Margin = new Padding(3, 4, 3, 4);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(244, 28);
            comboBoxCursos.TabIndex = 7;
            // 
            // PonerNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cursoLabel);
            Controls.Add(buttonPonerNota);
            Controls.Add(dataGridViewAlumnos);
            Controls.Add(buttonFiltrar);
            Controls.Add(comboBoxCursos);
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