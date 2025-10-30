namespace WindowsForms
{
    partial class NotaDetalle
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
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            numericUpDownNota = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(151, 87);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(86, 31);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(243, 87);
            buttonAceptar.Margin = new Padding(3, 4, 3, 4);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(86, 31);
            buttonAceptar.TabIndex = 4;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNota
            // 
            numericUpDownNota.Location = new Point(12, 52);
            numericUpDownNota.Margin = new Padding(3, 4, 3, 4);
            numericUpDownNota.Name = "numericUpDownNota";
            numericUpDownNota.Size = new Size(306, 27);
            numericUpDownNota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Indique la nota:";
            // 
            // NotaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 134);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAceptar);
            Controls.Add(numericUpDownNota);
            Name = "NotaDetalle";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonAceptar;
        private NumericUpDown numericUpDownNota;
        private Label label1;
    }
}