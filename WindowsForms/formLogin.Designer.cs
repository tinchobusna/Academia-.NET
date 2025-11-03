using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms
{
    partial class formLogin
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
            usuarioLabel = new Label();
            contraseñaLabel = new Label();
            iniciarSesionButton = new Button();
            usuarioTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(46, 118);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(47, 15);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "Usuario";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new Point(46, 161);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(67, 15);
            contraseñaLabel.TabIndex = 1;
            contraseñaLabel.Text = "Contraseña";
            // 
            // iniciarSesionButton
            // 
            iniciarSesionButton.Location = new Point(170, 220);
            iniciarSesionButton.Name = "iniciarSesionButton";
            iniciarSesionButton.Size = new Size(133, 24);
            iniciarSesionButton.TabIndex = 2;
            iniciarSesionButton.Text = "Ingresar";
            iniciarSesionButton.UseVisualStyleBackColor = true;
            iniciarSesionButton.Click += iniciarSesionButton_Click;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(151, 115);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(183, 23);
            usuarioTextBox.TabIndex = 3;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.Location = new Point(151, 158);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.Size = new Size(183, 23);
            contraseñaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 64);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 5;
            label1.Text = "Porfavor Ingrese su usuario y contraseña";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 294);
            Controls.Add(label1);
            Controls.Add(contraseñaTextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(iniciarSesionButton);
            Controls.Add(contraseñaLabel);
            Controls.Add(usuarioLabel);
            Name = "formLogin";
            Text = "Inicio de sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usuarioLabel;
        private Label contraseñaLabel;
        private Button iniciarSesionButton;
        private TextBox usuarioTextBox;
        private TextBox contraseñaTextBox;
        private Label label1;
    }
}