namespace Inicial
{
    partial class Fazer_Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNifCliente = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.cmbPratos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPratos = new System.Windows.Forms.ListBox();
            this.btnAdionarLista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCLienteId = new System.Windows.Forms.Label();
            this.lblIdRestaurante = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNomeRestaurante = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.nPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nif do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(998, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor total";
            // 
            // txtNifCliente
            // 
            this.txtNifCliente.Location = new System.Drawing.Point(1001, 24);
            this.txtNifCliente.Name = "txtNifCliente";
            this.txtNifCliente.Size = new System.Drawing.Size(125, 20);
            this.txtNifCliente.TabIndex = 5;
            this.txtNifCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(1076, 362);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(28, 13);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "0,00";
            // 
            // cmbPratos
            // 
            this.cmbPratos.FormattingEnabled = true;
            this.cmbPratos.Location = new System.Drawing.Point(1001, 141);
            this.cmbPratos.Name = "cmbPratos";
            this.cmbPratos.Size = new System.Drawing.Size(124, 21);
            this.cmbPratos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(921, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pratos";
            // 
            // lbPratos
            // 
            this.lbPratos.FormattingEnabled = true;
            this.lbPratos.Location = new System.Drawing.Point(978, 223);
            this.lbPratos.Name = "lbPratos";
            this.lbPratos.Size = new System.Drawing.Size(159, 108);
            this.lbPratos.TabIndex = 13;
            // 
            // btnAdionarLista
            // 
            this.btnAdionarLista.Location = new System.Drawing.Point(1001, 178);
            this.btnAdionarLista.Name = "btnAdionarLista";
            this.btnAdionarLista.Size = new System.Drawing.Size(124, 23);
            this.btnAdionarLista.TabIndex = 14;
            this.btnAdionarLista.Text = "Adicionar ao Pedido";
            this.btnAdionarLista.UseVisualStyleBackColor = true;
            this.btnAdionarLista.Click += new System.EventHandler(this.btnAdionarLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pedido:";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(1001, 402);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(124, 23);
            this.btnFazerPedido.TabIndex = 16;
            this.btnFazerPedido.Text = "Fazer pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(907, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome do Cliente:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(1001, 53);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 18;
            // 
            // lblCLienteId
            // 
            this.lblCLienteId.AutoSize = true;
            this.lblCLienteId.Location = new System.Drawing.Point(880, 24);
            this.lblCLienteId.Name = "lblCLienteId";
            this.lblCLienteId.Size = new System.Drawing.Size(35, 13);
            this.lblCLienteId.TabIndex = 19;
            this.lblCLienteId.Text = "label8";
            this.lblCLienteId.Visible = false;
            // 
            // lblIdRestaurante
            // 
            this.lblIdRestaurante.AutoSize = true;
            this.lblIdRestaurante.Location = new System.Drawing.Point(880, 93);
            this.lblIdRestaurante.Name = "lblIdRestaurante";
            this.lblIdRestaurante.Size = new System.Drawing.Size(35, 13);
            this.lblIdRestaurante.TabIndex = 20;
            this.lblIdRestaurante.Text = "label8";
            this.lblIdRestaurante.UseMnemonic = false;
            this.lblIdRestaurante.Visible = false;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(880, 120);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lblFuncionario.TabIndex = 21;
            this.lblFuncionario.Text = "label8";
            this.lblFuncionario.Visible = false;
            // 
            // lblNomeRestaurante
            // 
            this.lblNomeRestaurante.AutoSize = true;
            this.lblNomeRestaurante.Location = new System.Drawing.Point(1001, 89);
            this.lblNomeRestaurante.Name = "lblNomeRestaurante";
            this.lblNomeRestaurante.Size = new System.Drawing.Size(35, 13);
            this.lblNomeRestaurante.TabIndex = 22;
            this.lblNomeRestaurante.Text = "label8";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(1001, 117);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFuncionario.TabIndex = 23;
            this.lblNomeFuncionario.Text = "label8";
            // 
            // dgPedido
            // 
            this.dgPedido.AllowUserToAddRows = false;
            this.dgPedido.AllowUserToDeleteRows = false;
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nPedido,
            this.cliente,
            this.funcionario,
            this.pedido,
            this.valortotal,
            this.estado});
            this.dgPedido.Location = new System.Drawing.Point(12, 50);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.ReadOnly = true;
            this.dgPedido.Size = new System.Drawing.Size(814, 305);
            this.dgPedido.TabIndex = 24;
            // 
            // nPedido
            // 
            this.nPedido.HeaderText = "Pedido N";
            this.nPedido.Name = "nPedido";
            this.nPedido.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Nome Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // funcionario
            // 
            this.funcionario.HeaderText = "Nome Funcionario";
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            // 
            // pedido
            // 
            this.pedido.HeaderText = "Pedido";
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            this.pedido.Width = 270;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "Valor Total";
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(551, 402);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(124, 23);
            this.btnAvancar.TabIndex = 25;
            this.btnAvancar.Text = "Proxima Faze";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(702, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(37, 402);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(102, 23);
            this.btnPagamento.TabIndex = 27;
            this.btnPagamento.Text = "Pagamentos";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // Fazer_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.dgPedido);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblNomeRestaurante);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblIdRestaurante);
            this.Controls.Add(this.lblCLienteId);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdionarLista);
            this.Controls.Add(this.lbPratos);
            this.Controls.Add(this.cmbPratos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtNifCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fazer_Pedido";
            this.Text = "Fazer Pedido";
            this.Load += new System.EventHandler(this.Fazer_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNifCliente;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ComboBox cmbPratos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPratos;
        private System.Windows.Forms.Button btnAdionarLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCLienteId;
        private System.Windows.Forms.Label lblIdRestaurante;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblNomeRestaurante;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagamento;
    }
}