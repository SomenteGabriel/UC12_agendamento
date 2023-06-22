namespace UC12_agendamento
{
    partial class Detalhes
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
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecomaterial = new System.Windows.Forms.TextBox();
            this.textBoxPrecoservico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelRelatorio = new System.Windows.Forms.Label();
            this.textBoxRelatorio = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAlterar.FlatAppearance.BorderSize = 0;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(55, 374);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(195, 37);
            this.buttonAlterar.TabIndex = 19;
            this.buttonAlterar.Text = "Alterar Informações";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(208, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente:";
            // 
            // textBoxPrecomaterial
            // 
            this.textBoxPrecomaterial.Location = new System.Drawing.Point(227, 162);
            this.textBoxPrecomaterial.Name = "textBoxPrecomaterial";
            this.textBoxPrecomaterial.Size = new System.Drawing.Size(142, 20);
            this.textBoxPrecomaterial.TabIndex = 16;
            // 
            // textBoxPrecoservico
            // 
            this.textBoxPrecoservico.Location = new System.Drawing.Point(227, 88);
            this.textBoxPrecoservico.Name = "textBoxPrecoservico";
            this.textBoxPrecoservico.Size = new System.Drawing.Size(142, 20);
            this.textBoxPrecoservico.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Preço material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preço Serviço";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(19, 68);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(176, 228);
            this.textBoxDescricao.TabIndex = 11;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(29, 33);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(155, 16);
            this.labelDescricao.TabIndex = 10;
            this.labelDescricao.Text = "Descrição do serviço";
            // 
            // labelRelatorio
            // 
            this.labelRelatorio.AutoSize = true;
            this.labelRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelatorio.Location = new System.Drawing.Point(458, 33);
            this.labelRelatorio.Name = "labelRelatorio";
            this.labelRelatorio.Size = new System.Drawing.Size(71, 16);
            this.labelRelatorio.TabIndex = 20;
            this.labelRelatorio.Text = "Relatório";
            // 
            // textBoxRelatorio
            // 
            this.textBoxRelatorio.Location = new System.Drawing.Point(407, 68);
            this.textBoxRelatorio.Multiline = true;
            this.textBoxRelatorio.Name = "textBoxRelatorio";
            this.textBoxRelatorio.Size = new System.Drawing.Size(176, 228);
            this.textBoxRelatorio.TabIndex = 21;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonFinalizar.FlatAppearance.BorderSize = 0;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.Location = new System.Drawing.Point(334, 374);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(195, 37);
            this.buttonFinalizar.TabIndex = 22;
            this.buttonFinalizar.Text = "Finalizar Serviço";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(227, 251);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(142, 20);
            this.textBoxDate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prazo do serviço";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.White;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(269, 314);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(62, 18);
            this.labelCliente.TabIndex = 25;
            this.labelCliente.Text = "Gabriel";
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.textBoxRelatorio);
            this.Controls.Add(this.labelRelatorio);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecomaterial);
            this.Controls.Add(this.textBoxPrecoservico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Name = "Detalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecomaterial;
        private System.Windows.Forms.TextBox textBoxPrecoservico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelRelatorio;
        private System.Windows.Forms.TextBox textBoxRelatorio;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCliente;
    }
}