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
    public partial class FormVisitas : Form
    {
        CN_Visitas objNegocio = new CN_Visitas();
        CE_Visitas CE_Visitas = new CE_Visitas();
        public FormVisitas()
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
                if (tool is PictureBox)
                {
                    tool.Text = "";
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            dataGridViewVisitas.DataSource = objNegocio.Mostrando_CN();
            Limpiar();
        }

        private void FormVisitas_Load(object sender, EventArgs e)
        {
            dataGridViewVisitas.DataSource = objNegocio.Mostrando_CN();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                CE_Visitas.Nombre1 = txtNombre.Text.ToUpper();
                CE_Visitas.Apellido1 = txtApellido.Text.ToUpper();
                CE_Visitas.Edificio1 = comboBoxEdificio.Text;
                CE_Visitas.Aula1 = comboBoxAula.Text;
                CE_Visitas.Telefono1 = mskTxtTelefono.Text;
                CE_Visitas.FechaEntrada1 = Convert.ToDateTime(dateTimePickerFE.Text);
                CE_Visitas.FechaSalida1 = Convert.ToDateTime(dateTimePickerFS.Text);
                CE_Visitas.Carrera1 = comboBoxCarrera.Text;
                CE_Visitas.Correo1 = mskTxtCorreo.Text;
                CE_Visitas.MotivoVisita1 = txtMotivo.Text;
                CE_Visitas.Foto1 = ms.GetBuffer();
                CE_Visitas.Matricula1 = mskTxtMatricula.Text;
                if (radioButtonEstudiante.Checked == true)
                {CE_Visitas.TipoVisitante1 = (radioButtonEstudiante.Text); }
                else
                {CE_Visitas.TipoVisitante1 = (radioButtonVisitante.Text); }


                objNegocio.Guardando_CN(CE_Visitas);

                MessageBox.Show("Registro Guardado");

                dataGridViewVisitas.DataSource = objNegocio.Mostrando_CN();

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

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ft = new OpenFileDialog();
            DialogResult rt = ft.ShowDialog();
            if (rt == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(ft.FileName);
            }
        }
    }
}
