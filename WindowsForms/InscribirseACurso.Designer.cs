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
            buttonInscribirse.Location = new Point(300, 372);
            buttonInscribirse.Margin = new Padding(3, 4, 3, 4);
            buttonInscribirse.Name = "buttonInscribirse";
            buttonInscribirse.Size = new Size(86, 31);
            buttonInscribirse.TabIndex = 3;
            buttonInscribirse.Text = "Inscribirse";
            buttonInscribirse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Location = new Point(12, 13);
            dataGridViewCursos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.RowHeadersWidth = 51;
            dataGridViewCursos.Size = new Size(674, 351);
            dataGridViewCursos.TabIndex = 2;
            // 
            // InscribirseACurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 422);
            Controls.Add(buttonInscribirse);
            Controls.Add(dataGridViewCursos);
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