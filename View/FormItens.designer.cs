
namespace View
{
    partial class FormItens
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
            this.components = new System.ComponentModel.Container();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.btnEditarItem = new FontAwesome.Sharp.IconButton();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirItem = new FontAwesome.Sharp.IconButton();
            this.dgItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnAddItem = new System.Windows.Forms.Panel();
            this.btnFechaPnAddItem = new FontAwesome.Sharp.IconButton();
            this.btnAceitarQtd = new FontAwesome.Sharp.IconButton();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnAddMaoDeObra = new System.Windows.Forms.Panel();
            this.tbMaoDeObra = new System.Windows.Forms.TextBox();
            this.btnFechaPnAddMaoDeObra = new FontAwesome.Sharp.IconButton();
            this.btnAceitarMDO = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalvarLista = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            this.pnAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.pnAddMaoDeObra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.panelTitleBar.Controls.Add(this.btn_Close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(570, 36);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.White;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 35;
            this.btn_Close.Location = new System.Drawing.Point(541, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 8, 6, 0);
            this.btn_Close.Size = new System.Drawing.Size(25, 24);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarItem.FlatAppearance.BorderSize = 0;
            this.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarItem.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnEditarItem.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditarItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnEditarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarItem.IconSize = 35;
            this.btnEditarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarItem.Location = new System.Drawing.Point(490, 243);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEditarItem.Size = new System.Drawing.Size(44, 42);
            this.btnEditarItem.TabIndex = 50;
            this.btnEditarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEditarItem, "Edita o Item do Aparelho");
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Produto,
            this.Valor});
            this.dgProdutos.Location = new System.Drawing.Point(32, 83);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(502, 150);
            this.dgProdutos.TabIndex = 51;
            this.dgProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellDoubleClick);
            this.dgProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProdutos_CellFormatting);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.HeaderText = "Id Produto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 80;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 300;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorVenda";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirItem.FlatAppearance.BorderSize = 0;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnExcluirItem.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnExcluirItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnExcluirItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirItem.IconSize = 35;
            this.btnExcluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirItem.Location = new System.Drawing.Point(440, 243);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnExcluirItem.Size = new System.Drawing.Size(44, 42);
            this.btnExcluirItem.TabIndex = 52;
            this.btnExcluirItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnExcluirItem, "Exclui o Item do Aparelho");
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // dgItens
            // 
            this.dgItens.AllowUserToAddRows = false;
            this.dgItens.AllowUserToDeleteRows = false;
            this.dgItens.AllowUserToResizeRows = false;
            this.dgItens.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgItens.Location = new System.Drawing.Point(32, 287);
            this.dgItens.MultiSelect = false;
            this.dgItens.Name = "dgItens";
            this.dgItens.ReadOnly = true;
            this.dgItens.RowHeadersVisible = false;
            this.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItens.Size = new System.Drawing.Size(502, 150);
            this.dgItens.TabIndex = 53;
            this.dgItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgItens_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ValorVenda";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qtd.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Itens no Aparelho";
            // 
            // pnAddItem
            // 
            this.pnAddItem.BackColor = System.Drawing.Color.Gray;
            this.pnAddItem.Controls.Add(this.btnFechaPnAddItem);
            this.pnAddItem.Controls.Add(this.btnAceitarQtd);
            this.pnAddItem.Controls.Add(this.nudQtd);
            this.pnAddItem.Controls.Add(this.label3);
            this.pnAddItem.Location = new System.Drawing.Point(185, 178);
            this.pnAddItem.Name = "pnAddItem";
            this.pnAddItem.Size = new System.Drawing.Size(198, 107);
            this.pnAddItem.TabIndex = 56;
            this.pnAddItem.Visible = false;
            // 
            // btnFechaPnAddItem
            // 
            this.btnFechaPnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechaPnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechaPnAddItem.FlatAppearance.BorderSize = 0;
            this.btnFechaPnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaPnAddItem.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnFechaPnAddItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechaPnAddItem.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnFechaPnAddItem.IconColor = System.Drawing.Color.Red;
            this.btnFechaPnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaPnAddItem.IconSize = 35;
            this.btnFechaPnAddItem.Location = new System.Drawing.Point(169, 5);
            this.btnFechaPnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechaPnAddItem.Name = "btnFechaPnAddItem";
            this.btnFechaPnAddItem.Padding = new System.Windows.Forms.Padding(0, 8, 6, 0);
            this.btnFechaPnAddItem.Size = new System.Drawing.Size(25, 24);
            this.btnFechaPnAddItem.TabIndex = 58;
            this.btnFechaPnAddItem.UseVisualStyleBackColor = true;
            this.btnFechaPnAddItem.Click += new System.EventHandler(this.btnFechaPnAddItem_Click);
            // 
            // btnAceitarQtd
            // 
            this.btnAceitarQtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceitarQtd.FlatAppearance.BorderSize = 0;
            this.btnAceitarQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarQtd.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnAceitarQtd.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceitarQtd.IconColor = System.Drawing.Color.Lime;
            this.btnAceitarQtd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceitarQtd.IconSize = 30;
            this.btnAceitarQtd.Location = new System.Drawing.Point(145, 65);
            this.btnAceitarQtd.Name = "btnAceitarQtd";
            this.btnAceitarQtd.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAceitarQtd.Size = new System.Drawing.Size(44, 29);
            this.btnAceitarQtd.TabIndex = 57;
            this.btnAceitarQtd.UseVisualStyleBackColor = true;
            this.btnAceitarQtd.Click += new System.EventHandler(this.btnAceitarQTD_Click);
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(13, 65);
            this.nudQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(120, 29);
            this.nudQtd.TabIndex = 56;
            this.nudQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Selecione a Quantidade :";
            // 
            // pnAddMaoDeObra
            // 
            this.pnAddMaoDeObra.BackColor = System.Drawing.Color.Gray;
            this.pnAddMaoDeObra.Controls.Add(this.tbMaoDeObra);
            this.pnAddMaoDeObra.Controls.Add(this.btnFechaPnAddMaoDeObra);
            this.pnAddMaoDeObra.Controls.Add(this.btnAceitarMDO);
            this.pnAddMaoDeObra.Controls.Add(this.label4);
            this.pnAddMaoDeObra.Location = new System.Drawing.Point(185, 47);
            this.pnAddMaoDeObra.Name = "pnAddMaoDeObra";
            this.pnAddMaoDeObra.Size = new System.Drawing.Size(198, 107);
            this.pnAddMaoDeObra.TabIndex = 59;
            this.pnAddMaoDeObra.Visible = false;
            // 
            // tbMaoDeObra
            // 
            this.tbMaoDeObra.Location = new System.Drawing.Point(13, 66);
            this.tbMaoDeObra.Name = "tbMaoDeObra";
            this.tbMaoDeObra.Size = new System.Drawing.Size(120, 29);
            this.tbMaoDeObra.TabIndex = 59;
            this.tbMaoDeObra.Text = "R$ ";
            // 
            // btnFechaPnAddMaoDeObra
            // 
            this.btnFechaPnAddMaoDeObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechaPnAddMaoDeObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechaPnAddMaoDeObra.FlatAppearance.BorderSize = 0;
            this.btnFechaPnAddMaoDeObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaPnAddMaoDeObra.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnFechaPnAddMaoDeObra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechaPnAddMaoDeObra.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnFechaPnAddMaoDeObra.IconColor = System.Drawing.Color.Red;
            this.btnFechaPnAddMaoDeObra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaPnAddMaoDeObra.IconSize = 35;
            this.btnFechaPnAddMaoDeObra.Location = new System.Drawing.Point(169, 5);
            this.btnFechaPnAddMaoDeObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechaPnAddMaoDeObra.Name = "btnFechaPnAddMaoDeObra";
            this.btnFechaPnAddMaoDeObra.Padding = new System.Windows.Forms.Padding(0, 8, 6, 0);
            this.btnFechaPnAddMaoDeObra.Size = new System.Drawing.Size(25, 24);
            this.btnFechaPnAddMaoDeObra.TabIndex = 58;
            this.btnFechaPnAddMaoDeObra.UseVisualStyleBackColor = true;
            this.btnFechaPnAddMaoDeObra.Click += new System.EventHandler(this.btnFechaPnAddMaoDeObra_Click);
            // 
            // btnAceitarMDO
            // 
            this.btnAceitarMDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceitarMDO.FlatAppearance.BorderSize = 0;
            this.btnAceitarMDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarMDO.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarMDO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(141)))), ((int)(((byte)(73)))));
            this.btnAceitarMDO.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceitarMDO.IconColor = System.Drawing.Color.Lime;
            this.btnAceitarMDO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceitarMDO.IconSize = 30;
            this.btnAceitarMDO.Location = new System.Drawing.Point(145, 65);
            this.btnAceitarMDO.Name = "btnAceitarMDO";
            this.btnAceitarMDO.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAceitarMDO.Size = new System.Drawing.Size(44, 29);
            this.btnAceitarMDO.TabIndex = 57;
            this.btnAceitarMDO.UseVisualStyleBackColor = true;
            this.btnAceitarMDO.Click += new System.EventHandler(this.btnAceitarMDO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Valor da Mão de Obra :";
            // 
            // btnSalvarLista
            // 
            this.btnSalvarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarLista.FlatAppearance.BorderSize = 0;
            this.btnSalvarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLista.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLista.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarLista.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnSalvarLista.IconColor = System.Drawing.Color.DimGray;
            this.btnSalvarLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarLista.IconSize = 35;
            this.btnSalvarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarLista.Location = new System.Drawing.Point(195, 451);
            this.btnSalvarLista.Name = "btnSalvarLista";
            this.btnSalvarLista.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSalvarLista.Size = new System.Drawing.Size(179, 42);
            this.btnSalvarLista.TabIndex = 60;
            this.btnSalvarLista.Text = "Salvar Alterações";
            this.btnSalvarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalvarLista, "Exclui o Item do Aparelho");
            this.btnSalvarLista.UseVisualStyleBackColor = true;
            this.btnSalvarLista.Click += new System.EventHandler(this.btnSalvarLista_Click);
            // 
            // FormItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(190)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(570, 505);
            this.Controls.Add(this.btnSalvarLista);
            this.Controls.Add(this.pnAddMaoDeObra);
            this.Controls.Add(this.pnAddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgItens);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormItens";
            this.TopMost = true;
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            this.pnAddItem.ResumeLayout(false);
            this.pnAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.pnAddMaoDeObra.ResumeLayout(false);
            this.pnAddMaoDeObra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btn_Close;
        private FontAwesome.Sharp.IconButton btnEditarItem;
        private System.Windows.Forms.DataGridView dgProdutos;
        private FontAwesome.Sharp.IconButton btnExcluirItem;
        private System.Windows.Forms.DataGridView dgItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnAddItem;
        private FontAwesome.Sharp.IconButton btnAceitarQtd;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnFechaPnAddItem;
        private System.Windows.Forms.Panel pnAddMaoDeObra;
        private System.Windows.Forms.TextBox tbMaoDeObra;
        private FontAwesome.Sharp.IconButton btnFechaPnAddMaoDeObra;
        private FontAwesome.Sharp.IconButton btnAceitarMDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnSalvarLista;
    }
}