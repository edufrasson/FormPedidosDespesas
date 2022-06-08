namespace FormPedidosDespesa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.grbDespesas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listPedidos = new System.Windows.Forms.ListView();
            this.btnInserirPedido = new System.Windows.Forms.Button();
            this.colPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.lblTotalDespesa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserirDespesa = new System.Windows.Forms.Button();
            this.listDespesas = new System.Windows.Forms.ListView();
            this.colDespesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValorDespesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbSaldo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbPedido.SuspendLayout();
            this.grbDespesas.SuspendLayout();
            this.grbSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPedido
            // 
            this.grbPedido.Controls.Add(this.lblTotalPedidos);
            this.grbPedido.Controls.Add(this.label4);
            this.grbPedido.Controls.Add(this.btnInserirPedido);
            this.grbPedido.Controls.Add(this.listPedidos);
            this.grbPedido.Controls.Add(this.txtValorPedido);
            this.grbPedido.Controls.Add(this.label3);
            this.grbPedido.Controls.Add(this.txtCliente);
            this.grbPedido.Controls.Add(this.label2);
            this.grbPedido.Controls.Add(this.txtPedido);
            this.grbPedido.Controls.Add(this.label1);
            this.grbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPedido.Location = new System.Drawing.Point(25, 24);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Size = new System.Drawing.Size(567, 499);
            this.grbPedido.TabIndex = 0;
            this.grbPedido.TabStop = false;
            this.grbPedido.Text = "Pedidos";
            // 
            // grbDespesas
            // 
            this.grbDespesas.Controls.Add(this.lblTotalDespesa);
            this.grbDespesas.Controls.Add(this.listDespesas);
            this.grbDespesas.Controls.Add(this.label6);
            this.grbDespesas.Controls.Add(this.label9);
            this.grbDespesas.Controls.Add(this.btnInserirDespesa);
            this.grbDespesas.Controls.Add(this.txtDespesa);
            this.grbDespesas.Controls.Add(this.txtValorDespesa);
            this.grbDespesas.Controls.Add(this.label7);
            this.grbDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDespesas.Location = new System.Drawing.Point(616, 24);
            this.grbDespesas.Name = "grbDespesas";
            this.grbDespesas.Size = new System.Drawing.Size(567, 499);
            this.grbDespesas.TabIndex = 1;
            this.grbDespesas.TabStop = false;
            this.grbDespesas.Text = "Despesas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Pedido";
            // 
            // txtPedido
            // 
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(110, 25);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(269, 26);
            this.txtPedido.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(110, 67);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(269, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPedido.Location = new System.Drawing.Point(110, 108);
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.Size = new System.Drawing.Size(269, 26);
            this.txtValorPedido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // listPedidos
            // 
            this.listPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPedido,
            this.colCliente,
            this.colValor});
            this.listPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPedidos.HideSelection = false;
            this.listPedidos.Location = new System.Drawing.Point(31, 173);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(506, 225);
            this.listPedidos.TabIndex = 6;
            this.listPedidos.UseCompatibleStateImageBehavior = false;
            this.listPedidos.View = System.Windows.Forms.View.Details;
            // 
            // btnInserirPedido
            // 
            this.btnInserirPedido.Location = new System.Drawing.Point(418, 58);
            this.btnInserirPedido.Name = "btnInserirPedido";
            this.btnInserirPedido.Size = new System.Drawing.Size(132, 42);
            this.btnInserirPedido.TabIndex = 4;
            this.btnInserirPedido.Text = "Inserir Pedido";
            this.btnInserirPedido.UseVisualStyleBackColor = true;
            this.btnInserirPedido.Click += new System.EventHandler(this.btnInserirPedido_Click);
            // 
            // colPedido
            // 
            this.colPedido.Text = "Cód. Pedido";
            this.colPedido.Width = 104;
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            this.colCliente.Width = 150;
            // 
            // colValor
            // 
            this.colValor.Text = "Valor ";
            this.colValor.Width = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total dos pedidos: ";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPedidos.Location = new System.Drawing.Point(429, 436);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(0, 29);
            this.lblTotalPedidos.TabIndex = 9;
            // 
            // lblTotalDespesa
            // 
            this.lblTotalDespesa.AutoSize = true;
            this.lblTotalDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalDespesa.Location = new System.Drawing.Point(438, 436);
            this.lblTotalDespesa.Name = "lblTotalDespesa";
            this.lblTotalDespesa.Size = new System.Drawing.Size(0, 29);
            this.lblTotalDespesa.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total dos pedidos: ";
            // 
            // btnInserirDespesa
            // 
            this.btnInserirDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirDespesa.Location = new System.Drawing.Point(420, 67);
            this.btnInserirDespesa.Name = "btnInserirDespesa";
            this.btnInserirDespesa.Size = new System.Drawing.Size(132, 42);
            this.btnInserirDespesa.TabIndex = 7;
            this.btnInserirDespesa.Text = "Inserir Despesa";
            this.btnInserirDespesa.UseVisualStyleBackColor = true;
            this.btnInserirDespesa.Click += new System.EventHandler(this.btnInserirDespesa_Click);
            // 
            // listDespesas
            // 
            this.listDespesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDespesa,
            this.colValorDespesa});
            this.listDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDespesas.HideSelection = false;
            this.listDespesas.Location = new System.Drawing.Point(40, 173);
            this.listDespesas.Name = "listDespesas";
            this.listDespesas.Size = new System.Drawing.Size(506, 225);
            this.listDespesas.TabIndex = 16;
            this.listDespesas.UseCompatibleStateImageBehavior = false;
            this.listDespesas.View = System.Windows.Forms.View.Details;
            // 
            // colDespesa
            // 
            this.colDespesa.Text = "Despesa";
            this.colDespesa.Width = 104;
            // 
            // colValorDespesa
            // 
            this.colValorDespesa.Text = "Valor";
            this.colValorDespesa.Width = 150;
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDespesa.Location = new System.Drawing.Point(117, 90);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(269, 26);
            this.txtValorDespesa.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesa.Location = new System.Drawing.Point(117, 45);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(269, 26);
            this.txtDespesa.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Despesa";
            // 
            // grbSaldo
            // 
            this.grbSaldo.Controls.Add(this.btnFechar);
            this.grbSaldo.Controls.Add(this.btnNovo);
            this.grbSaldo.Controls.Add(this.lblSaldo);
            this.grbSaldo.Controls.Add(this.label5);
            this.grbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSaldo.Location = new System.Drawing.Point(28, 569);
            this.grbSaldo.Name = "grbSaldo";
            this.grbSaldo.Size = new System.Drawing.Size(1154, 97);
            this.grbSaldo.TabIndex = 2;
            this.grbSaldo.TabStop = false;
            this.grbSaldo.Text = "Saldo da Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Blue;
            this.lblSaldo.Location = new System.Drawing.Point(311, 47);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 29);
            this.lblSaldo.TabIndex = 10;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(738, 27);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(154, 51);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo Lançamento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(965, 27);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(154, 49);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar o Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 675);
            this.Controls.Add(this.grbSaldo);
            this.Controls.Add(this.grbDespesas);
            this.Controls.Add(this.grbPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            this.grbDespesas.ResumeLayout(false);
            this.grbDespesas.PerformLayout();
            this.grbSaldo.ResumeLayout(false);
            this.grbSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserirPedido;
        private System.Windows.Forms.ListView listPedidos;
        private System.Windows.Forms.ColumnHeader colPedido;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.TextBox txtValorPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDespesas;
        private System.Windows.Forms.Label lblTotalDespesa;
        private System.Windows.Forms.ListView listDespesas;
        private System.Windows.Forms.ColumnHeader colDespesa;
        private System.Windows.Forms.ColumnHeader colValorDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInserirDespesa;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbSaldo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label5;
    }
}

