namespace AQUARIO_CONTROLE.Views
{
    partial class FrmEspecies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecies));
            this.dtRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicioCriacao = new System.Windows.Forms.DateTimePicker();
            this.dtFimCriacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempoCriacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMetaEspecie = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dtView = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRegistro
            // 
            this.dtRegistro.Enabled = false;
            this.dtRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegistro.Location = new System.Drawing.Point(653, 7);
            this.dtRegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.Size = new System.Drawing.Size(130, 26);
            this.dtRegistro.TabIndex = 25;
            this.dtRegistro.Value = new System.DateTime(2020, 3, 18, 15, 12, 21, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(329, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(237, 20);
            this.txtBuscar.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(99, 50);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(187, 20);
            this.txtDescricao.TabIndex = 52;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(498, 50);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(68, 20);
            this.txtTamanho.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tamanho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Espécie";
            // 
            // cbEspecie
            // 
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(653, 97);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(130, 21);
            this.cbEspecie.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Inicio Criação";
            // 
            // dtInicioCriacao
            // 
            this.dtInicioCriacao.Enabled = false;
            this.dtInicioCriacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioCriacao.Location = new System.Drawing.Point(114, 97);
            this.dtInicioCriacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtInicioCriacao.Name = "dtInicioCriacao";
            this.dtInicioCriacao.Size = new System.Drawing.Size(130, 26);
            this.dtInicioCriacao.TabIndex = 58;
            this.dtInicioCriacao.Value = new System.DateTime(2020, 3, 18, 15, 12, 21, 0);
            // 
            // dtFimCriacao
            // 
            this.dtFimCriacao.Enabled = false;
            this.dtFimCriacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFimCriacao.Location = new System.Drawing.Point(384, 97);
            this.dtFimCriacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFimCriacao.Name = "dtFimCriacao";
            this.dtFimCriacao.Size = new System.Drawing.Size(130, 26);
            this.dtFimCriacao.TabIndex = 60;
            this.dtFimCriacao.Value = new System.DateTime(2020, 3, 18, 15, 12, 21, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Final Criação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Tempo de Criação";
            // 
            // txtTempoCriacao
            // 
            this.txtTempoCriacao.Location = new System.Drawing.Point(714, 50);
            this.txtTempoCriacao.Name = "txtTempoCriacao";
            this.txtTempoCriacao.Size = new System.Drawing.Size(68, 20);
            this.txtTempoCriacao.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Data Registro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Meta da Espécie";
            // 
            // txtMetaEspecie
            // 
            this.txtMetaEspecie.Location = new System.Drawing.Point(394, 49);
            this.txtMetaEspecie.Name = "txtMetaEspecie";
            this.txtMetaEspecie.Size = new System.Drawing.Size(36, 20);
            this.txtMetaEspecie.TabIndex = 65;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 66;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buscar Data";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(142, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 67;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Buscar Espécie";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dtView
            // 
            this.dtView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Location = new System.Drawing.Point(37, 159);
            this.dtView.Name = "dtView";
            this.dtView.Size = new System.Drawing.Size(746, 215);
            this.dtView.TabIndex = 68;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(195, 380);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 58);
            this.btnNovo.TabIndex = 69;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(307, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 58);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(416, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 58);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(522, 380);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 58);
            this.btnDeletar.TabIndex = 72;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // FrmEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtMetaEspecie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTempoCriacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFimCriacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtInicioCriacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtRegistro);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmEspecies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Especies";
            this.Load += new System.EventHandler(this.FrmEspecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicioCriacao;
        private System.Windows.Forms.DateTimePicker dtFimCriacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempoCriacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMetaEspecie;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dtView;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
    }
}