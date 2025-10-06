﻿using API.Usuarios;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public enum FormMode2
    {
        Add,
        Update
    }

    public partial class UsuarioDetalle : Form
    {
        private UsuarioDTO usuario;
        private FormMode2 mode2;

        public UsuarioDTO Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }

        public FormMode2 Mode2
        {
            get
            {
                return mode2;
            }
            set
            {
                SetFormMode(value);
            }
        }

        public UsuarioDetalle()
        {
            InitializeComponent();

            Mode2 = FormMode2.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {

            try
            {

                this.Usuario.NombreUsuario = nombreUsuarioTextBox.Text;
                this.Usuario.Clave = contraseñaTextBox.Text;
                this.Usuario.Habilitado = habilitadoCheckBox.Checked;
                this.Usuario.Nombre = nombreTextBox.Text;
                this.Usuario.Apellido = apellidoTextBox.Text;
                this.Usuario.Email = emailTextBox.Text;
                this.Usuario.CambiaClave = cambiaClaveCheckBox.Checked;
                this.Usuario.IdPersona = (int)idPersonaNumericUpDown.Value;





                if (this.Mode2 == FormMode2.Update)
                {
                    await UsuarioApiClient.UpdateAsync(this.Usuario);
                }
                else
                {
                    await UsuarioApiClient.AddAsync(this.Usuario);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUsuario()
        {

            this.idPersonaNumericUpDown.Maximum = 999999;

            this.nombreUsuarioTextBox.Text = this.Usuario.NombreUsuario;
            this.contraseñaTextBox.Text = this.Usuario.Clave;
            this.habilitadoCheckBox.Checked = this.Usuario.Habilitado;
            this.nombreTextBox.Text = this.Usuario.Nombre;
            this.apellidoTextBox.Text = this.Usuario.Apellido;
            this.emailTextBox.Text = this.Usuario.Email;
            this.cambiaClaveCheckBox.Checked = this.Usuario.CambiaClave;
            this.idPersonaNumericUpDown.Value = this.Usuario.IdPersona;

        }

        private void SetFormMode(FormMode2 value)
        {

            mode2 = value;

        }
    }
}