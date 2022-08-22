using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class FormLogin : Form
    {
        CN_Login objNegocio = new CN_Login();
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                CE_Login.User = txtUser.Text;
                CE_Login.Pass = txtPass.Text;

                dt = objNegocio.Login_CN();

                if (dt.Rows.Count > 0)
                {
                    CE_Login.ID1 = int.Parse(dt.Rows[0][0].ToString());
                    CE_Login.code = dt.Rows[0][1].ToString();
                    CE_Login.User = dt.Rows[0][2].ToString();
                    CE_Login.Pass = dt.Rows[0][3].ToString();
                    CE_Login.Nombre1 = dt.Rows[0][4].ToString();
                    CE_Login.Apellido1 = dt.Rows[0][5].ToString();
                    CE_Login.Cargo1 = dt.Rows[0][6].ToString();
                    CE_Login.Fecha1 = Convert.ToDateTime(dt.Rows[0][7].ToString());

                    MessageBox.Show($"BIENVENIDO: \n\n {CE_Login.Nombre1}  {CE_Login.Apellido1}.");

                    FormPrcUsuario frmPrincipal = new FormPrcUsuario();
                    frmPrincipal.Show();
                    frmPrincipal.FormClosed += Logout;
                    this.Hide();


                }
                else
                {
                    MessageBox.Show($"DATOS INCORRECTOS, VERIFIQUE SU USUARIO O SU CONTRASEÑA... ");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
            catch (Exception Error)
            {

                MessageBox.Show($"{Error.Message}");
                txtUser.Clear();
                txtPass.Clear();
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            this.Show();
            txtUser.Focus();
        }
    }
}
