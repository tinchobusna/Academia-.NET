namespace WindowsForms
{
    partial class PlanDetalle
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
            DescripcionRichTextBox = new RichTextBox();
            especialidadDropDown = new ComboBox();
            cancelarButton = new Button();
            aceptarButton = new Button();
            descripcionLabel = new Label();
            especialidadLabel = new Label();
            SuspendLayout();
            // 
            // DescripcionRichTextBox
            // 
            DescripcionRichTextBox.Location = new Point(120, 88);
            DescripcionRichTextBox.Name = "DescripcionRichTextBox";
            DescripcionRichTextBox.Size = new Size(229, 118);
            DescripcionRichTextBox.TabIndex = 0;
            DescripcionRichTextBox.Text = "";
            // 
            // especialidadDropDown
            // 
            especialidadDropDown.FormattingEnabled = true;
            especialidadDropDown.Location = new Point(120, 12);
            especialidadDropDown.Name = "especialidadDropDown";
            especialidadDropDown.Size = new Size(229, 23);
            especialidadDropDown.TabIndex = 1;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(274, 229);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 21;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click_1;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(181, 229);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 20;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click_1;   
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(31, 91);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(69, 15);
            descripcionLabel.TabIndex = 22;
            descripcionLabel.Text = "Descripcion";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new Point(31, 15);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new Size(72, 15);
            especialidadLabel.TabIndex = 23;
            especialidadLabel.Text = "Especialidad";
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 268);
            Controls.Add(especialidadLabel);
            Controls.Add(descripcionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(especialidadDropDown);
            Controls.Add(DescripcionRichTextBox);
            Name = "PlanDetalle";
            Text = "PlanDetalle";
            Load += PlanDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox DescripcionRichTextBox;
        private ComboBox especialidadDropDown;
        private Button cancelarButton;
        private Button aceptarButton;
        private Label descripcionLabel;
        private Label especialidadLabel;
    }
}