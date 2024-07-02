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
    public partial class FrmCadLancamento : Form
    {
        Lancamento obj = new Lancamento();
        AnoModel modelA = new AnoModel();//Estanciando anoModels da classe Models 
        public FrmCadLancamento()
        {
            InitializeComponent();
            PreencherCB();

            dt.Value = DateTime.Now;
            dtBuscar.Value = DateTime.Now;

            DesabilitarCampos();
            btnSalvar.Enabled = false;

            Listar();
        }

        private void DesabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbTipo.Enabled = false;
            cbAno.Enabled = false;
            cbMes.Enabled = false;
            dt.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbTipo.Enabled = true;
            cbAno.Enabled = true;
            cbMes.Enabled = true;
            dt.Enabled = true;
        }
        private void LimparCampo()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cbBuscarTipo.Text = "";
        }
        private void PreencherCB()
        {//Metodo para preencher o combobox
            cbAno.DataSource = modelA.Listar();
            cbAno.ValueMember = "id_ano";
            cbAno.DisplayMember = " ano ";
        }

        private void rbBuscarTipo_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Value = DateTime.Now;
            dtBuscar.Visible = false;
            cbBuscarTipo.Visible = true;
        }

        private void rbBuscarData_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Visible = true;
            cbBuscarTipo.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um Valor !!");
                return;
            }
            btnSalvar.Enabled = true;
            salvar();
            LimparCampo();
            btnSalvar.Enabled = false;
            Listar();

        }

        private void Listar()
        {
            try
            {
                List<Lancamento> lista = new List<Lancamento>();
                lista = new LancModel().Listar();

                dg.DataSource = lista;//primeiro alimenta o data grid 
                dg.Columns[0].Visible = false;
                dg.Columns[4].Visible = false;
                dg.Columns[5].Visible = false;// define o qua acontece com as colunas 
                dg.Columns[1].HeaderText = "Tipo";
                dg.Columns[2].HeaderText = "Descricao";
                dg.Columns[3].HeaderText = "Valor";
                dg.Columns[6].HeaderText = "Data";
                dg.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível gerar uma lista " + ex);
            }
        }

        private void salvar()
        {
            try
            {
                obj.Tipo = cbTipo.Text;
                obj.Descricacao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Date = dt.Value;
                int X = LancModel.Inserir(obj);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um Valor !!");
                return;
            }

            editar();
            LimparCampo();//metodo de limpar campos 
            btnSalvar.Enabled = false;
            Listar();//metodo de listar campos 
        }

        private void editar()
        {
            try
            {
                obj.Tipo = cbTipo.Text;
                obj.Descricacao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Date = dt.Value;
                obj.Id_lancamento = Convert.ToInt32(txtId.Text);
                int X = LancModel.Editar(obj);
                if (X > 0)
                {
                    MessageBox.Show("Editado COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("NÃO Editado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("NÃO Editado" + ex);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtId.Text = dg.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dg.CurrentRow.Cells[3].Value.ToString();
            cbMes.Text = dg.CurrentRow.Cells[4].Value.ToString();
            cbAno.SelectedItem = dg.CurrentRow.Cells[5].Value.ToString();// SelectedItem carrega o Ano na txtAno
            dt.Text = dg.CurrentRow.Cells[6].Value.ToString();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }
            excluir();
            DesabilitarCampos();
            LimparCampo();
            Listar();
        }

        private void excluir()
        {
            try
            {

                obj.Id_lancamento = Convert.ToInt32(txtId.Text);
                int X = LancModel.Deletar(obj);
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

        private void cbBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            obj.Tipo = cbBuscarTipo.Text;
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().BuscarTipo(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;
        }

        private void cbBuscarTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbBuscarTipo.Text == "")
            {
                Listar();
                return;
            }
            obj.Tipo = cbBuscarTipo.Text;
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().BuscarTipo(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;

        }

        private void dtBuscar_ValueChanged(object sender, EventArgs e)
        {
            obj.Date = dtBuscar.Value;
            List<Lancamento> lista = new List<Lancamento>();
            lista = new LancModel().Buscar(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;
        }
    }
}
