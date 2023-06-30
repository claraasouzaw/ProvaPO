namespace ProvaPO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.tx_profissao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_sexo = new System.Windows.Forms.ComboBox();
            this.tx_inicioP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_salvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de aponsentadoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(120, 148);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(236, 20);
            this.tx_nome.TabIndex = 2;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(472, 150);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(192, 20);
            this.tx_cpf.TabIndex = 4;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpf_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PROFISSÃO";
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(143, 318);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(76, 20);
            this.tx_idade.TabIndex = 6;
            this.tx_idade.TextChanged += new System.EventHandler(this.tx_nascimento_TextChanged);
            // 
            // tx_profissao
            // 
            this.tx_profissao.FormattingEnabled = true;
            this.tx_profissao.Items.AddRange(new object[] {
            "Saúde ",
            "Professor ",
            "Agentes de segurança",
            "Outra profissão"});
            this.tx_profissao.Location = new System.Drawing.Point(178, 222);
            this.tx_profissao.Name = "tx_profissao";
            this.tx_profissao.Size = new System.Drawing.Size(134, 21);
            this.tx_profissao.TabIndex = 7;
            this.tx_profissao.SelectedIndexChanged += new System.EventHandler(this.tx_profissao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "IDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "INICIO DA PROFISSÃO";
            // 
            // tx_sexo
            // 
            this.tx_sexo.FormattingEnabled = true;
            this.tx_sexo.Items.AddRange(new object[] {
            "Feminino ",
            "Masculino ",
            "Outro"});
            this.tx_sexo.Location = new System.Drawing.Point(490, 221);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(134, 21);
            this.tx_sexo.TabIndex = 11;
            this.tx_sexo.SelectedIndexChanged += new System.EventHandler(this.tx_sexo_SelectedIndexChanged);
            // 
            // tx_inicioP
            // 
            this.tx_inicioP.Location = new System.Drawing.Point(644, 318);
            this.tx_inicioP.Name = "tx_inicioP";
            this.tx_inicioP.Size = new System.Drawing.Size(76, 20);
            this.tx_inicioP.TabIndex = 12;
            this.tx_inicioP.TextChanged += new System.EventHandler(this.tx_inicioP_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_salvar
            // 
            this.tx_salvar.Location = new System.Drawing.Point(684, 411);
            this.tx_salvar.Name = "tx_salvar";
            this.tx_salvar.Size = new System.Drawing.Size(86, 27);
            this.tx_salvar.TabIndex = 14;
            this.tx_salvar.Text = "SALVAR";
            this.tx_salvar.UseVisualStyleBackColor = true;
            this.tx_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            // 
            // lb_confirm
            // 
            this.lb_confirm.AutoSize = true;
            this.lb_confirm.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm.Location = new System.Drawing.Point(262, 379);
            this.lb_confirm.Name = "lb_confirm";
            this.lb_confirm.Size = new System.Drawing.Size(130, 20);
            this.lb_confirm.TabIndex = 16;
            this.lb_confirm.Text = "RESULTADO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_inicioP);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_profissao);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.ComboBox tx_profissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tx_sexo;
        private System.Windows.Forms.TextBox tx_inicioP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tx_salvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_confirm;
    }
}

