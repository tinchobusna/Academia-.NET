namespace WindowsForms
{
    partial class MateriaDetalle
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
            planDropDown = new ComboBox();
            DescripcionRichTextBox = new RichTextBox();
            HorasSemanalesLabel = new Label();
            horasSemanalesNumericUpDown = new NumericUpDown();
            horasTotalesLabel = new Label();
            horasTotalesNumericUpDown = new NumericUpDown();
            descripcionLabel = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            planLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)horasSemanalesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horasTotalesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // planDropDown
            // 
            planDropDown.FormattingEnabled = true;
            planDropDown.Location = new Point(124, 25);
            planDropDown.Name = "planDropDown";
            planDropDown.Size = new Size(210, 23);
            planDropDown.TabIndex = 32;
            // 
            // DescripcionRichTextBox
            // 
            DescripcionRichTextBox.Location = new Point(124, 148);
            DescripcionRichTextBox.Name = "DescripcionRichTextBox";
            DescripcionRichTextBox.Size = new Size(210, 106);
            DescripcionRichTextBox.TabIndex = 31;
            DescripcionRichTextBox.Text = "";
            // 
            // HorasSemanalesLabel
            // 
            HorasSemanalesLabel.AutoSize = true;
            HorasSemanalesLabel.Location = new Point(14, 66);
            HorasSemanalesLabel.Margin = new Padding(2, 0, 2, 0);
            HorasSemanalesLabel.Name = "HorasSemanalesLabel";
            HorasSemanalesLabel.Size = new Size(96, 15);
            HorasSemanalesLabel.TabIndex = 30;
            HorasSemanalesLabel.Text = "Horas semanales";
            // 
            // horasSemanalesNumericUpDown
            // 
            horasSemanalesNumericUpDown.Location = new Point(124, 65);
            horasSemanalesNumericUpDown.Margin = new Padding(2);
            horasSemanalesNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            horasSemanalesNumericUpDown.Name = "horasSemanalesNumericUpDown";
            horasSemanalesNumericUpDown.Size = new Size(210, 23);
            horasSemanalesNumericUpDown.TabIndex = 23;
            horasSemanalesNumericUpDown.TabStop = false;
            // 
            // horasTotalesLabel
            // 
            horasTotalesLabel.AutoSize = true;
            horasTotalesLabel.Location = new Point(14, 109);
            horasTotalesLabel.Margin = new Padding(2, 0, 2, 0);
            horasTotalesLabel.Name = "horasTotalesLabel";
            horasTotalesLabel.Size = new Size(76, 15);
            horasTotalesLabel.TabIndex = 29;
            horasTotalesLabel.Text = "Horas totales";
            // 
            // horasTotalesNumericUpDown
            // 
            horasTotalesNumericUpDown.Location = new Point(124, 107);
            horasTotalesNumericUpDown.Margin = new Padding(2);
            horasTotalesNumericUpDown.Name = "horasTotalesNumericUpDown";
            horasTotalesNumericUpDown.Size = new Size(210, 23);
            horasTotalesNumericUpDown.TabIndex = 25;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(14, 150);
            descripcionLabel.Margin = new Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(69, 15);
            descripcionLabel.TabIndex = 28;
            descripcionLabel.Text = "Descripcion";
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(254, 284);
            cancelarButton.Margin = new Padding(2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(80, 22);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(153, 284);
            aceptarButton.Margin = new Padding(2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(80, 22);
            aceptarButton.TabIndex = 26;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // planLabel
            // 
            planLabel.AutoSize = true;
            planLabel.Location = new Point(14, 27);
            planLabel.Margin = new Padding(2, 0, 2, 0);
            planLabel.Name = "planLabel";
            planLabel.Size = new Size(30, 15);
            planLabel.TabIndex = 24;
            planLabel.Text = "Plan";
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 330);
            Controls.Add(planDropDown);
            Controls.Add(DescripcionRichTextBox);
            Controls.Add(HorasSemanalesLabel);
            Controls.Add(horasSemanalesNumericUpDown);
            Controls.Add(horasTotalesLabel);
            Controls.Add(horasTotalesNumericUpDown);
            Controls.Add(descripcionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(planLabel);
            Name = "MateriaDetalle";
            Text = "MateriaDetalle";
            ((System.ComponentModel.ISupportInitialize)horasSemanalesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)horasTotalesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox planDropDown;
        private RichTextBox DescripcionRichTextBox;
        private Label HorasSemanalesLabel;
        private NumericUpDown horasSemanalesNumericUpDown;
        private Label horasTotalesLabel;
        private NumericUpDown horasTotalesNumericUpDown;
        private Label descripcionLabel;
        private Button cancelarButton;
        private Button aceptarButton;
        private Label planLabel;
    }
}