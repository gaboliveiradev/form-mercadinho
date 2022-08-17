namespace wpf_mercadinho
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_valor_unit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_venda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_qnt_alterar = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_nova_venda = new System.Windows.Forms.Button();
            this.btn_cancelar_venda = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.dgv_venda = new System.Windows.Forms.DataGridView();
            this.cmn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmn_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmn_valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmn_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(5)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_remover);
            this.panel4.Controls.Add(this.btn_inserir);
            this.panel4.Controls.Add(this.txt_valor_unit);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_quantidade);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_produto);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_id_venda);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(9, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 453);
            this.panel4.TabIndex = 1;
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(124)))));
            this.btn_remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(14, 388);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(269, 50);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "REMOVER";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(124)))));
            this.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(124)))));
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(14, 329);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(269, 50);
            this.btn_inserir.TabIndex = 8;
            this.btn_inserir.Text = "INSERIR";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_valor_unit
            // 
            this.txt_valor_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_unit.Location = new System.Drawing.Point(14, 278);
            this.txt_valor_unit.Name = "txt_valor_unit";
            this.txt_valor_unit.Size = new System.Drawing.Size(269, 32);
            this.txt_valor_unit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "VALOR UNIT:";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(14, 199);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(269, 32);
            this.txt_quantidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTIDADE:";
            // 
            // txt_produto
            // 
            this.txt_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(14, 122);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(269, 32);
            this.txt_produto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUTO:";
            // 
            // txt_id_venda
            // 
            this.txt_id_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_venda.Location = new System.Drawing.Point(14, 44);
            this.txt_id_venda.Name = "txt_id_venda";
            this.txt_id_venda.Size = new System.Drawing.Size(269, 32);
            this.txt_id_venda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_titulo);
            this.panel3.Location = new System.Drawing.Point(9, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 68);
            this.panel3.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Yu Gothic UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(-7, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(309, 59);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Supermercado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(124)))));
            this.panel2.Controls.Add(this.lbl_nota);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_qnt_alterar);
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.btn_nova_venda);
            this.panel2.Controls.Add(this.btn_cancelar_venda);
            this.panel2.Controls.Add(this.btn_alterar);
            this.panel2.Controls.Add(this.dgv_venda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(312, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 550);
            this.panel2.TabIndex = 1;
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Font = new System.Drawing.Font("Yu Gothic UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota.ForeColor = System.Drawing.Color.Black;
            this.lbl_nota.Location = new System.Drawing.Point(70, 487);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(334, 51);
            this.lbl_nota.TabIndex = 1;
            this.lbl_nota.Text = "0 ITENS | R$ 00,00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txt_qnt_alterar
            // 
            this.txt_qnt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qnt_alterar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_qnt_alterar.Location = new System.Drawing.Point(10, 446);
            this.txt_qnt_alterar.Name = "txt_qnt_alterar";
            this.txt_qnt_alterar.Size = new System.Drawing.Size(666, 26);
            this.txt_qnt_alterar.TabIndex = 10;
            this.txt_qnt_alterar.Text = "QUANTIDADE DE ITEM SELECIONADO...\r\n";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(241)))), ((int)(((byte)(206)))));
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(530, 401);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 39);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_nova_venda
            // 
            this.btn_nova_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(241)))), ((int)(((byte)(206)))));
            this.btn_nova_venda.FlatAppearance.BorderSize = 0;
            this.btn_nova_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nova_venda.Location = new System.Drawing.Point(314, 401);
            this.btn_nova_venda.Name = "btn_nova_venda";
            this.btn_nova_venda.Size = new System.Drawing.Size(146, 39);
            this.btn_nova_venda.TabIndex = 3;
            this.btn_nova_venda.Text = "NOVA VENDA";
            this.btn_nova_venda.UseVisualStyleBackColor = false;
            this.btn_nova_venda.Click += new System.EventHandler(this.btn_nova_venda_Click);
            // 
            // btn_cancelar_venda
            // 
            this.btn_cancelar_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(241)))), ((int)(((byte)(206)))));
            this.btn_cancelar_venda.FlatAppearance.BorderSize = 0;
            this.btn_cancelar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_venda.Location = new System.Drawing.Point(162, 401);
            this.btn_cancelar_venda.Name = "btn_cancelar_venda";
            this.btn_cancelar_venda.Size = new System.Drawing.Size(146, 39);
            this.btn_cancelar_venda.TabIndex = 2;
            this.btn_cancelar_venda.Text = "CANCELAR VENDA";
            this.btn_cancelar_venda.UseVisualStyleBackColor = false;
            this.btn_cancelar_venda.Click += new System.EventHandler(this.btn_cancelar_venda_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(241)))), ((int)(((byte)(206)))));
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Location = new System.Drawing.Point(10, 401);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(146, 39);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // dgv_venda
            // 
            this.dgv_venda.AllowUserToAddRows = false;
            this.dgv_venda.AllowUserToDeleteRows = false;
            this.dgv_venda.AllowUserToOrderColumns = true;
            this.dgv_venda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(189)))), ((int)(((byte)(167)))));
            this.dgv_venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmn_id,
            this.cmn_produto,
            this.cmn_valor_unit,
            this.cmn_quantidade});
            this.dgv_venda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgv_venda.Location = new System.Drawing.Point(10, 12);
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.ReadOnly = true;
            this.dgv_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_venda.Size = new System.Drawing.Size(666, 383);
            this.dgv_venda.TabIndex = 0;
            this.dgv_venda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_venda_CellClick);
            // 
            // cmn_id
            // 
            this.cmn_id.HeaderText = "ID";
            this.cmn_id.Name = "cmn_id";
            this.cmn_id.ReadOnly = true;
            this.cmn_id.Width = 40;
            // 
            // cmn_produto
            // 
            this.cmn_produto.HeaderText = "PRODUTO";
            this.cmn_produto.Name = "cmn_produto";
            this.cmn_produto.ReadOnly = true;
            this.cmn_produto.Width = 300;
            // 
            // cmn_valor_unit
            // 
            this.cmn_valor_unit.HeaderText = "V. UNITÁRIO";
            this.cmn_valor_unit.Name = "cmn_valor_unit";
            this.cmn_valor_unit.ReadOnly = true;
            this.cmn_valor_unit.Width = 150;
            // 
            // cmn_quantidade
            // 
            this.cmn_quantidade.HeaderText = "QUANTIDADE";
            this.cmn_quantidade.Name = "cmn_quantidade";
            this.cmn_quantidade.ReadOnly = true;
            this.cmn_quantidade.Width = 132;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(189)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_venda;
        private System.Windows.Forms.TextBox txt_valor_unit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.TextBox txt_qnt_alterar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_nova_venda;
        private System.Windows.Forms.Button btn_cancelar_venda;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn_valor_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmn_quantidade;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

