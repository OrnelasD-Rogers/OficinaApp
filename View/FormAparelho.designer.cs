
namespace View
{
    partial class FormAparelho
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
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.pnItens = new System.Windows.Forms.Panel();
            this.pnPagamento = new System.Windows.Forms.Panel();
            this.btnEditarItens = new FontAwesome.Sharp.IconButton();
            this.btnSaidaAp = new FontAwesome.Sharp.IconButton();
            this.btnAdiantamento = new FontAwesome.Sharp.IconButton();
            this.btnAddItens = new FontAwesome.Sharp.IconButton();
            this.lvItens = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAparelho = new System.Windows.Forms.GroupBox();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.chbUrgencia = new System.Windows.Forms.CheckBox();
            this.chbRevisao = new System.Windows.Forms.CheckBox();
            this.lblIdAp = new System.Windows.Forms.Label();
            this.lblOrc = new System.Windows.Forms.Label();
            this.tbOrc = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.lblProblema = new System.Windows.Forms.Label();
            this.tbProblema = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.btnAddContato = new FontAwesome.Sharp.IconButton();
            this.dgContatos = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dialogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contatante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwPadrao = new System.ComponentModel.BackgroundWorker();
            this.tabAparelhoInfos = new System.Windows.Forms.TabControl();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.btnEditarContato = new FontAwesome.Sharp.IconButton();
            this.tabAparelhos = new System.Windows.Forms.TabPage();
            this.dgHome = new System.Windows.Forms.DataGridView();
            this.IdAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwTabContatos = new System.ComponentModel.BackgroundWorker();
            this.bgwTabAparelhos = new System.ComponentModel.BackgroundWorker();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.panelTitleBar.SuspendLayout();
            this.pnItens.SuspendLayout();
            this.pnPagamento.SuspendLayout();
            this.gbAparelho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContatos)).BeginInit();
            this.tabAparelhoInfos.SuspendLayout();
            this.tabContatos.SuspendLayout();
            this.tabAparelhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.panelTitleBar.Controls.Add(this.btn_Minimize);
            this.panelTitleBar.Controls.Add(this.btn_Close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1289, 48);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 30;
            this.btn_Minimize.Location = new System.Drawing.Point(1192, 5);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_Minimize.Size = new System.Drawing.Size(41, 35);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
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
            this.btn_Close.IconSize = 40;
            this.btn_Close.Location = new System.Drawing.Point(1237, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btn_Close.Size = new System.Drawing.Size(41, 35);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 35;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(742, 198);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(103, 50);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditarObs_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSalvar.IconColor = System.Drawing.Color.White;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 35;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(742, 246);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(103, 50);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnItens
            // 
            this.pnItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            this.pnItens.Controls.Add(this.pnPagamento);
            this.pnItens.Controls.Add(this.lvItens);
            this.pnItens.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnItens.Location = new System.Drawing.Point(867, 52);
            this.pnItens.Margin = new System.Windows.Forms.Padding(2);
            this.pnItens.Name = "pnItens";
            this.pnItens.Size = new System.Drawing.Size(417, 609);
            this.pnItens.TabIndex = 50;
            // 
            // pnPagamento
            // 
            this.pnPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPagamento.Controls.Add(this.btnEditarItens);
            this.pnPagamento.Controls.Add(this.btnSaidaAp);
            this.pnPagamento.Controls.Add(this.btnAdiantamento);
            this.pnPagamento.Controls.Add(this.btnAddItens);
            this.pnPagamento.Location = new System.Drawing.Point(11, 289);
            this.pnPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.pnPagamento.Name = "pnPagamento";
            this.pnPagamento.Size = new System.Drawing.Size(395, 312);
            this.pnPagamento.TabIndex = 50;
            // 
            // btnEditarItens
            // 
            this.btnEditarItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarItens.Enabled = false;
            this.btnEditarItens.FlatAppearance.BorderSize = 0;
            this.btnEditarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarItens.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItens.ForeColor = System.Drawing.Color.White;
            this.btnEditarItens.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditarItens.IconColor = System.Drawing.Color.White;
            this.btnEditarItens.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarItens.IconSize = 35;
            this.btnEditarItens.Location = new System.Drawing.Point(261, 2);
            this.btnEditarItens.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarItens.Name = "btnEditarItens";
            this.btnEditarItens.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnEditarItens.Size = new System.Drawing.Size(129, 55);
            this.btnEditarItens.TabIndex = 47;
            this.btnEditarItens.Text = "Editar Itens";
            this.btnEditarItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarItens.UseVisualStyleBackColor = true;
            this.btnEditarItens.Click += new System.EventHandler(this.btnEditarItens_Click);
            // 
            // btnSaidaAp
            // 
            this.btnSaidaAp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaidaAp.Enabled = false;
            this.btnSaidaAp.FlatAppearance.BorderSize = 0;
            this.btnSaidaAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaidaAp.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidaAp.ForeColor = System.Drawing.Color.White;
            this.btnSaidaAp.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSaidaAp.IconColor = System.Drawing.Color.White;
            this.btnSaidaAp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaidaAp.IconSize = 35;
            this.btnSaidaAp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaidaAp.Location = new System.Drawing.Point(261, 257);
            this.btnSaidaAp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaidaAp.Name = "btnSaidaAp";
            this.btnSaidaAp.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSaidaAp.Size = new System.Drawing.Size(132, 53);
            this.btnSaidaAp.TabIndex = 45;
            this.btnSaidaAp.Text = "Dar Saída";
            this.btnSaidaAp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaidaAp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaidaAp.UseVisualStyleBackColor = true;
            this.btnSaidaAp.Click += new System.EventHandler(this.btnSaidaAp_Click);
            // 
            // btnAdiantamento
            // 
            this.btnAdiantamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdiantamento.Enabled = false;
            this.btnAdiantamento.FlatAppearance.BorderSize = 0;
            this.btnAdiantamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdiantamento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiantamento.ForeColor = System.Drawing.Color.White;
            this.btnAdiantamento.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnAdiantamento.IconColor = System.Drawing.Color.White;
            this.btnAdiantamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdiantamento.IconSize = 35;
            this.btnAdiantamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdiantamento.Location = new System.Drawing.Point(2, 257);
            this.btnAdiantamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdiantamento.Name = "btnAdiantamento";
            this.btnAdiantamento.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAdiantamento.Size = new System.Drawing.Size(132, 53);
            this.btnAdiantamento.TabIndex = 48;
            this.btnAdiantamento.Text = "Pagamento Adiantado";
            this.btnAdiantamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdiantamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdiantamento.UseVisualStyleBackColor = true;
            this.btnAdiantamento.Click += new System.EventHandler(this.btnAdiantamento_Click);
            // 
            // btnAddItens
            // 
            this.btnAddItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItens.Enabled = false;
            this.btnAddItens.FlatAppearance.BorderSize = 0;
            this.btnAddItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItens.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItens.ForeColor = System.Drawing.Color.White;
            this.btnAddItens.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddItens.IconColor = System.Drawing.Color.White;
            this.btnAddItens.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItens.IconSize = 35;
            this.btnAddItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItens.Location = new System.Drawing.Point(5, 2);
            this.btnAddItens.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItens.Name = "btnAddItens";
            this.btnAddItens.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAddItens.Size = new System.Drawing.Size(129, 55);
            this.btnAddItens.TabIndex = 46;
            this.btnAddItens.Text = "Adicionar Itens";
            this.btnAddItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItens.UseVisualStyleBackColor = true;
            this.btnAddItens.Click += new System.EventHandler(this.btnAddItens_Click);
            // 
            // lvItens
            // 
            this.lvItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.ValorUn,
            this.Quantidade,
            this.SubTotal});
            this.lvItens.HideSelection = false;
            this.lvItens.Location = new System.Drawing.Point(11, 15);
            this.lvItens.Margin = new System.Windows.Forms.Padding(2);
            this.lvItens.Name = "lvItens";
            this.lvItens.Size = new System.Drawing.Size(395, 262);
            this.lvItens.TabIndex = 49;
            this.lvItens.UseCompatibleStateImageBehavior = false;
            this.lvItens.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 166;
            // 
            // ValorUn
            // 
            this.ValorUn.Text = "Valor Un.";
            this.ValorUn.Width = 92;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Qtd.";
            this.Quantidade.Width = 51;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "SubTotal";
            this.SubTotal.Width = 76;
            // 
            // gbAparelho
            // 
            this.gbAparelho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAparelho.Controls.Add(this.dtpDataEntrada);
            this.gbAparelho.Controls.Add(this.cbTecnico);
            this.gbAparelho.Controls.Add(this.chbUrgencia);
            this.gbAparelho.Controls.Add(this.chbRevisao);
            this.gbAparelho.Controls.Add(this.lblIdAp);
            this.gbAparelho.Controls.Add(this.btnSalvar);
            this.gbAparelho.Controls.Add(this.lblOrc);
            this.gbAparelho.Controls.Add(this.btnEditar);
            this.gbAparelho.Controls.Add(this.tbOrc);
            this.gbAparelho.Controls.Add(this.lblCor);
            this.gbAparelho.Controls.Add(this.tbCor);
            this.gbAparelho.Controls.Add(this.lblEstado);
            this.gbAparelho.Controls.Add(this.tbEstado);
            this.gbAparelho.Controls.Add(this.lblTecnico);
            this.gbAparelho.Controls.Add(this.lblCli);
            this.gbAparelho.Controls.Add(this.lblObs);
            this.gbAparelho.Controls.Add(this.tbObservacao);
            this.gbAparelho.Controls.Add(this.lblProblema);
            this.gbAparelho.Controls.Add(this.tbProblema);
            this.gbAparelho.Controls.Add(this.lblModelo);
            this.gbAparelho.Controls.Add(this.tbModelo);
            this.gbAparelho.Controls.Add(this.lblMarca);
            this.gbAparelho.Controls.Add(this.tbMarca);
            this.gbAparelho.Controls.Add(this.lblTipo);
            this.gbAparelho.Controls.Add(this.tbTipo);
            this.gbAparelho.Controls.Add(this.lblEntrada);
            this.gbAparelho.Controls.Add(this.lblSaida);
            this.gbAparelho.Controls.Add(this.tbSaida);
            this.gbAparelho.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAparelho.Location = new System.Drawing.Point(4, 56);
            this.gbAparelho.Margin = new System.Windows.Forms.Padding(2);
            this.gbAparelho.Name = "gbAparelho";
            this.gbAparelho.Padding = new System.Windows.Forms.Padding(2);
            this.gbAparelho.Size = new System.Drawing.Size(859, 310);
            this.gbAparelho.TabIndex = 51;
            this.gbAparelho.TabStop = false;
            this.gbAparelho.Text = "Dados do Aparelho";
            // 
            // cbTecnico
            // 
            this.cbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnico.Enabled = false;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(564, 87);
            this.cbTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(168, 29);
            this.cbTecnico.TabIndex = 78;
            // 
            // chbUrgencia
            // 
            this.chbUrgencia.AutoSize = true;
            this.chbUrgencia.Enabled = false;
            this.chbUrgencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbUrgencia.Location = new System.Drawing.Point(748, 59);
            this.chbUrgencia.Margin = new System.Windows.Forms.Padding(2);
            this.chbUrgencia.Name = "chbUrgencia";
            this.chbUrgencia.Size = new System.Drawing.Size(97, 26);
            this.chbUrgencia.TabIndex = 77;
            this.chbUrgencia.Text = "Urgência";
            this.chbUrgencia.UseVisualStyleBackColor = true;
            this.chbUrgencia.CheckedChanged += new System.EventHandler(this.chbUrgencia_CheckedChanged_1);
            this.chbUrgencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbUrgencia_MouseClick);
            // 
            // chbRevisao
            // 
            this.chbRevisao.AutoSize = true;
            this.chbRevisao.Enabled = false;
            this.chbRevisao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbRevisao.Location = new System.Drawing.Point(748, 23);
            this.chbRevisao.Margin = new System.Windows.Forms.Padding(2);
            this.chbRevisao.Name = "chbRevisao";
            this.chbRevisao.Size = new System.Drawing.Size(89, 26);
            this.chbRevisao.TabIndex = 76;
            this.chbRevisao.Text = "Revisão";
            this.chbRevisao.UseVisualStyleBackColor = true;
            this.chbRevisao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbRevisao_MouseClick);
            // 
            // lblIdAp
            // 
            this.lblIdAp.AutoSize = true;
            this.lblIdAp.ForeColor = System.Drawing.Color.White;
            this.lblIdAp.Location = new System.Drawing.Point(17, 28);
            this.lblIdAp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdAp.Name = "lblIdAp";
            this.lblIdAp.Size = new System.Drawing.Size(75, 21);
            this.lblIdAp.TabIndex = 70;
            this.lblIdAp.Text = "Id Cliente";
            this.lblIdAp.Click += new System.EventHandler(this.lblIdAp_Click);
            // 
            // lblOrc
            // 
            this.lblOrc.AutoSize = true;
            this.lblOrc.Location = new System.Drawing.Point(265, 182);
            this.lblOrc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrc.Name = "lblOrc";
            this.lblOrc.Size = new System.Drawing.Size(88, 21);
            this.lblOrc.TabIndex = 69;
            this.lblOrc.Text = "Orçamento";
            // 
            // tbOrc
            // 
            this.tbOrc.Location = new System.Drawing.Point(269, 205);
            this.tbOrc.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrc.Multiline = true;
            this.tbOrc.Name = "tbOrc";
            this.tbOrc.ReadOnly = true;
            this.tbOrc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOrc.Size = new System.Drawing.Size(215, 80);
            this.tbOrc.TabIndex = 68;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(561, 118);
            this.lblCor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(35, 21);
            this.lblCor.TabIndex = 67;
            this.lblCor.Text = "Cor";
            // 
            // tbCor
            // 
            this.tbCor.Location = new System.Drawing.Point(564, 141);
            this.tbCor.Margin = new System.Windows.Forms.Padding(2);
            this.tbCor.Name = "tbCor";
            this.tbCor.ReadOnly = true;
            this.tbCor.Size = new System.Drawing.Size(168, 29);
            this.tbCor.TabIndex = 66;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(379, 64);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 21);
            this.lblEstado.TabIndex = 65;
            this.lblEstado.Text = "Status";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(383, 87);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.ReadOnly = true;
            this.tbEstado.Size = new System.Drawing.Size(168, 29);
            this.tbEstado.TabIndex = 64;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(561, 64);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(62, 21);
            this.lblTecnico.TabIndex = 63;
            this.lblTecnico.Text = "Técnico";
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCli.ForeColor = System.Drawing.Color.White;
            this.lblCli.Location = new System.Drawing.Point(143, 28);
            this.lblCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(58, 21);
            this.lblCli.TabIndex = 61;
            this.lblCli.Text = "Cliente";
            this.lblCli.Click += new System.EventHandler(this.lblCli_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(513, 182);
            this.lblObs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 21);
            this.lblObs.TabIndex = 60;
            this.lblObs.Text = "Observação";
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(517, 205);
            this.tbObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.ReadOnly = true;
            this.tbObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservacao.Size = new System.Drawing.Size(215, 80);
            this.tbObservacao.TabIndex = 59;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(17, 182);
            this.lblProblema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(77, 21);
            this.lblProblema.TabIndex = 58;
            this.lblProblema.Text = "Problema";
            // 
            // tbProblema
            // 
            this.tbProblema.Location = new System.Drawing.Point(21, 205);
            this.tbProblema.Margin = new System.Windows.Forms.Padding(2);
            this.tbProblema.Multiline = true;
            this.tbProblema.Name = "tbProblema";
            this.tbProblema.ReadOnly = true;
            this.tbProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProblema.Size = new System.Drawing.Size(215, 80);
            this.tbProblema.TabIndex = 57;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(379, 118);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(63, 21);
            this.lblModelo.TabIndex = 56;
            this.lblModelo.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(383, 141);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.ReadOnly = true;
            this.tbModelo.Size = new System.Drawing.Size(168, 29);
            this.tbModelo.TabIndex = 55;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(198, 118);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 21);
            this.lblMarca.TabIndex = 54;
            this.lblMarca.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(202, 141);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(168, 29);
            this.tbMarca.TabIndex = 53;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 118);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 52;
            this.lblTipo.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(21, 141);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.ReadOnly = true;
            this.tbTipo.Size = new System.Drawing.Size(168, 29);
            this.tbTipo.TabIndex = 51;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(17, 64);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(63, 21);
            this.lblEntrada.TabIndex = 50;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(198, 64);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(48, 21);
            this.lblSaida.TabIndex = 48;
            this.lblSaida.Text = "Saida";
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(202, 87);
            this.tbSaida.Margin = new System.Windows.Forms.Padding(2);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.ReadOnly = true;
            this.tbSaida.Size = new System.Drawing.Size(168, 29);
            this.tbSaida.TabIndex = 47;
            // 
            // btnAddContato
            // 
            this.btnAddContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContato.Enabled = false;
            this.btnAddContato.FlatAppearance.BorderSize = 0;
            this.btnAddContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContato.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContato.ForeColor = System.Drawing.Color.Black;
            this.btnAddContato.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddContato.IconColor = System.Drawing.Color.Lime;
            this.btnAddContato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddContato.IconSize = 35;
            this.btnAddContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContato.Location = new System.Drawing.Point(649, 201);
            this.btnAddContato.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAddContato.Size = new System.Drawing.Size(191, 43);
            this.btnAddContato.TabIndex = 33;
            this.btnAddContato.Text = "Adicionar Contato";
            this.btnAddContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddContato.UseVisualStyleBackColor = true;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // dgContatos
            // 
            this.dgContatos.AllowUserToAddRows = false;
            this.dgContatos.AllowUserToDeleteRows = false;
            this.dgContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Numero,
            this.Tipo,
            this.StatusAtendimento,
            this.Dialogo,
            this.Contatante,
            this.Status});
            this.dgContatos.Location = new System.Drawing.Point(2, 4);
            this.dgContatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgContatos.Name = "dgContatos";
            this.dgContatos.ReadOnly = true;
            this.dgContatos.RowHeadersVisible = false;
            this.dgContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContatos.Size = new System.Drawing.Size(838, 178);
            this.dgContatos.TabIndex = 32;
            this.dgContatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgContatos_CellFormatting);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataContato";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 95;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 95;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // StatusAtendimento
            // 
            this.StatusAtendimento.DataPropertyName = "StatusLig";
            this.StatusAtendimento.HeaderText = "Status Atendimento";
            this.StatusAtendimento.Name = "StatusAtendimento";
            this.StatusAtendimento.ReadOnly = true;
            // 
            // Dialogo
            // 
            this.Dialogo.DataPropertyName = "Dialogo";
            this.Dialogo.HeaderText = "Dialogo";
            this.Dialogo.Name = "Dialogo";
            this.Dialogo.ReadOnly = true;
            this.Dialogo.Width = 240;
            // 
            // Contatante
            // 
            this.Contatante.DataPropertyName = "NomeTecnico";
            this.Contatante.HeaderText = "Contatante";
            this.Contatante.Name = "Contatante";
            this.Contatante.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Estado";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 95;
            // 
            // bgwPadrao
            // 
            this.bgwPadrao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPadrao_DoWork);
            this.bgwPadrao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwPadrao_RunWorkerCompleted);
            // 
            // tabAparelhoInfos
            // 
            this.tabAparelhoInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAparelhoInfos.Controls.Add(this.tabContatos);
            this.tabAparelhoInfos.Controls.Add(this.tabAparelhos);
            this.tabAparelhoInfos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAparelhoInfos.Location = new System.Drawing.Point(11, 379);
            this.tabAparelhoInfos.Margin = new System.Windows.Forms.Padding(2);
            this.tabAparelhoInfos.Name = "tabAparelhoInfos";
            this.tabAparelhoInfos.SelectedIndex = 0;
            this.tabAparelhoInfos.Size = new System.Drawing.Size(852, 282);
            this.tabAparelhoInfos.TabIndex = 34;
            this.tabAparelhoInfos.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabAparelhoInfos_Selected);
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.btnEditarContato);
            this.tabContatos.Controls.Add(this.btnAddContato);
            this.tabContatos.Controls.Add(this.dgContatos);
            this.tabContatos.Location = new System.Drawing.Point(4, 30);
            this.tabContatos.Margin = new System.Windows.Forms.Padding(2);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(2);
            this.tabContatos.Size = new System.Drawing.Size(844, 248);
            this.tabContatos.TabIndex = 0;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarContato.Enabled = false;
            this.btnEditarContato.FlatAppearance.BorderSize = 0;
            this.btnEditarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarContato.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContato.ForeColor = System.Drawing.Color.Black;
            this.btnEditarContato.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarContato.IconColor = System.Drawing.Color.DimGray;
            this.btnEditarContato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarContato.IconSize = 35;
            this.btnEditarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarContato.Location = new System.Drawing.Point(454, 201);
            this.btnEditarContato.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnEditarContato.Size = new System.Drawing.Size(191, 43);
            this.btnEditarContato.TabIndex = 34;
            this.btnEditarContato.Text = "Editar Contato";
            this.btnEditarContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // tabAparelhos
            // 
            this.tabAparelhos.Controls.Add(this.dgHome);
            this.tabAparelhos.Location = new System.Drawing.Point(4, 30);
            this.tabAparelhos.Margin = new System.Windows.Forms.Padding(2);
            this.tabAparelhos.Name = "tabAparelhos";
            this.tabAparelhos.Padding = new System.Windows.Forms.Padding(2);
            this.tabAparelhos.Size = new System.Drawing.Size(844, 248);
            this.tabAparelhos.TabIndex = 1;
            this.tabAparelhos.Text = "Aparelhos";
            this.tabAparelhos.UseVisualStyleBackColor = true;
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
            this.IdAp,
            this.Entrada,
            this.dataGridViewTextBoxColumn2,
            this.Marca,
            this.Modelo,
            this.Problema,
            this.Cor,
            this.Estado,
            this.Saida,
            this.Revisao,
            this.Urgencia});
            this.dgHome.Location = new System.Drawing.Point(0, 4);
            this.dgHome.Margin = new System.Windows.Forms.Padding(2);
            this.dgHome.MultiSelect = false;
            this.dgHome.Name = "dgHome";
            this.dgHome.ReadOnly = true;
            this.dgHome.RowHeadersVisible = false;
            this.dgHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHome.Size = new System.Drawing.Size(842, 220);
            this.dgHome.TabIndex = 21;
            this.dgHome.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHome_CellDoubleClick);
            this.dgHome.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgHome_RowPrePaint);
            // 
            // IdAp
            // 
            this.IdAp.DataPropertyName = "IdAparelho";
            this.IdAp.HeaderText = "Id Aparelho";
            this.IdAp.Name = "IdAp";
            this.IdAp.ReadOnly = true;
            this.IdAp.Width = 80;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 90;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 95;
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
            this.Estado.Width = 95;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "Saida";
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            this.Saida.Width = 90;
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
            // bgwTabContatos
            // 
            this.bgwTabContatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTabContatos_DoWork);
            this.bgwTabContatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTabContatos_RunWorkerCompleted);
            // 
            // bgwTabAparelhos
            // 
            this.bgwTabAparelhos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTabAparelhos_DoWork);
            this.bgwTabAparelhos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTabAparelhos_RunWorkerCompleted);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Enabled = false;
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(21, 86);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(168, 29);
            this.dtpDataEntrada.TabIndex = 79;
            // 
            // FormAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1289, 674);
            this.Controls.Add(this.tabAparelhoInfos);
            this.Controls.Add(this.gbAparelho);
            this.Controls.Add(this.pnItens);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAparelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAparelho";
            this.panelTitleBar.ResumeLayout(false);
            this.pnItens.ResumeLayout(false);
            this.pnPagamento.ResumeLayout(false);
            this.gbAparelho.ResumeLayout(false);
            this.gbAparelho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContatos)).EndInit();
            this.tabAparelhoInfos.ResumeLayout(false);
            this.tabContatos.ResumeLayout(false);
            this.tabAparelhos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btn_Close;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.ListView lvItens;
        private System.Windows.Forms.GroupBox gbAparelho;
        private System.Windows.Forms.Label lblIdAp;
        private System.Windows.Forms.Label lblOrc;
        private System.Windows.Forms.TextBox tbOrc;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox tbProblema;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.TextBox tbSaida;
        private FontAwesome.Sharp.IconButton btnAddContato;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader ValorUn;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.ComponentModel.BackgroundWorker bgwPadrao;
        private System.Windows.Forms.CheckBox chbUrgencia;
        private System.Windows.Forms.CheckBox chbRevisao;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.TabControl tabAparelhoInfos;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.TabPage tabAparelhos;
        private System.Windows.Forms.DataGridView dgHome;
        private System.ComponentModel.BackgroundWorker bgwTabContatos;
        private System.ComponentModel.BackgroundWorker bgwTabAparelhos;
        private System.Windows.Forms.ErrorProvider ep;
        private FontAwesome.Sharp.IconButton btnEditarContato;
        public System.Windows.Forms.DataGridView dgContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dialogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contatante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel pnPagamento;
        private FontAwesome.Sharp.IconButton btnEditarItens;
        private FontAwesome.Sharp.IconButton btnSaidaAp;
        private FontAwesome.Sharp.IconButton btnAdiantamento;
        private FontAwesome.Sharp.IconButton btnAddItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        public System.Windows.Forms.Panel pnItens;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
    }
}