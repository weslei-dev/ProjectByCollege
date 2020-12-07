namespace Servidores
{
    partial class BrServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrServidor));
            this.listServidores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTipoServidor = new System.Windows.Forms.ComboBox();
            this.btnAdicionarServidor = new System.Windows.Forms.Button();
            this.listClientes = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTempoAtendimento = new System.Windows.Forms.TextBox();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.listAtendentes = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listServidores
            // 
            this.listServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listServidores.HideSelection = false;
            this.listServidores.Location = new System.Drawing.Point(40, 156);
            this.listServidores.Name = "listServidores";
            this.listServidores.Size = new System.Drawing.Size(301, 346);
            this.listServidores.TabIndex = 1;
            this.listServidores.UseCompatibleStateImageBehavior = false;
            this.listServidores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade Clientes";
            this.columnHeader2.Width = 163;
            // 
            // cbTipoServidor
            // 
            this.cbTipoServidor.FormattingEnabled = true;
            this.cbTipoServidor.Location = new System.Drawing.Point(40, 117);
            this.cbTipoServidor.Name = "cbTipoServidor";
            this.cbTipoServidor.Size = new System.Drawing.Size(136, 24);
            this.cbTipoServidor.TabIndex = 2;
            // 
            // btnAdicionarServidor
            // 
            this.btnAdicionarServidor.Location = new System.Drawing.Point(200, 115);
            this.btnAdicionarServidor.Name = "btnAdicionarServidor";
            this.btnAdicionarServidor.Size = new System.Drawing.Size(141, 27);
            this.btnAdicionarServidor.TabIndex = 3;
            this.btnAdicionarServidor.Text = "Adicionar Servidor";
            this.btnAdicionarServidor.UseVisualStyleBackColor = true;
            this.btnAdicionarServidor.Click += new System.EventHandler(this.btnAdicionarServidor_Click);
            // 
            // listClientes
            // 
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(816, 96);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(667, 577);
            this.listClientes.TabIndex = 4;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Horário Entrada";
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Horário Saída";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Servidor";
            this.columnHeader6.Width = 160;
            // 
            // tbTempoAtendimento
            // 
            this.tbTempoAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempoAtendimento.Location = new System.Drawing.Point(398, 110);
            this.tbTempoAtendimento.Name = "tbTempoAtendimento";
            this.tbTempoAtendimento.Size = new System.Drawing.Size(148, 30);
            this.tbTempoAtendimento.TabIndex = 5;
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(568, 112);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(149, 30);
            this.btnAdicionarCliente.TabIndex = 6;
            this.btnAdicionarCliente.Text = "Adicionar Atendente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // listAtendentes
            // 
            this.listAtendentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listAtendentes.HideSelection = false;
            this.listAtendentes.Location = new System.Drawing.Point(388, 156);
            this.listAtendentes.Name = "listAtendentes";
            this.listAtendentes.Size = new System.Drawing.Size(329, 346);
            this.listAtendentes.TabIndex = 7;
            this.listAtendentes.UseCompatibleStateImageBehavior = false;
            this.listAtendentes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nome";
            this.columnHeader7.Width = 133;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tempo de Atendimento";
            this.columnHeader8.Width = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Servidor Multiplo ou Unico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tempo para atender os clientes (minutos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(880, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Leitura do Sevidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horas, minutos, segundos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "00:00:00";
            // 
            // BrServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 685);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAtendentes);
            this.Controls.Add(this.btnAdicionarCliente);
            this.Controls.Add(this.tbTempoAtendimento);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnAdicionarServidor);
            this.Controls.Add(this.cbTipoServidor);
            this.Controls.Add(this.listServidores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrServidor";
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listServidores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbTipoServidor;
        private System.Windows.Forms.Button btnAdicionarServidor;
        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox tbTempoAtendimento;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.ListView listAtendentes;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

