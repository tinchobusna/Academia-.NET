namespace WindowsForms
{
    partial class EspecialidadesLista
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
            refrescarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            agregarButton = new Button();
            especialidadesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // refrescarButton
            // 
            refrescarButton.Location = new Point(251, 12);
            refrescarButton.Name = "refrescarButton";
            refrescarButton.Size = new Size(83, 29);
            refrescarButton.TabIndex = 19;
            refrescarButton.Text = "Refrescar";
            refrescarButton.UseVisualStyleBackColor = true;
            refrescarButton.Click += refrescarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(425, 12);
            modificarButton.Margin = new Padding(2, 2, 2, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(83, 29);
            modificarButton.TabIndex = 18;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(339, 12);
            eliminarButton.Margin = new Padding(2, 2, 2, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(83, 29);
            eliminarButton.TabIndex = 17;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(512, 12);
            agregarButton.Margin = new Padding(2, 2, 2, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(83, 29);
            agregarButton.TabIndex = 16;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // especialidadesDataGridView
            // 
            especialidadesDataGridView.AllowUserToOrderColumns = true;
            especialidadesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadesDataGridView.Location = new Point(11, 55);
            especialidadesDataGridView.Margin = new Padding(2, 2, 2, 2);
            especialidadesDataGridView.MultiSelect = false;
            especialidadesDataGridView.Name = "especialidadesDataGridView";
            especialidadesDataGridView.ReadOnly = true;
            especialidadesDataGridView.RowHeadersWidth = 82;
            especialidadesDataGridView.RowTemplate.Height = 41;
            especialidadesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadesDataGridView.Size = new Size(585, 241);
            especialidadesDataGridView.TabIndex = 15;
            // 
            // EspecialidadesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 307);
            Controls.Add(refrescarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(especialidadesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EspecialidadesLista";
            Text = "Form1";
            Load += Especialidades_Load;
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button refrescarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private Button agregarButton;
        private DataGridView especialidadesDataGridView;
    }
}