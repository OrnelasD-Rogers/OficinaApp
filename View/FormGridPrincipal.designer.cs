


namespace View
{
    partial class FormGridPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            this.dgHome = new System.Windows.Forms.DataGridView();
            this.IdAparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNotificacaoNap = new FontAwesome.Sharp.IconButton();
            this.btnNotificacaoAprovado = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Pesquisa.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pesquisa.Location = new System.Drawing.Point(35, 89);
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(957, 29);
            this.tb_Pesquisa.TabIndex = 1;
            this.tb_Pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pesquisa_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.White;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 35;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(998, 93);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(44, 29);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnVoltar.IconColor = System.Drawing.Color.White;
            this.btnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoltar.IconSize = 35;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(1048, 93);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(44, 29);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // dgHome
            // 
            this.dgHome.AllowUserToAddRows = false;
            this.dgHome.AllowUserToDeleteRows = false;
            this.dgHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.dgHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAparelho,
            this.Entrada,
            this.Nome,
            this.Numero,
            this.Tipo,
            this.Marca,
            this.Modelo,
            this.Problema,
            this.Cor,
            this.Estado,
            this.Saida,
            this.Revisao,
            this.Urgencia});
            this.dgHome.Location = new System.Drawing.Point(35, 128);
            this.dgHome.MultiSelect = false;
            this.dgHome.Name = "dgHome";
            this.dgHome.ReadOnly = true;
            this.dgHome.RowHeadersVisible = false;
            this.dgHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHome.Size = new System.Drawing.Size(1067, 461);
            this.dgHome.TabIndex = 20;
            this.dgHome.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHome_CellDoubleClick);
            this.dgHome.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgHome_CellFormatting);
            this.dgHome.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHome_ColumnHeaderMouseClick);
            this.dgHome.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgHome_RowPrePaint);
            // 
            // IdAparelho
            // 
            this.IdAparelho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdAparelho.DataPropertyName = "IdAparelho";
            this.IdAparelho.HeaderText = "ID Ap";
            this.IdAparelho.Name = "IdAparelho";
            this.IdAparelho.ReadOnly = true;
            this.IdAparelho.Width = 59;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Problema
            // 
            this.Problema.DataPropertyName = "Problema";
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Status";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "Saida";
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            // 
            // Revisao
            // 
            this.Revisao.DataPropertyName = "Revisao";
            this.Revisao.HeaderText = "Revisao";
            this.Revisao.Name = "Revisao";
            this.Revisao.ReadOnly = true;
            this.Revisao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Revisao.Visible = false;
            // 
            // Urgencia
            // 
            this.Urgencia.DataPropertyName = "Urgencia";
            this.Urgencia.HeaderText = "Urgencia";
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.ReadOnly = true;
            this.Urgencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Urgencia.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnNotificacaoNap
            // 
            this.btnNotificacaoNap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotificacaoNap.FlatAppearance.BorderSize = 0;
            this.btnNotificacaoNap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacaoNap.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacaoNap.ForeColor = System.Drawing.Color.White;
            this.btnNotificacaoNap.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotificacaoNap.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNotificacaoNap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotificacaoNap.IconSize = 33;
            this.btnNotificacaoNap.Location = new System.Drawing.Point(1048, 3);
            this.btnNotificacaoNap.Name = "btnNotificacaoNap";
            this.btnNotificacaoNap.Size = new System.Drawing.Size(93, 37);
            this.btnNotificacaoNap.TabIndex = 22;
            this.btnNotificacaoNap.Text = "12";
            this.btnNotificacaoNap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNotificacaoNap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNotificacaoNap, "Aparelhos NAP a mais de 20 dias");
            this.btnNotificacaoNap.UseVisualStyleBackColor = true;
            this.btnNotificacaoNap.Click += new System.EventHandler(this.btnNotificacaoNap_Click);
            // 
            // btnNotificacaoAprovado
            // 
            this.btnNotificacaoAprovado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNotificacaoAprovado.FlatAppearance.BorderSize = 0;
            this.btnNotificacaoAprovado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacaoAprovado.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacaoAprovado.ForeColor = System.Drawing.Color.White;
            this.btnNotificacaoAprovado.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotificacaoAprovado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNotificacaoAprovado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotificacaoAprovado.IconSize = 33;
            this.btnNotificacaoAprovado.Location = new System.Drawing.Point(949, 3);
            this.btnNotificacaoAprovado.Name = "btnNotificacaoAprovado";
            this.btnNotificacaoAprovado.Size = new System.Drawing.Size(93, 37);
            this.btnNotificacaoAprovado.TabIndex = 21;
            this.btnNotificacaoAprovado.Text = "12";
            this.btnNotificacaoAprovado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNotificacaoAprovado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNotificacaoAprovado, "Aparelhos Aprovados a mais de 20 dias");
            this.btnNotificacaoAprovado.UseVisualStyleBackColor = true;
            this.btnNotificacaoAprovado.Click += new System.EventHandler(this.btnNotificacaoAprovado_Click);
            // 
            // FormGridPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1141, 611);
            this.Controls.Add(this.btnNotificacaoNap);
            this.Controls.Add(this.btnNotificacaoAprovado);
            this.Controls.Add(this.dgHome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tb_Pesquisa);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGridPrincipal";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private System.Windows.Forms.DataGridView dgHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnNotificacaoNap;
        private FontAwesome.Sharp.IconButton btnNotificacaoAprovado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

