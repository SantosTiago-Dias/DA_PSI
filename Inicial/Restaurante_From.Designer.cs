namespace Inicial
{
    partial class Restaurante_From
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.btnAddMorada = new System.Windows.Forms.Button();
            this.dgRestaurante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(463, 50);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 0;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(463, 131);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 20);
            this.txtRua.TabIndex = 1;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(463, 92);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 2;
            // 
            // btnAddMorada
            // 
            this.btnAddMorada.Location = new System.Drawing.Point(463, 185);
            this.btnAddMorada.Name = "btnAddMorada";
            this.btnAddMorada.Size = new System.Drawing.Size(100, 23);
            this.btnAddMorada.TabIndex = 3;
            this.btnAddMorada.Text = "Adicionar Morada";
            this.btnAddMorada.UseVisualStyleBackColor = true;
            this.btnAddMorada.Click += new System.EventHandler(this.btnAddMorada_Click);
            // 
            // dgRestaurante
            // 
            this.dgRestaurante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestaurante.Location = new System.Drawing.Point(25, 50);
            this.dgRestaurante.Name = "dgRestaurante";
            this.dgRestaurante.Size = new System.Drawing.Size(388, 150);
            this.dgRestaurante.TabIndex = 4;
            this.dgRestaurante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRestaurante_CellContentClick);
            // 
            // Restaurante_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgRestaurante);
            this.Controls.Add(this.btnAddMorada);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCidade);
            this.Name = "Restaurante_From";
            this.Text = "Restaurante_From";
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Button btnAddMorada;
        private System.Windows.Forms.DataGridView dgRestaurante;
    }
}