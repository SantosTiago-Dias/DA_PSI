namespace Inicial
{
    partial class Pagamento_Form
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
            this.dgPagamento = new System.Windows.Forms.DataGridView();
            this.cmbMetedoPagamento = new System.Windows.Forms.ComboBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.Nmesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltapagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metedoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPagamento
            // 
            this.dgPagamento.AllowUserToAddRows = false;
            this.dgPagamento.AllowUserToDeleteRows = false;
            this.dgPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nmesa,
            this.valor_total,
            this.faltapagar,
            this.metedoPagamento});
            this.dgPagamento.Location = new System.Drawing.Point(26, 12);
            this.dgPagamento.Name = "dgPagamento";
            this.dgPagamento.ReadOnly = true;
            this.dgPagamento.Size = new System.Drawing.Size(448, 235);
            this.dgPagamento.TabIndex = 0;
            // 
            // cmbMetedoPagamento
            // 
            this.cmbMetedoPagamento.FormattingEnabled = true;
            this.cmbMetedoPagamento.Location = new System.Drawing.Point(643, 133);
            this.cmbMetedoPagamento.Name = "cmbMetedoPagamento";
            this.cmbMetedoPagamento.Size = new System.Drawing.Size(121, 21);
            this.cmbMetedoPagamento.TabIndex = 1;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(643, 174);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(131, 23);
            this.btnRegistar.TabIndex = 2;
            this.btnRegistar.Text = "Registar Pagamento";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Pago:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(643, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Metedo de pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero Pedido";
            // 
            // cmbPedido
            // 
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(643, 80);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(121, 21);
            this.cmbPedido.TabIndex = 6;
            // 
            // Nmesa
            // 
            this.Nmesa.HeaderText = "Numero Mesa";
            this.Nmesa.Name = "Nmesa";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            // 
            // faltapagar
            // 
            this.faltapagar.HeaderText = "Falta Pagar";
            this.faltapagar.Name = "faltapagar";
            this.faltapagar.ReadOnly = true;
            // 
            // metedoPagamento
            // 
            this.metedoPagamento.HeaderText = "Metedo Pagamento";
            this.metedoPagamento.Name = "metedoPagamento";
            // 
            // Pagamento_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.cmbMetedoPagamento);
            this.Controls.Add(this.dgPagamento);
            this.Name = "Pagamento_Form";
            this.Text = "Pagamento_Form";
            this.Load += new System.EventHandler(this.Pagamento_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPagamento;
        private System.Windows.Forms.ComboBox cmbMetedoPagamento;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nmesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltapagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn metedoPagamento;
    }
}