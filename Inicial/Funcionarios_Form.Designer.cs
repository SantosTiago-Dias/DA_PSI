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
            this.label8 = new System.Windows.Forms.Label();
            this.lblNomeRestaurante = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgFuncionario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Funcinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(797, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar Funcionario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(797, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome Funcionario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(873, 55);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cod_Postal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rua";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnaddFunc
            // 
            this.btnaddFunc.Location = new System.Drawing.Point(797, 267);
            this.btnaddFunc.Name = "btnaddFunc";
            this.btnaddFunc.Size = new System.Drawing.Size(162, 23);
            this.btnaddFunc.TabIndex = 16;
            this.btnaddFunc.Text = "Adicionar Funcionario";
            this.btnaddFunc.UseVisualStyleBackColor = true;
            this.btnaddFunc.Click += new System.EventHandler(this.btnaddFunc_Click);
            // 
            // txtCodPostalFunc
            // 
            this.txtCodPostalFunc.Location = new System.Drawing.Point(873, 107);
            this.txtCodPostalFunc.Name = "txtCodPostalFunc";
            this.txtCodPostalFunc.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostalFunc.TabIndex = 15;
            // 
            // txtRuaFunc
            // 
            this.txtRuaFunc.Location = new System.Drawing.Point(873, 133);
            this.txtRuaFunc.Name = "txtRuaFunc";
            this.txtRuaFunc.Size = new System.Drawing.Size(100, 20);
            this.txtRuaFunc.TabIndex = 14;
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(873, 81);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(100, 20);
            this.txtTelemovel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(830, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCidadeFunc
            // 
            this.txtCidadeFunc.Location = new System.Drawing.Point(873, 159);
            this.txtCidadeFunc.Name = "txtCidadeFunc";
            this.txtCidadeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtCidadeFunc.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Posição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosicaoFunc
            // 
            this.txtPosicaoFunc.Location = new System.Drawing.Point(873, 211);
            this.txtPosicaoFunc.Name = "txtPosicaoFunc";
            this.txtPosicaoFunc.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoFunc.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Salario";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(873, 185);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Restaurante";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeRestaurante
            // 
            this.lblNomeRestaurante.Location = new System.Drawing.Point(870, 241);
            this.lblNomeRestaurante.Name = "lblNomeRestaurante";
            this.lblNomeRestaurante.Size = new System.Drawing.Size(100, 23);
            this.lblNomeRestaurante.TabIndex = 33;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(954, 234);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 34;
            // 
            // dgFuncionario
            // 
            this.dgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nome_Funcinario,
            this.tele,
            this.posicao,
            this.salario,
            this.nome_restaurante,
            this.cidade});
            this.dgFuncionario.Location = new System.Drawing.Point(12, 56);
            this.dgFuncionario.Name = "dgFuncionario";
            this.dgFuncionario.Size = new System.Drawing.Size(743, 206);
            this.dgFuncionario.TabIndex = 35;
            this.dgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionario_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // nome_Funcinario
            // 
            this.nome_Funcinario.HeaderText = "Nome";
            this.nome_Funcinario.Name = "nome_Funcinario";
            // 
            // tele
            // 
            this.tele.HeaderText = "Telemovel";
            this.tele.Name = "tele";
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
            // nome_restaurante
            // 
            this.nome_restaurante.HeaderText = "Nome Restaurante";
            this.nome_restaurante.Name = "nome_restaurante";
            this.nome_restaurante.ReadOnly = true;
            this.nome_restaurante.Width = 150;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 150;
            // 
            // Funcionarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 423);
            this.Controls.Add(this.dgFuncionario);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNomeRestaurante);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomeRestaurante;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Funcinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
    }
}