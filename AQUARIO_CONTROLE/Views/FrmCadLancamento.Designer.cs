namespace AQUARIO_CONTROLE.Views
{
    partial class FrmCadLancamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBuscar = new System.Windows.Forms.DateTimePicker();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbBuscarData = new System.Windows.Forms.RadioButton();
            this.rbBuscarTipo = new System.Windows.Forms.RadioButton();
            this.cbBuscarTipo = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(439, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 27);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(602, 397);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(294, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 27);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(134, 398);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 25);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(48, 186);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(696, 197);
            this.dg.TabIndex = 9;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(134, 97);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(361, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(602, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 20);
            this.txtValor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mês:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(134, 59);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 19;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(339, 59);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(156, 21);
            this.cbMes.TabIndex = 20;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(602, 59);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(142, 21);
            this.cbAno.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Buscar:";
            // 
            // dtBuscar
            // 
            this.dtBuscar.Enabled = false;
            this.dtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscar.Location = new System.Drawing.Point(602, 9);
            this.dtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.Size = new System.Drawing.Size(142, 26);
            this.dtBuscar.TabIndex = 23;
            this.dtBuscar.Value = new System.DateTime(2020, 3, 18, 15, 12, 21, 0);
            this.dtBuscar.ValueChanged += new System.EventHandler(this.dtBuscar_ValueChanged);
            // 
            // dt
            // 
            this.dt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(134, 133);
            this.dt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(142, 26);
            this.dt.TabIndex = 25;
            this.dt.Value = new System.DateTime(2020, 3, 18, 15, 12, 21, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Data:";
            // 
            // rbBuscarData
            // 
            this.rbBuscarData.AutoSize = true;
            this.rbBuscarData.Location = new System.Drawing.Point(134, 18);
            this.rbBuscarData.Name = "rbBuscarData";
            this.rbBuscarData.Size = new System.Drawing.Size(102, 17);
            this.rbBuscarData.TabIndex = 26;
            this.rbBuscarData.TabStop = true;
            this.rbBuscarData.Text = "Buscar por Data";
            this.rbBuscarData.UseVisualStyleBackColor = true;
            this.rbBuscarData.CheckedChanged += new System.EventHandler(this.rbBuscarData_CheckedChanged);
            // 
            // rbBuscarTipo
            // 
            this.rbBuscarTipo.AutoSize = true;
            this.rbBuscarTipo.Location = new System.Drawing.Point(339, 18);
            this.rbBuscarTipo.Name = "rbBuscarTipo";
            this.rbBuscarTipo.Size = new System.Drawing.Size(100, 17);
            this.rbBuscarTipo.TabIndex = 27;
            this.rbBuscarTipo.TabStop = true;
            this.rbBuscarTipo.Text = "Buscar por Tipo";
            this.rbBuscarTipo.UseVisualStyleBackColor = true;
            this.rbBuscarTipo.CheckedChanged += new System.EventHandler(this.rbBuscarTipo_CheckedChanged);
            // 
            // cbBuscarTipo
            // 
            this.cbBuscarTipo.FormattingEnabled = true;
            this.cbBuscarTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbBuscarTipo.Location = new System.Drawing.Point(330, 32);
            this.cbBuscarTipo.Name = "cbBuscarTipo";
            this.cbBuscarTipo.Size = new System.Drawing.Size(142, 21);
            this.cbBuscarTipo.TabIndex = 28;
            this.cbBuscarTipo.Visible = false;
            this.cbBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.cbBuscarTipo_SelectedIndexChanged);
            this.cbBuscarTipo.SelectionChangeCommitted += new System.EventHandler(this.cbBuscarTipo_SelectionChangeCommitted);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(644, 133);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(91, 20);
            this.txtId.TabIndex = 29;
            this.txtId.Visible = false;
            // 
            // FrmCadLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbBuscarTipo);
            this.Controls.Add(this.rbBuscarTipo);
            this.Controls.Add(this.rbBuscarData);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadLancamento";
            this.Text = "Lancamento";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBuscar;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbBuscarData;
        private System.Windows.Forms.RadioButton rbBuscarTipo;
        private System.Windows.Forms.ComboBox cbBuscarTipo;
        private System.Windows.Forms.TextBox txtId;
    }
}