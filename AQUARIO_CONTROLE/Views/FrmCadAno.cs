using AQUARIO_CONTROLE.Entidades;
using AQUARIO_CONTROLE.Models;
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
    public partial class FrmCadAno : Form
    {
        Ano obj = new Ano();
        public FrmCadAno()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Ano> lista = new List<Ano>();
                lista = new AnoModel().Listar();
               
                dg.DataSource = lista;//primeiro alimenta o data grid 
                dg.Columns[0].Visible = false;// define o qua acontece com as colunas 
                dg.Columns[1].HeaderText = "Ano";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível gerar uma lista " + ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtAno.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtAno.Text =="")
            {
                MessageBox.Show("Insira um ano !!");
                return;
            }

            salvar();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void salvar()
        {
            try
            {
                obj.Anos = Convert.ToInt32(txtAno.Text);
                int X = AnoModel.Inserir(obj);
                if (X > 0)
                {
                    MessageBox.Show("INSERIDO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("NÃO INSERIDO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("NÃO INSERIDO" + ex);
            }
        }

        private void FrmCadAno_Load(object sender, EventArgs e)
        {

        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Digitar apenas valores numéricos");
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                Listar();
                return;
            }
            obj.Anos = Convert.ToInt32(txtBuscar.Text);
            List<Ano> lista = new List<Ano>();
            lista = new AnoModel().Buscar(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtAno.Text = dg.CurrentRow.Cells[1].Value.ToString();

            txtAno.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtAno.Text == "")
            {
                MessageBox.Show("Insira um ano !!");
                return;
            }
            editar();

            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void editar()
        {

            try
            {
                obj.Anos = Convert.ToInt32(txtAno.Text);
                obj.Id_ano = Convert.ToInt32(txtId.Text);
                int X = AnoModel.Editar(obj);
                if (X > 0)
                {
                    MessageBox.Show("EDITADO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("NÃO EDITADO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("NÃO EDITADO" + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }
            excluir();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void excluir()
        {
            try
            {
                
                obj.Id_ano = Convert.ToInt32(txtId.Text);
                int X = AnoModel.Deletar(obj);
                if (X > 0)
                {
                    MessageBox.Show("EXCLUIDO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("NÃO EXCLUIDO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("NÃO EXCLUÍDO" + ex);
            }
        }
    }
}
