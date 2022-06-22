namespace Inicial
{
    partial class Funcionarios_Form
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddFunc = new System.Windows.Forms.Button();
            this.txtCodPostalFunc = new System.Windows.Forms.TextBox();
            this.txtRuaFunc = new System.Windows.Forms.TextBox();
            this.txtTelemovel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidadeFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPosicaoFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dgFuncionario = new System.Windows.Forms.DataGridView();
            this.lblIdFunc = new System.Windows.Forms.Label();
            this.lblIdMorada = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Funcinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(668, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar Funcionario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(668, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome Funcionario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(744, 50);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cod_Postal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rua";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnaddFunc
            // 
            this.btnaddFunc.Location = new System.Drawing.Point(668, 262);
            this.btnaddFunc.Name = "btnaddFunc";
            this.btnaddFunc.Size = new System.Drawing.Size(162, 23);
            this.btnaddFunc.TabIndex = 16;
            this.btnaddFunc.Text = "Adicionar Funcionario";
            this.btnaddFunc.UseVisualStyleBackColor = true;
            this.btnaddFunc.Click += new System.EventHandler(this.btnaddFunc_Click);
            // 
            // txtCodPostalFunc
            // 
            this.txtCodPostalFunc.Location = new System.Drawing.Point(744, 102);
            this.txtCodPostalFunc.Name = "txtCodPostalFunc";
            this.txtCodPostalFunc.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostalFunc.TabIndex = 15;
            // 
            // txtRuaFunc
            // 
            this.txtRuaFunc.Location = new System.Drawing.Point(744, 128);
            this.txtRuaFunc.Name = "txtRuaFunc";
            this.txtRuaFunc.Size = new System.Drawing.Size(100, 20);
            this.txtRuaFunc.TabIndex = 14;
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(744, 76);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(100, 20);
            this.txtTelemovel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCidadeFunc
            // 
            this.txtCidadeFunc.Location = new System.Drawing.Point(744, 154);
            this.txtCidadeFunc.Name = "txtCidadeFunc";
            this.txtCidadeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtCidadeFunc.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Posição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosicaoFunc
            // 
            this.txtPosicaoFunc.Location = new System.Drawing.Point(744, 206);
            this.txtPosicaoFunc.Name = "txtPosicaoFunc";
            this.txtPosicaoFunc.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoFunc.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Salario";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(744, 180);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 27;
            // 
            // dgFuncionario
            // 
            this.dgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.id_rest,
            this.nome_Funcinario,
            this.tele,
            this.posicao,
            this.salario,
            this.cidade,
            this.cod_Postal,
            this.rua,
            this.id_morada});
            this.dgFuncionario.Location = new System.Drawing.Point(12, 56);
            this.dgFuncionario.Name = "dgFuncionario";
            this.dgFuncionario.Size = new System.Drawing.Size(595, 206);
            this.dgFuncionario.TabIndex = 35;
            this.dgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionario_CellContentClick);
            // 
            // lblIdFunc
            // 
            this.lblIdFunc.AutoSize = true;
            this.lblIdFunc.Location = new System.Drawing.Point(741, 22);
            this.lblIdFunc.Name = "lblIdFunc";
            this.lblIdFunc.Size = new System.Drawing.Size(0, 13);
            this.lblIdFunc.TabIndex = 36;
            this.lblIdFunc.Visible = false;
            // 
            // lblIdMorada
            // 
            this.lblIdMorada.Location = new System.Drawing.Point(979, 132);
            this.lblIdMorada.Name = "lblIdMorada";
            this.lblIdMorada.Size = new System.Drawing.Size(46, 17);
            this.lblIdMorada.TabIndex = 37;
            this.lblIdMorada.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // id_rest
            // 
            this.id_rest.HeaderText = "id_rest";
            this.id_rest.Name = "id_rest";
            this.id_rest.Visible = false;
            // 
            // nome_Funcinario
            // 
            this.nome_Funcinario.HeaderText = "Nome";
            this.nome_Funcinario.Name = "nome_Funcinario";
            this.nome_Funcinario.ReadOnly = true;
            // 
            // tele
            // 
            this.tele.HeaderText = "Telemovel";
            this.tele.Name = "tele";
            this.tele.ReadOnly = true;
            // 
            // posicao
            // 
            this.posicao.HeaderText = "Posição";
            this.posicao.Name = "posicao";
            this.posicao.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 150;
            // 
            // cod_Postal
            // 
            this.cod_Postal.HeaderText = "Codigo Postal";
            this.cod_Postal.Name = "cod_Postal";
            this.cod_Postal.ReadOnly = true;
            this.cod_Postal.Visible = false;
            // 
            // rua
            // 
            this.rua.HeaderText = "Rua";
            this.rua.Name = "rua";
            this.rua.ReadOnly = true;
            this.rua.Visible = false;
            // 
            // id_morada
            // 
            this.id_morada.HeaderText = "id_morada";
            this.id_morada.Name = "id_morada";
            this.id_morada.Visible = false;
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(532, 325);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(102, 23);
            this.btnFazerPedido.TabIndex = 38;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // Funcionarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 363);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.lblIdMorada);
            this.Controls.Add(this.lblIdFunc);
            this.Controls.Add(this.dgFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosicaoFunc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCidadeFunc);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddFunc);
            this.Controls.Add(this.txtCodPostalFunc);
            this.Controls.Add(this.txtRuaFunc);
            this.Controls.Add(this.txtTelemovel);
            this.Name = "Funcionarios_Form";
            this.Text = "Funcionarios_Form";
            this.Load += new System.EventHandler(this.Funcionarios_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddFunc;
        private System.Windows.Forms.TextBox txtCodPostalFunc;
        private System.Windows.Forms.TextBox txtRuaFunc;
        private System.Windows.Forms.TextBox txtTelemovel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidadeFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosicaoFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView dgFuncionario;
        private System.Windows.Forms.Label lblIdFunc;
        private System.Windows.Forms.Label lblIdMorada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Funcinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_morada;
        private System.Windows.Forms.Button btnFazerPedido;
    }
}