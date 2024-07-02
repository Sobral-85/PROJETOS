using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQUARIO_CONTROLE.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
            pnlLogin.Location = new Point(this.Width /2 - 166,this.Height /2 - 170);
            pnlLogin.Visible = true;
            //btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0,0,0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }
        private void ChamarLogin()
        {

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios");
                txtUsuario.Focus();
                return;
            }

            frmMenu form = new frmMenu();
            //this.Hide();
            Limpar();
            form.Show();
        }
        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
