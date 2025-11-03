namespace WindowsForms
{
    partial class InscribirseACurso
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
            buttonInscribirse = new Button();
            dataGridViewCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            SuspendLayout();
            // 
            // buttonInscribirse
            // 
            buttonInscribirse.Location = new Point(527, 12);
            buttonInscribirse.Name = "buttonInscribirse";
            buttonInscribirse.Size = new Size(75, 23);
            buttonInscribirse.TabIndex = 3;
            buttonInscribirse.Text = "Inscribirse";
            buttonInscribirse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Location = new Point(12, 48);
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.RowHeadersWidth = 51;
            dataGridViewCursos.Size = new Size(590, 263);
            dataGridViewCursos.TabIndex = 2;
            // 
            // InscribirseACurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 332);
            Controls.Add(buttonInscribirse);
            Controls.Add(dataGridViewCursos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InscribirseACurso";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInscribirse;
        private DataGridView dataGridViewCursos;
    }
}