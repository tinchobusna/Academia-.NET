namespace WindowsForms
{
    partial class Reportes
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
            reportePlanesButton = new Button();
            reporteCursosButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // reportePlanesButton
            // 
            reportePlanesButton.Location = new Point(263, 124);
            reportePlanesButton.Name = "reportePlanesButton";
            reportePlanesButton.Size = new Size(183, 47);
            reportePlanesButton.TabIndex = 0;
            reportePlanesButton.Text = "Planes";
            reportePlanesButton.UseVisualStyleBackColor = true;
            // 
            // reporteCursosButton
            // 
            reporteCursosButton.Location = new Point(263, 177);
            reporteCursosButton.Name = "reporteCursosButton";
            reporteCursosButton.Size = new Size(183, 47);
            reporteCursosButton.TabIndex = 1;
            reporteCursosButton.Text = "Cursos";
            reporteCursosButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 101);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Reportes:";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(reporteCursosButton);
            Controls.Add(reportePlanesButton);
            Name = "Reportes";
            Text = "Form1";
            reportePlanesButton.Click += reportePlanesButton_Click;
            reporteCursosButton.Click += reporteCursosButton_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reportePlanesButton;
        private Button reporteCursosButton;
        private Label label1;
    }
}