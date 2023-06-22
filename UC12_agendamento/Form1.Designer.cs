namespace UC12_agendamento
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
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonNovoagendamento = new System.Windows.Forms.Button();
            this.buttonAgendamentoatual = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Location = new System.Drawing.Point(78, 72);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(279, 48);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "Cadastrar Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonNovoagendamento
            // 
            this.buttonNovoagendamento.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonNovoagendamento.FlatAppearance.BorderSize = 0;
            this.buttonNovoagendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoagendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoagendamento.Location = new System.Drawing.Point(78, 160);
            this.buttonNovoagendamento.Name = "buttonNovoagendamento";
            this.buttonNovoagendamento.Size = new System.Drawing.Size(279, 48);
            this.buttonNovoagendamento.TabIndex = 1;
            this.buttonNovoagendamento.Text = "Novo Agendamento";
            this.buttonNovoagendamento.UseVisualStyleBackColor = false;
            this.buttonNovoagendamento.Click += new System.EventHandler(this.buttonNovoagendamento_Click);
            // 
            // buttonAgendamentoatual
            // 
            this.buttonAgendamentoatual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAgendamentoatual.FlatAppearance.BorderSize = 0;
            this.buttonAgendamentoatual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendamentoatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendamentoatual.Location = new System.Drawing.Point(78, 253);
            this.buttonAgendamentoatual.Name = "buttonAgendamentoatual";
            this.buttonAgendamentoatual.Size = new System.Drawing.Size(279, 48);
            this.buttonAgendamentoatual.TabIndex = 2;
            this.buttonAgendamentoatual.Text = "Agendamentos Ativos";
            this.buttonAgendamentoatual.UseVisualStyleBackColor = false;
            this.buttonAgendamentoatual.Click += new System.EventHandler(this.buttonAgendamentoatual_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(78, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agendamentos Inativos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAgendamentoatual);
            this.Controls.Add(this.buttonNovoagendamento);
            this.Controls.Add(this.buttonClientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonNovoagendamento;
        private System.Windows.Forms.Button buttonAgendamentoatual;
        private System.Windows.Forms.Button button3;
    }
}

