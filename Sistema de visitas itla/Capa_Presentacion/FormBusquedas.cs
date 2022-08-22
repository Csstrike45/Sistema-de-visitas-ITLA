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
    public partial class FormBusquedas : Form
    {
        CN_Visitas objNegocio = new CN_Visitas();

        public FormBusquedas()
        {
            Limpiar();
            InitializeComponent();
        }

        public void Mostrar(string buscar)
        {
            CN_Visitas cN_Visitas = new CN_Visitas();
            dataGridViewBusquedas.DataSource = cN_Visitas.Buscando_CN(buscar);
        }
        private void FormBusquedas_Load(object sender, EventArgs e)
        {
            dataGridViewBusquedas.DataSource = objNegocio.Mostrando_CN();
        }
        private void Limpiar()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormPrcUsuario frmprcusuario = new FormPrcUsuario();
            frmprcusuario.Show();
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Mostrar(txtNombre.Text);
        }
    }
}
