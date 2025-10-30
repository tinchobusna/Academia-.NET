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
            refrescarButton.Location = new Point(287, 293);
            refrescarButton.Margin = new Padding(3, 4, 3, 4);
            refrescarButton.Name = "refrescarButton";
            refrescarButton.Size = new Size(95, 39);
            refrescarButton.TabIndex = 19;
            refrescarButton.Text = "Refrescar";
            refrescarButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(486, 293);
            modificarButton.Margin = new Padding(2, 3, 2, 3);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(95, 39);
            modificarButton.TabIndex = 18;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(387, 293);
            eliminarButton.Margin = new Padding(2, 3, 2, 3);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(95, 39);
            eliminarButton.TabIndex = 17;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(585, 293);
            agregarButton.Margin = new Padding(2, 3, 2, 3);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(95, 39);
            agregarButton.TabIndex = 16;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            // 
            // especialidadesDataGridView
            // 
            especialidadesDataGridView.AllowUserToOrderColumns = true;
            especialidadesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadesDataGridView.Location = new Point(11, 12);
            especialidadesDataGridView.Margin = new Padding(2, 3, 2, 3);
            especialidadesDataGridView.MultiSelect = false;
            especialidadesDataGridView.Name = "especialidadesDataGridView";
            especialidadesDataGridView.ReadOnly = true;
            especialidadesDataGridView.RowHeadersWidth = 82;
            especialidadesDataGridView.RowTemplate.Height = 41;
            especialidadesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadesDataGridView.Size = new Size(669, 274);
            especialidadesDataGridView.TabIndex = 15;
            // 
            // EspecialidadesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 351);
            Controls.Add(refrescarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(especialidadesDataGridView);
            Name = "EspecialidadesLista";
            Text = "Form1";
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