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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(200, 200, 200);
            pnlRight.BackColor = Color.FromArgb(180, 180, 180);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void peixesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecies formEspecie = new FrmEspecies();
            formEspecie.ShowDialog();
        }
    }
}
