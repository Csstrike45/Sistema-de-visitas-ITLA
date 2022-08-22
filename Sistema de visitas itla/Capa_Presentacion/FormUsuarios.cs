using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Capa_Presentacion
{
    public partial class FormUsuarios : Form
    {
        CN_Login objNegocio = new CN_Login();
        public FormUsuarios()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
                if (tool is MaskedTextBox)
                {
                    tool.Text = "";
                }
                if (tool is ComboBox)
                {
                    tool.Text = "";
                }
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Limpiar();
            dataGridViewUsers.DataSource = objNegocio.Mostrando_CN();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = objNegocio.Mostrando_CN();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Login.User = txtUser.Text;
                CE_Login.Pass = txtPass.Text;
                CE_Login.Nombre1 = txtNombre.Text.ToUpper();
                CE_Login.Apellido1 = txtApellido.Text.ToUpper();
                CE_Login.Fecha1 = Convert.ToDateTime(dateTimePickerFecha.Text);
                if (radioButtonUser.Checked == true)
                { CE_Login.Cargo1 = (radioButtonUser.Text); }
                else
                { CE_Login.Cargo1 = (radioButtonAdimin.Text); }


                objNegocio.Guardando_CN();

                MessageBox.Show("Registro Guardado");

                dataGridViewUsers.DataSource = objNegocio.Mostrando_CN();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormPrcUsuario frmprcusuario = new FormPrcUsuario();
            frmprcusuario.Show();
            this.Hide();
        }
    }
}
