namespace WindowsForms
{
    partial class CursoDetalle
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
            idMateriaLabel = new Label();
            idComisionlabel = new Label();
            AnioCalendarioLabel = new Label();
            cupoLabel = new Label();
            idMateriaNumericUpDown = new NumericUpDown();
            idComisionNumericUpDown = new NumericUpDown();
            AnioCalendarioNumericUpDown = new NumericUpDown();
            cupoNumericUpDown = new NumericUpDown();
            cancelarButton = new Button();
            aceptarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)idMateriaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idComisionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnioCalendarioNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupoNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // idMateriaLabel
            // 
            idMateriaLabel.AutoSize = true;
            idMateriaLabel.Location = new Point(34, 39);
            idMateriaLabel.Name = "idMateriaLabel";
            idMateriaLabel.Size = new Size(57, 15);
            idMateriaLabel.TabIndex = 0;
            idMateriaLabel.Text = "idMateria";
            // 
            // idComisionlabel
            // 
            idComisionlabel.AutoSize = true;
            idComisionlabel.Location = new Point(34, 104);
            idComisionlabel.Name = "idComisionlabel";
            idComisionlabel.Size = new Size(68, 15);
            idComisionlabel.TabIndex = 1;
            idComisionlabel.Text = "idComision";
            // 
            // AnioCalendarioLabel
            // 
            AnioCalendarioLabel.AutoSize = true;
            AnioCalendarioLabel.Location = new Point(34, 172);
            AnioCalendarioLabel.Name = "AnioCalendarioLabel";
            AnioCalendarioLabel.Size = new Size(90, 15);
            AnioCalendarioLabel.TabIndex = 2;
            AnioCalendarioLabel.Text = "Anio calendario";
            // 
            // cupoLabel
            // 
            cupoLabel.AutoSize = true;
            cupoLabel.Location = new Point(34, 235);
            cupoLabel.Name = "cupoLabel";
            cupoLabel.Size = new Size(36, 15);
            cupoLabel.TabIndex = 3;
            cupoLabel.Text = "Cupo";
            // 
            // idMateriaNumericUpDown
            // 
            idMateriaNumericUpDown.Location = new Point(141, 37);
            idMateriaNumericUpDown.Name = "idMateriaNumericUpDown";
            idMateriaNumericUpDown.Size = new Size(120, 23);
            idMateriaNumericUpDown.TabIndex = 4;
            // 
            // idComisionNumericUpDown
            // 
            idComisionNumericUpDown.Location = new Point(141, 102);
            idComisionNumericUpDown.Name = "idComisionNumericUpDown";
            idComisionNumericUpDown.Size = new Size(120, 23);
            idComisionNumericUpDown.TabIndex = 5;
            // 
            // AnioCalendarioNumericUpDown
            // 
            AnioCalendarioNumericUpDown.Location = new Point(141, 170);
            AnioCalendarioNumericUpDown.Name = "AnioCalendarioNumericUpDown";
            AnioCalendarioNumericUpDown.Size = new Size(120, 23);
            AnioCalendarioNumericUpDown.TabIndex = 6;
            // 
            // cupoNumericUpDown
            // 
            cupoNumericUpDown.Location = new Point(141, 233);
            cupoNumericUpDown.Name = "cupoNumericUpDown";
            cupoNumericUpDown.Size = new Size(120, 23);
            cupoNumericUpDown.TabIndex = 7;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(327, 290);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 19;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(234, 290);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 18;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // CursoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 325);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(cupoNumericUpDown);
            Controls.Add(AnioCalendarioNumericUpDown);
            Controls.Add(idComisionNumericUpDown);
            Controls.Add(idMateriaNumericUpDown);
            Controls.Add(cupoLabel);
            Controls.Add(AnioCalendarioLabel);
            Controls.Add(idComisionlabel);
            Controls.Add(idMateriaLabel);
            Name = "CursoDetalle";
            Text = "Detalles de Curso";
            ((System.ComponentModel.ISupportInitialize)idMateriaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idComisionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnioCalendarioNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupoNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idMateriaLabel;
        private Label idComisionlabel;
        private Label AnioCalendarioLabel;
        private Label cupoLabel;
        private NumericUpDown idMateriaNumericUpDown;
        private NumericUpDown idComisionNumericUpDown;
        private NumericUpDown AnioCalendarioNumericUpDown;
        private NumericUpDown cupoNumericUpDown;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}