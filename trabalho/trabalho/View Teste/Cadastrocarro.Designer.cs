namespace trabalho.View_Teste
{
    partial class Cadastrocarro
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_modelo_carro = new System.Windows.Forms.TextBox();
            this.txb_marca_carro = new System.Windows.Forms.TextBox();
            this.txb_nome_carro = new System.Windows.Forms.TextBox();
            this.txb_cor_carro = new System.Windows.Forms.TextBox();
            this.salvar_carro = new System.Windows.Forms.Button();
            this.nmr_qtdestoque = new System.Windows.Forms.NumericUpDown();
            this.nmr_preco = new System.Windows.Forms.NumericUpDown();
            this.chb_airbag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_qtdestoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo do carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor do carro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tem air bag?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Preço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantidade em estoque:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Marca do Carro";
            // 
            // txb_modelo_carro
            // 
            this.txb_modelo_carro.Location = new System.Drawing.Point(130, 21);
            this.txb_modelo_carro.Name = "txb_modelo_carro";
            this.txb_modelo_carro.Size = new System.Drawing.Size(100, 23);
            this.txb_modelo_carro.TabIndex = 10;
            // 
            // txb_marca_carro
            // 
            this.txb_marca_carro.Location = new System.Drawing.Point(130, 63);
            this.txb_marca_carro.Name = "txb_marca_carro";
            this.txb_marca_carro.Size = new System.Drawing.Size(100, 23);
            this.txb_marca_carro.TabIndex = 12;
            // 
            // txb_nome_carro
            // 
            this.txb_nome_carro.Location = new System.Drawing.Point(130, 152);
            this.txb_nome_carro.Name = "txb_nome_carro";
            this.txb_nome_carro.Size = new System.Drawing.Size(100, 23);
            this.txb_nome_carro.TabIndex = 14;
            // 
            // txb_cor_carro
            // 
            this.txb_cor_carro.Location = new System.Drawing.Point(130, 106);
            this.txb_cor_carro.Name = "txb_cor_carro";
            this.txb_cor_carro.Size = new System.Drawing.Size(100, 23);
            this.txb_cor_carro.TabIndex = 15;
            // 
            // salvar_carro
            // 
            this.salvar_carro.Location = new System.Drawing.Point(97, 342);
            this.salvar_carro.Name = "salvar_carro";
            this.salvar_carro.Size = new System.Drawing.Size(75, 23);
            this.salvar_carro.TabIndex = 17;
            this.salvar_carro.Text = "Salvar";
            this.salvar_carro.UseVisualStyleBackColor = true;
            this.salvar_carro.Click += new System.EventHandler(this.salvar_carro_Click);
            // 
            // nmr_qtdestoque
            // 
            this.nmr_qtdestoque.Location = new System.Drawing.Point(169, 238);
            this.nmr_qtdestoque.Name = "nmr_qtdestoque";
            this.nmr_qtdestoque.Size = new System.Drawing.Size(120, 23);
            this.nmr_qtdestoque.TabIndex = 18;
            // 
            // nmr_preco
            // 
            this.nmr_preco.Location = new System.Drawing.Point(72, 275);
            this.nmr_preco.Name = "nmr_preco";
            this.nmr_preco.Size = new System.Drawing.Size(120, 23);
            this.nmr_preco.TabIndex = 19;
            // 
            // chb_airbag
            // 
            this.chb_airbag.AutoSize = true;
            this.chb_airbag.Location = new System.Drawing.Point(117, 199);
            this.chb_airbag.Name = "chb_airbag";
            this.chb_airbag.Size = new System.Drawing.Size(46, 19);
            this.chb_airbag.TabIndex = 20;
            this.chb_airbag.Text = "Sim";
            this.chb_airbag.UseVisualStyleBackColor = true;
            // 
            // Cadastrocarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 407);
            this.Controls.Add(this.chb_airbag);
            this.Controls.Add(this.nmr_preco);
            this.Controls.Add(this.nmr_qtdestoque);
            this.Controls.Add(this.salvar_carro);
            this.Controls.Add(this.txb_cor_carro);
            this.Controls.Add(this.txb_nome_carro);
            this.Controls.Add(this.txb_marca_carro);
            this.Controls.Add(this.txb_modelo_carro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrocarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrocarro";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_qtdestoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txb_modelo_carro;
        private TextBox txb_marca_carro;
        private TextBox txb_nome_carro;
        private TextBox txb_cor_carro;
        private Button salvar_carro;
        private NumericUpDown nmr_qtdestoque;
        private NumericUpDown nmr_preco;
        private CheckBox chb_airbag;
    }
}