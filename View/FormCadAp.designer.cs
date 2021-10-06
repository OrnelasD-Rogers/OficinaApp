
namespace View
{
    partial class FormCadAp
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovaCor = new FontAwesome.Sharp.IconButton();
            this.pnAparelho = new System.Windows.Forms.Panel();
            this.gbNovaCor = new System.Windows.Forms.GroupBox();
            this.btnCancelaNovaCor = new FontAwesome.Sharp.IconButton();
            this.tbNovaCor = new System.Windows.Forms.TextBox();
            this.lblNovaCor = new System.Windows.Forms.Label();
            this.btnAddNovaCor = new FontAwesome.Sharp.IconButton();
            this.chbRevisao = new System.Windows.Forms.CheckBox();
            this.chbUrgencia = new System.Windows.Forms.CheckBox();
            this.lblCor2 = new System.Windows.Forms.Label();
            this.lblCor1 = new System.Windows.Forms.Label();
            this.cbCor2 = new System.Windows.Forms.ComboBox();
            this.cbCor1 = new System.Windows.Forms.ComboBox();
            this.btnLimpaCampos = new FontAwesome.Sharp.IconButton();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblProblema = new System.Windows.Forms.Label();
            this.tbProblema = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.pnIdCliente = new System.Windows.Forms.Panel();
            this.tbIdCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.btnLimpaCli = new FontAwesome.Sharp.IconButton();
            this.lblCli = new System.Windows.Forms.Label();
            this.tbCli = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgPesq = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnAparelho.SuspendLayout();
            this.gbNovaCor.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.pnIdCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnNovaCor
            // 
            this.btnNovaCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaCor.FlatAppearance.BorderSize = 0;
            this.btnNovaCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNovaCor.IconColor = System.Drawing.Color.White;
            this.btnNovaCor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovaCor.IconSize = 35;
            this.btnNovaCor.Location = new System.Drawing.Point(164, 127);
            this.btnNovaCor.Name = "btnNovaCor";
            this.btnNovaCor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNovaCor.Size = new System.Drawing.Size(38, 29);
            this.btnNovaCor.TabIndex = 67;
            this.toolTip.SetToolTip(this.btnNovaCor, "Adiciona Nova cor");
            this.btnNovaCor.UseVisualStyleBackColor = true;
            this.btnNovaCor.Click += new System.EventHandler(this.btnNovaCor_Click);
            // 
            // pnAparelho
            // 
            this.pnAparelho.Controls.Add(this.gbNovaCor);
            this.pnAparelho.Controls.Add(this.btnNovaCor);
            this.pnAparelho.Controls.Add(this.chbRevisao);
            this.pnAparelho.Controls.Add(this.chbUrgencia);
            this.pnAparelho.Controls.Add(this.lblCor2);
            this.pnAparelho.Controls.Add(this.lblCor1);
            this.pnAparelho.Controls.Add(this.cbCor2);
            this.pnAparelho.Controls.Add(this.cbCor1);
            this.pnAparelho.Controls.Add(this.btnLimpaCampos);
            this.pnAparelho.Controls.Add(this.btnCadastrar);
            this.pnAparelho.Controls.Add(this.lblTipo);
            this.pnAparelho.Controls.Add(this.cbTipo);
            this.pnAparelho.Controls.Add(this.lblModelo);
            this.pnAparelho.Controls.Add(this.cbModelo);
            this.pnAparelho.Controls.Add(this.lblMarca);
            this.pnAparelho.Controls.Add(this.cbMarca);
            this.pnAparelho.Controls.Add(this.lblEntrada);
            this.pnAparelho.Controls.Add(this.dtpEntrada);
            this.pnAparelho.Controls.Add(this.lblProblema);
            this.pnAparelho.Controls.Add(this.tbProblema);
            this.pnAparelho.Controls.Add(this.lblObs);
            this.pnAparelho.Controls.Add(this.tbObs);
            this.pnAparelho.Location = new System.Drawing.Point(12, 101);
            this.pnAparelho.Name = "pnAparelho";
            this.pnAparelho.Size = new System.Drawing.Size(955, 265);
            this.pnAparelho.TabIndex = 27;
            // 
            // gbNovaCor
            // 
            this.gbNovaCor.Controls.Add(this.btnCancelaNovaCor);
            this.gbNovaCor.Controls.Add(this.tbNovaCor);
            this.gbNovaCor.Controls.Add(this.lblNovaCor);
            this.gbNovaCor.Controls.Add(this.btnAddNovaCor);
            this.gbNovaCor.Location = new System.Drawing.Point(3, 3);
            this.gbNovaCor.Name = "gbNovaCor";
            this.gbNovaCor.Size = new System.Drawing.Size(187, 114);
            this.gbNovaCor.TabIndex = 68;
            this.gbNovaCor.TabStop = false;
            this.gbNovaCor.Visible = false;
            // 
            // btnCancelaNovaCor
            // 
            this.btnCancelaNovaCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaNovaCor.FlatAppearance.BorderSize = 0;
            this.btnCancelaNovaCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaNovaCor.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelaNovaCor.IconColor = System.Drawing.Color.White;
            this.btnCancelaNovaCor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelaNovaCor.IconSize = 35;
            this.btnCancelaNovaCor.Location = new System.Drawing.Point(94, 76);
            this.btnCancelaNovaCor.Name = "btnCancelaNovaCor";
            this.btnCancelaNovaCor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCancelaNovaCor.Size = new System.Drawing.Size(38, 29);
            this.btnCancelaNovaCor.TabIndex = 79;
            this.btnCancelaNovaCor.UseVisualStyleBackColor = true;
            this.btnCancelaNovaCor.Click += new System.EventHandler(this.btnCancelaNovaCor_Click);
            // 
            // tbNovaCor
            // 
            this.tbNovaCor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaCor.Location = new System.Drawing.Point(19, 42);
            this.tbNovaCor.Name = "tbNovaCor";
            this.tbNovaCor.Size = new System.Drawing.Size(153, 29);
            this.tbNovaCor.TabIndex = 78;
            // 
            // lblNovaCor
            // 
            this.lblNovaCor.AutoSize = true;
            this.lblNovaCor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaCor.Location = new System.Drawing.Point(9, 18);
            this.lblNovaCor.Name = "lblNovaCor";
            this.lblNovaCor.Size = new System.Drawing.Size(128, 21);
            this.lblNovaCor.TabIndex = 77;
            this.lblNovaCor.Text = "Entre com a Cor: ";
            // 
            // btnAddNovaCor
            // 
            this.btnAddNovaCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNovaCor.FlatAppearance.BorderSize = 0;
            this.btnAddNovaCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNovaCor.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAddNovaCor.IconColor = System.Drawing.Color.White;
            this.btnAddNovaCor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNovaCor.IconSize = 35;
            this.btnAddNovaCor.Location = new System.Drawing.Point(130, 76);
            this.btnAddNovaCor.Name = "btnAddNovaCor";
            this.btnAddNovaCor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddNovaCor.Size = new System.Drawing.Size(38, 29);
            this.btnAddNovaCor.TabIndex = 76;
            this.btnAddNovaCor.UseVisualStyleBackColor = true;
            this.btnAddNovaCor.Click += new System.EventHandler(this.btnAddNovaCor_Click);
            // 
            // chbRevisao
            // 
            this.chbRevisao.AutoSize = true;
            this.chbRevisao.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRevisao.Location = new System.Drawing.Point(831, 52);
            this.chbRevisao.Name = "chbRevisao";
            this.chbRevisao.Size = new System.Drawing.Size(83, 25);
            this.chbRevisao.TabIndex = 61;
            this.chbRevisao.Text = "Revisão";
            this.chbRevisao.UseVisualStyleBackColor = true;
            this.chbRevisao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbRevisao_MouseClick);
            // 
            // chbUrgencia
            // 
            this.chbUrgencia.AutoSize = true;
            this.chbUrgencia.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUrgencia.Location = new System.Drawing.Point(831, 14);
            this.chbUrgencia.Name = "chbUrgencia";
            this.chbUrgencia.Size = new System.Drawing.Size(85, 25);
            this.chbUrgencia.TabIndex = 60;
            this.chbUrgencia.Text = "Urgente";
            this.chbUrgencia.UseVisualStyleBackColor = true;
            this.chbUrgencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbUrgencia_MouseClick);
            // 
            // lblCor2
            // 
            this.lblCor2.AutoSize = true;
            this.lblCor2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor2.Location = new System.Drawing.Point(208, 146);
            this.lblCor2.Name = "lblCor2";
            this.lblCor2.Size = new System.Drawing.Size(35, 21);
            this.lblCor2.TabIndex = 58;
            this.lblCor2.Text = "Cor";
            // 
            // lblCor1
            // 
            this.lblCor1.AutoSize = true;
            this.lblCor1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor1.Location = new System.Drawing.Point(208, 84);
            this.lblCor1.Name = "lblCor1";
            this.lblCor1.Size = new System.Drawing.Size(35, 21);
            this.lblCor1.TabIndex = 57;
            this.lblCor1.Text = "Cor";
            // 
            // cbCor2
            // 
            this.cbCor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCor2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor2.FormattingEnabled = true;
            this.cbCor2.Location = new System.Drawing.Point(223, 170);
            this.cbCor2.Name = "cbCor2";
            this.cbCor2.Size = new System.Drawing.Size(110, 29);
            this.cbCor2.TabIndex = 56;
            // 
            // cbCor1
            // 
            this.cbCor1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCor1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCor1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor1.FormattingEnabled = true;
            this.cbCor1.Location = new System.Drawing.Point(223, 108);
            this.cbCor1.Name = "cbCor1";
            this.cbCor1.Size = new System.Drawing.Size(110, 29);
            this.cbCor1.TabIndex = 55;
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCampos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpaCampos.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpaCampos.IconColor = System.Drawing.Color.White;
            this.btnLimpaCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpaCampos.IconSize = 30;
            this.btnLimpaCampos.Location = new System.Drawing.Point(520, 219);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLimpaCampos.Size = new System.Drawing.Size(132, 43);
            this.btnLimpaCampos.TabIndex = 54;
            this.btnLimpaCampos.Text = "Limpar";
            this.btnLimpaCampos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpaCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpaCampos.UseVisualStyleBackColor = true;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnCadastrar.IconColor = System.Drawing.Color.White;
            this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrar.IconSize = 30;
            this.btnCadastrar.Location = new System.Drawing.Point(371, 219);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(132, 43);
            this.btnCadastrar.TabIndex = 53;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(351, 6);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 50;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Ferro",
            "Forno Eletrico",
            "Lavadora",
            "Liquidificador",
            "Microondas",
            "Mixer",
            "Panela Eletrica",
            "Secador"});
            this.cbTipo.Location = new System.Drawing.Point(366, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 29);
            this.cbTipo.TabIndex = 49;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(658, 6);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(63, 21);
            this.lblModelo.TabIndex = 48;
            this.lblModelo.Text = "Modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "258897",
            "698554",
            "9928B7",
            "ABCEFG",
            "AM5FR4",
            "H3X4D3C1M41",
            "XR15"});
            this.cbModelo.Location = new System.Drawing.Point(674, 30);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 29);
            this.cbModelo.TabIndex = 47;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(507, 6);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 21);
            this.lblMarca.TabIndex = 46;
            this.lblMarca.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarca.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Arno",
            "BabyLiss",
            "Britania",
            "Electrolux",
            "Mallory",
            "Mondial",
            "Samsung",
            "Taiff"});
            this.cbMarca.Location = new System.Drawing.Point(520, 30);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 29);
            this.cbMarca.TabIndex = 45;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(208, 6);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(63, 21);
            this.lblEntrada.TabIndex = 44;
            this.lblEntrada.Text = "Entrada";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(223, 30);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(110, 29);
            this.dtpEntrada.TabIndex = 43;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblema.Location = new System.Drawing.Point(351, 84);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(77, 21);
            this.lblProblema.TabIndex = 42;
            this.lblProblema.Text = "Problema";
            // 
            // tbProblema
            // 
            this.tbProblema.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProblema.Location = new System.Drawing.Point(366, 108);
            this.tbProblema.Multiline = true;
            this.tbProblema.Name = "tbProblema";
            this.tbProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProblema.Size = new System.Drawing.Size(181, 91);
            this.tbProblema.TabIndex = 41;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(553, 84);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 21);
            this.lblObs.TabIndex = 40;
            this.lblObs.Text = "Observação";
            // 
            // tbObs
            // 
            this.tbObs.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObs.Location = new System.Drawing.Point(573, 108);
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObs.Size = new System.Drawing.Size(222, 91);
            this.tbObs.TabIndex = 39;
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.Controls.Add(this.pnIdCliente);
            this.pnPesquisa.Controls.Add(this.btnLimpaCli);
            this.pnPesquisa.Controls.Add(this.lblCli);
            this.pnPesquisa.Controls.Add(this.tbCli);
            this.pnPesquisa.Location = new System.Drawing.Point(162, 12);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(745, 71);
            this.pnPesquisa.TabIndex = 28;
            // 
            // pnIdCliente
            // 
            this.pnIdCliente.Controls.Add(this.tbIdCli);
            this.pnIdCliente.Controls.Add(this.lblIdCli);
            this.pnIdCliente.Location = new System.Drawing.Point(50, 0);
            this.pnIdCliente.Name = "pnIdCliente";
            this.pnIdCliente.Size = new System.Drawing.Size(152, 71);
            this.pnIdCliente.TabIndex = 29;
            // 
            // tbIdCli
            // 
            this.tbIdCli.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCli.Location = new System.Drawing.Point(25, 32);
            this.tbIdCli.Name = "tbIdCli";
            this.tbIdCli.Size = new System.Drawing.Size(110, 29);
            this.tbIdCli.TabIndex = 27;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCli.Location = new System.Drawing.Point(8, 8);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(75, 21);
            this.lblIdCli.TabIndex = 28;
            this.lblIdCli.Text = "Id Cliente";
            // 
            // btnLimpaCli
            // 
            this.btnLimpaCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaCli.FlatAppearance.BorderSize = 0;
            this.btnLimpaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCli.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpaCli.IconColor = System.Drawing.Color.Red;
            this.btnLimpaCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpaCli.IconSize = 30;
            this.btnLimpaCli.Location = new System.Drawing.Point(606, 32);
            this.btnLimpaCli.Name = "btnLimpaCli";
            this.btnLimpaCli.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLimpaCli.Size = new System.Drawing.Size(43, 29);
            this.btnLimpaCli.TabIndex = 32;
            this.btnLimpaCli.UseVisualStyleBackColor = true;
            this.btnLimpaCli.Click += new System.EventHandler(this.btnLimpaCli_Click);
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.Location = new System.Drawing.Point(208, 8);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(105, 21);
            this.lblCli.TabIndex = 30;
            this.lblCli.Text = "Nome Cliente";
            // 
            // tbCli
            // 
            this.tbCli.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCli.Location = new System.Drawing.Point(223, 32);
            this.tbCli.Name = "tbCli";
            this.tbCli.Size = new System.Drawing.Size(377, 29);
            this.tbCli.TabIndex = 29;
            this.tbCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCli_KeyPress);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dgPesq
            // 
            this.dgPesq.AllowUserToAddRows = false;
            this.dgPesq.AllowUserToDeleteRows = false;
            this.dgPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPesq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(63)))));
            this.dgPesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Cpf,
            this.Nome,
            this.Numero});
            this.dgPesq.Location = new System.Drawing.Point(999, 115);
            this.dgPesq.MultiSelect = false;
            this.dgPesq.Name = "dgPesq";
            this.dgPesq.ReadOnly = true;
            this.dgPesq.RowHeadersVisible = false;
            this.dgPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesq.Size = new System.Drawing.Size(444, 166);
            this.dgPesq.TabIndex = 35;
            this.dgPesq.Visible = false;
            this.dgPesq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesq_CellDoubleClick);
            this.dgPesq.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgPesq_CellFormatting);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 120;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 120;
            // 
            // FormCadAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1141, 378);
            this.Controls.Add(this.dgPesq);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.pnAparelho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadAp";
            this.Text = "Cadastro de Aparelho";
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnAparelho.ResumeLayout(false);
            this.pnAparelho.PerformLayout();
            this.gbNovaCor.ResumeLayout(false);
            this.gbNovaCor.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.pnIdCliente.ResumeLayout(false);
            this.pnIdCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnPesquisa;
        private FontAwesome.Sharp.IconButton btnLimpaCli;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.TextBox tbCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox tbIdCli;
        private System.Windows.Forms.Panel pnAparelho;
        private System.Windows.Forms.CheckBox chbRevisao;
        private System.Windows.Forms.CheckBox chbUrgencia;
        private System.Windows.Forms.Label lblCor2;
        private System.Windows.Forms.Label lblCor1;
        private System.Windows.Forms.ComboBox cbCor2;
        private System.Windows.Forms.ComboBox cbCor1;
        private FontAwesome.Sharp.IconButton btnLimpaCampos;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblModelo;
        public System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox tbProblema;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox tbObs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnNovaCor;
        private System.Windows.Forms.Panel pnIdCliente;
        private System.Windows.Forms.DataGridView dgPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.GroupBox gbNovaCor;
        private FontAwesome.Sharp.IconButton btnCancelaNovaCor;
        private System.Windows.Forms.TextBox tbNovaCor;
        private System.Windows.Forms.Label lblNovaCor;
        private FontAwesome.Sharp.IconButton btnAddNovaCor;
    }
}