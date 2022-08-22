using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class FormPrcUsuario : Form
    {
        public FormPrcUsuario()
        {
            InitializeComponent();
        }

        private void BtnRegVisita_Click(object sender, EventArgs e)
        {
            FormVisitas frmvisitas = new FormVisitas();
            frmvisitas.Show();
            this.Hide();
        }

        private void BtnRegUser_Click(object sender, EventArgs e)
        {
            FormUsuarios frmusuarios= new FormUsuarios();
            frmusuarios.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin frmlogin = new FormLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FormBusquedas frmbusquedas = new FormBusquedas();
            frmbusquedas.Show();
            this.Hide();
        }

        private void FormPrcUsuario_Load(object sender, EventArgs e)
        {
            permisos();
        }
        public void permisos()
        {
            if (CE_Login.Cargo1 == CE_Cargos.General)
            {
                BtnRegUser.Enabled = false;
            }
        }
    }
}
