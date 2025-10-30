namespace WindowsForms
{
    partial class EspecialidadDetalle
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
            descripcionLabel = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            SuspendLayout();
            // 
            // DescripcionRichTextBox
            // 
            DescripcionRichTextBox.Location = new Point(14, 41);
            DescripcionRichTextBox.Margin = new Padding(3, 4, 3, 4);
            DescripcionRichTextBox.Name = "DescripcionRichTextBox";
            DescripcionRichTextBox.Size = new Size(310, 79);
            DescripcionRichTextBox.TabIndex = 43;
            DescripcionRichTextBox.Text = "";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(14, 17);
            descripcionLabel.Margin = new Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(87, 20);
            descripcionLabel.TabIndex = 42;
            descripcionLabel.Text = "Descripcion";
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(138, 132);
            cancelarButton.Margin = new Padding(2, 3, 2, 3);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(91, 29);
            cancelarButton.TabIndex = 41;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(233, 132);
            aceptarButton.Margin = new Padding(2, 3, 2, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(91, 29);
            aceptarButton.TabIndex = 40;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            // 
            // EspecialidadDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 171);
            Controls.Add(DescripcionRichTextBox);
            Controls.Add(descripcionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Name = "EspecialidadDetalle";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox DescripcionRichTextBox;
        private Label descripcionLabel;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}