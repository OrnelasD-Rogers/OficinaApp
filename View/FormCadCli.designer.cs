
namespace View
{
    partial class FormCadCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCli));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.pnTel1 = new System.Windows.Forms.Panel();
            this.btnEditar1 = new FontAwesome.Sharp.IconButton();
            this.mtbNum1 = new System.Windows.Forms.MaskedTextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.cbTipo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTel2 = new FontAwesome.Sharp.IconButton();
            this.chWhats1 = new System.Windows.Forms.CheckBox();
            this.btnDelTel1 = new FontAwesome.Sharp.IconButton();
            this.pnTel2 = new System.Windows.Forms.Panel();
            this.btnEditar2 = new FontAwesome.Sharp.IconButton();
            this.mtbNum2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTel3 = new FontAwesome.Sharp.IconButton();
            this.chWhats2 = new System.Windows.Forms.CheckBox();
            this.btnDelTel2 = new FontAwesome.Sharp.IconButton();
            this.pnTel3 = new System.Windows.Forms.Panel();
            this.btnEditar3 = new FontAwesome.Sharp.IconButton();
            this.mtbNum3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipo3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chWhats3 = new System.Windows.Forms.CheckBox();
            this.btnDelTel3 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.pnDadosCli = new System.Windows.Forms.Panel();
            this.pnEdicao1 = new System.Windows.Forms.Panel();
            this.btnSalvarEdicao1 = new FontAwesome.Sharp.IconButton();
            this.pnEdicao2 = new System.Windows.Forms.Panel();
            this.btnSalvarEdicao2 = new FontAwesome.Sharp.IconButton();
            this.pnEdicao3 = new System.Windows.Forms.Panel();
            this.btnSalvarEdicao3 = new FontAwesome.Sharp.IconButton();
            this.bgwCliente = new System.ComponentModel.BackgroundWorker();
            this.bgwTelefones = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnTel1.SuspendLayout();
            this.pnTel2.SuspendLayout();
            this.pnTel3.SuspendLayout();
            this.pnDadosCli.SuspendLayout();
            this.pnEdicao1.SuspendLayout();
            this.pnEdicao2.SuspendLayout();
            this.pnEdicao3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(12, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(318, 29);
            this.tbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(182, 87);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(148, 29);
            this.cbSexo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sexo";
            // 
            // ep
            // 
            this.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep.ContainerControl = this;
            this.ep.Icon = ((System.Drawing.Icon)(resources.GetObject("ep.Icon")));
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.ep.SetIconAlignment(this.btnSalvar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnSalvar.IconColor = System.Drawing.Color.White;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(482, 396);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 47);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.ep.SetIconAlignment(this.btnLimpar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpar.IconColor = System.Drawing.Color.White;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpar.Location = new System.Drawing.Point(603, 396);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 47);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnTel1
            // 
            this.pnTel1.Controls.Add(this.btnEditar1);
            this.pnTel1.Controls.Add(this.mtbNum1);
            this.pnTel1.Controls.Add(this.lblNum1);
            this.pnTel1.Controls.Add(this.cbTipo1);
            this.pnTel1.Controls.Add(this.label5);
            this.pnTel1.Controls.Add(this.btnAddTel2);
            this.pnTel1.Controls.Add(this.chWhats1);
            this.pnTel1.Location = new System.Drawing.Point(388, 175);
            this.pnTel1.Name = "pnTel1";
            this.pnTel1.Size = new System.Drawing.Size(465, 68);
            this.pnTel1.TabIndex = 26;
            this.pnTel1.Visible = false;
            // 
            // btnEditar1
            // 
            this.btnEditar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar1.FlatAppearance.BorderSize = 0;
            this.btnEditar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar1.IconColor = System.Drawing.Color.White;
            this.btnEditar1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar1.IconSize = 30;
            this.btnEditar1.Location = new System.Drawing.Point(12, 27);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(32, 29);
            this.btnEditar1.TabIndex = 34;
            this.btnEditar1.UseVisualStyleBackColor = true;
            this.btnEditar1.Visible = false;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // mtbNum1
            // 
            this.mtbNum1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNum1.Location = new System.Drawing.Point(188, 27);
            this.mtbNum1.Name = "mtbNum1";
            this.mtbNum1.Size = new System.Drawing.Size(143, 29);
            this.mtbNum1.TabIndex = 2;
            this.mtbNum1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(186, 3);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(68, 21);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Numero";
            // 
            // cbTipo1
            // 
            this.cbTipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo1.FormattingEnabled = true;
            this.cbTipo1.Items.AddRange(new object[] {
            "Celular",
            "Fixo"});
            this.cbTipo1.Location = new System.Drawing.Point(94, 27);
            this.cbTipo1.Name = "cbTipo1";
            this.cbTipo1.Size = new System.Drawing.Size(72, 29);
            this.cbTipo1.TabIndex = 4;
            this.cbTipo1.SelectedIndexChanged += new System.EventHandler(this.cbTipo1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // btnAddTel2
            // 
            this.btnAddTel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTel2.FlatAppearance.BorderSize = 0;
            this.btnAddTel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTel2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTel2.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAddTel2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTel2.IconSize = 25;
            this.btnAddTel2.Location = new System.Drawing.Point(65, 31);
            this.btnAddTel2.Name = "btnAddTel2";
            this.btnAddTel2.Size = new System.Drawing.Size(23, 21);
            this.btnAddTel2.TabIndex = 21;
            this.btnAddTel2.UseVisualStyleBackColor = true;
            this.btnAddTel2.Click += new System.EventHandler(this.btnAddTel2_Click);
            // 
            // chWhats1
            // 
            this.chWhats1.AutoSize = true;
            this.chWhats1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWhats1.Location = new System.Drawing.Point(354, 29);
            this.chWhats1.Name = "chWhats1";
            this.chWhats1.Size = new System.Drawing.Size(108, 25);
            this.chWhats1.TabIndex = 6;
            this.chWhats1.Text = "WhatsApp?";
            this.chWhats1.UseVisualStyleBackColor = true;
            // 
            // btnDelTel1
            // 
            this.btnDelTel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelTel1.FlatAppearance.BorderSize = 0;
            this.btnDelTel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTel1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelTel1.IconColor = System.Drawing.Color.White;
            this.btnDelTel1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelTel1.IconSize = 25;
            this.btnDelTel1.Location = new System.Drawing.Point(3, 3);
            this.btnDelTel1.Name = "btnDelTel1";
            this.btnDelTel1.Size = new System.Drawing.Size(23, 21);
            this.btnDelTel1.TabIndex = 33;
            this.btnDelTel1.UseVisualStyleBackColor = true;
            this.btnDelTel1.Click += new System.EventHandler(this.btnDelTel1_Click);
            // 
            // pnTel2
            // 
            this.pnTel2.Controls.Add(this.btnEditar2);
            this.pnTel2.Controls.Add(this.mtbNum2);
            this.pnTel2.Controls.Add(this.label2);
            this.pnTel2.Controls.Add(this.cbTipo2);
            this.pnTel2.Controls.Add(this.label3);
            this.pnTel2.Controls.Add(this.btnAddTel3);
            this.pnTel2.Controls.Add(this.chWhats2);
            this.pnTel2.Location = new System.Drawing.Point(388, 249);
            this.pnTel2.Name = "pnTel2";
            this.pnTel2.Size = new System.Drawing.Size(465, 68);
            this.pnTel2.TabIndex = 27;
            this.pnTel2.Visible = false;
            // 
            // btnEditar2
            // 
            this.btnEditar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar2.FlatAppearance.BorderSize = 0;
            this.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar2.IconColor = System.Drawing.Color.White;
            this.btnEditar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar2.IconSize = 30;
            this.btnEditar2.Location = new System.Drawing.Point(12, 27);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(32, 29);
            this.btnEditar2.TabIndex = 39;
            this.btnEditar2.UseVisualStyleBackColor = true;
            this.btnEditar2.Visible = false;
            this.btnEditar2.Click += new System.EventHandler(this.btnEditar2_Click);
            // 
            // mtbNum2
            // 
            this.mtbNum2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNum2.Location = new System.Drawing.Point(188, 27);
            this.mtbNum2.Name = "mtbNum2";
            this.mtbNum2.Size = new System.Drawing.Size(143, 29);
            this.mtbNum2.TabIndex = 2;
            this.mtbNum2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // cbTipo2
            // 
            this.cbTipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo2.FormattingEnabled = true;
            this.cbTipo2.Items.AddRange(new object[] {
            "Celular",
            "Fixo"});
            this.cbTipo2.Location = new System.Drawing.Point(94, 27);
            this.cbTipo2.Name = "cbTipo2";
            this.cbTipo2.Size = new System.Drawing.Size(72, 29);
            this.cbTipo2.TabIndex = 4;
            this.cbTipo2.SelectedIndexChanged += new System.EventHandler(this.cbTipo2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // btnAddTel3
            // 
            this.btnAddTel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTel3.FlatAppearance.BorderSize = 0;
            this.btnAddTel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTel3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTel3.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAddTel3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTel3.IconSize = 25;
            this.btnAddTel3.Location = new System.Drawing.Point(65, 32);
            this.btnAddTel3.Name = "btnAddTel3";
            this.btnAddTel3.Size = new System.Drawing.Size(23, 21);
            this.btnAddTel3.TabIndex = 21;
            this.btnAddTel3.UseVisualStyleBackColor = true;
            this.btnAddTel3.Click += new System.EventHandler(this.btnAddTel3_Click);
            // 
            // chWhats2
            // 
            this.chWhats2.AutoSize = true;
            this.chWhats2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWhats2.Location = new System.Drawing.Point(354, 29);
            this.chWhats2.Name = "chWhats2";
            this.chWhats2.Size = new System.Drawing.Size(108, 25);
            this.chWhats2.TabIndex = 6;
            this.chWhats2.Text = "WhatsApp?";
            this.chWhats2.UseVisualStyleBackColor = true;
            // 
            // btnDelTel2
            // 
            this.btnDelTel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelTel2.FlatAppearance.BorderSize = 0;
            this.btnDelTel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTel2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelTel2.IconColor = System.Drawing.Color.White;
            this.btnDelTel2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelTel2.IconSize = 25;
            this.btnDelTel2.Location = new System.Drawing.Point(3, 3);
            this.btnDelTel2.Name = "btnDelTel2";
            this.btnDelTel2.Size = new System.Drawing.Size(23, 21);
            this.btnDelTel2.TabIndex = 34;
            this.btnDelTel2.UseVisualStyleBackColor = true;
            this.btnDelTel2.Click += new System.EventHandler(this.btnDelTel2_Click);
            // 
            // pnTel3
            // 
            this.pnTel3.Controls.Add(this.btnEditar3);
            this.pnTel3.Controls.Add(this.mtbNum3);
            this.pnTel3.Controls.Add(this.label7);
            this.pnTel3.Controls.Add(this.cbTipo3);
            this.pnTel3.Controls.Add(this.label8);
            this.pnTel3.Controls.Add(this.chWhats3);
            this.pnTel3.Location = new System.Drawing.Point(388, 322);
            this.pnTel3.Name = "pnTel3";
            this.pnTel3.Size = new System.Drawing.Size(465, 68);
            this.pnTel3.TabIndex = 27;
            this.pnTel3.Visible = false;
            // 
            // btnEditar3
            // 
            this.btnEditar3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar3.FlatAppearance.BorderSize = 0;
            this.btnEditar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar3.IconColor = System.Drawing.Color.White;
            this.btnEditar3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar3.IconSize = 30;
            this.btnEditar3.Location = new System.Drawing.Point(12, 27);
            this.btnEditar3.Name = "btnEditar3";
            this.btnEditar3.Size = new System.Drawing.Size(32, 29);
            this.btnEditar3.TabIndex = 38;
            this.btnEditar3.UseVisualStyleBackColor = true;
            this.btnEditar3.Visible = false;
            this.btnEditar3.Click += new System.EventHandler(this.btnEditar3_Click);
            // 
            // mtbNum3
            // 
            this.mtbNum3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNum3.Location = new System.Drawing.Point(185, 27);
            this.mtbNum3.Name = "mtbNum3";
            this.mtbNum3.Size = new System.Drawing.Size(146, 29);
            this.mtbNum3.TabIndex = 2;
            this.mtbNum3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Numero";
            // 
            // cbTipo3
            // 
            this.cbTipo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo3.FormattingEnabled = true;
            this.cbTipo3.Items.AddRange(new object[] {
            "Celular",
            "Fixo"});
            this.cbTipo3.Location = new System.Drawing.Point(91, 27);
            this.cbTipo3.Name = "cbTipo3";
            this.cbTipo3.Size = new System.Drawing.Size(72, 29);
            this.cbTipo3.TabIndex = 4;
            this.cbTipo3.SelectedIndexChanged += new System.EventHandler(this.cbTipo3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tipo";
            // 
            // chWhats3
            // 
            this.chWhats3.AutoSize = true;
            this.chWhats3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWhats3.Location = new System.Drawing.Point(351, 29);
            this.chWhats3.Name = "chWhats3";
            this.chWhats3.Size = new System.Drawing.Size(108, 25);
            this.chWhats3.TabIndex = 6;
            this.chWhats3.Text = "WhatsApp?";
            this.chWhats3.UseVisualStyleBackColor = true;
            // 
            // btnDelTel3
            // 
            this.btnDelTel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelTel3.FlatAppearance.BorderSize = 0;
            this.btnDelTel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTel3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelTel3.IconColor = System.Drawing.Color.White;
            this.btnDelTel3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelTel3.IconSize = 25;
            this.btnDelTel3.Location = new System.Drawing.Point(3, 3);
            this.btnDelTel3.Name = "btnDelTel3";
            this.btnDelTel3.Size = new System.Drawing.Size(23, 21);
            this.btnDelTel3.TabIndex = 35;
            this.btnDelTel3.UseVisualStyleBackColor = true;
            this.btnDelTel3.Click += new System.EventHandler(this.btnDelTel3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Cpf";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(12, 87);
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(140, 29);
            this.mtbCpf.TabIndex = 30;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.btn_Close.Location = new System.Drawing.Point(1089, 11);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btn_Close.Size = new System.Drawing.Size(41, 35);
            this.btn_Close.TabIndex = 31;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Visible = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnDadosCli
            // 
            this.pnDadosCli.Controls.Add(this.mtbCpf);
            this.pnDadosCli.Controls.Add(this.label9);
            this.pnDadosCli.Controls.Add(this.label6);
            this.pnDadosCli.Controls.Add(this.cbSexo);
            this.pnDadosCli.Controls.Add(this.label1);
            this.pnDadosCli.Controls.Add(this.tbNome);
            this.pnDadosCli.Location = new System.Drawing.Point(388, 24);
            this.pnDadosCli.Name = "pnDadosCli";
            this.pnDadosCli.Size = new System.Drawing.Size(425, 133);
            this.pnDadosCli.TabIndex = 32;
            // 
            // pnEdicao1
            // 
            this.pnEdicao1.Controls.Add(this.btnSalvarEdicao1);
            this.pnEdicao1.Controls.Add(this.btnDelTel1);
            this.pnEdicao1.Location = new System.Drawing.Point(249, 198);
            this.pnEdicao1.Name = "pnEdicao1";
            this.pnEdicao1.Size = new System.Drawing.Size(50, 29);
            this.pnEdicao1.TabIndex = 35;
            this.pnEdicao1.Visible = false;
            // 
            // btnSalvarEdicao1
            // 
            this.btnSalvarEdicao1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarEdicao1.FlatAppearance.BorderSize = 0;
            this.btnSalvarEdicao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarEdicao1.IconColor = System.Drawing.Color.White;
            this.btnSalvarEdicao1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarEdicao1.IconSize = 25;
            this.btnSalvarEdicao1.Location = new System.Drawing.Point(24, 5);
            this.btnSalvarEdicao1.Name = "btnSalvarEdicao1";
            this.btnSalvarEdicao1.Size = new System.Drawing.Size(23, 21);
            this.btnSalvarEdicao1.TabIndex = 36;
            this.btnSalvarEdicao1.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao1.Click += new System.EventHandler(this.btnSalvarEdicao1_Click);
            // 
            // pnEdicao2
            // 
            this.pnEdicao2.Controls.Add(this.btnDelTel2);
            this.pnEdicao2.Controls.Add(this.btnSalvarEdicao2);
            this.pnEdicao2.Location = new System.Drawing.Point(249, 252);
            this.pnEdicao2.Name = "pnEdicao2";
            this.pnEdicao2.Size = new System.Drawing.Size(50, 29);
            this.pnEdicao2.TabIndex = 36;
            this.pnEdicao2.Visible = false;
            // 
            // btnSalvarEdicao2
            // 
            this.btnSalvarEdicao2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarEdicao2.FlatAppearance.BorderSize = 0;
            this.btnSalvarEdicao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao2.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarEdicao2.IconColor = System.Drawing.Color.White;
            this.btnSalvarEdicao2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarEdicao2.IconSize = 25;
            this.btnSalvarEdicao2.Location = new System.Drawing.Point(24, 5);
            this.btnSalvarEdicao2.Name = "btnSalvarEdicao2";
            this.btnSalvarEdicao2.Size = new System.Drawing.Size(23, 21);
            this.btnSalvarEdicao2.TabIndex = 36;
            this.btnSalvarEdicao2.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao2.Click += new System.EventHandler(this.btnSalvarEdicao2_Click);
            // 
            // pnEdicao3
            // 
            this.pnEdicao3.Controls.Add(this.btnDelTel3);
            this.pnEdicao3.Controls.Add(this.btnSalvarEdicao3);
            this.pnEdicao3.Location = new System.Drawing.Point(249, 322);
            this.pnEdicao3.Name = "pnEdicao3";
            this.pnEdicao3.Size = new System.Drawing.Size(50, 29);
            this.pnEdicao3.TabIndex = 37;
            this.pnEdicao3.Visible = false;
            // 
            // btnSalvarEdicao3
            // 
            this.btnSalvarEdicao3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarEdicao3.FlatAppearance.BorderSize = 0;
            this.btnSalvarEdicao3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao3.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarEdicao3.IconColor = System.Drawing.Color.White;
            this.btnSalvarEdicao3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarEdicao3.IconSize = 25;
            this.btnSalvarEdicao3.Location = new System.Drawing.Point(24, 5);
            this.btnSalvarEdicao3.Name = "btnSalvarEdicao3";
            this.btnSalvarEdicao3.Size = new System.Drawing.Size(23, 21);
            this.btnSalvarEdicao3.TabIndex = 36;
            this.btnSalvarEdicao3.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao3.Click += new System.EventHandler(this.btnSalvarEdicao3_Click);
            // 
            // bgwCliente
            // 
            this.bgwCliente.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCliente_DoWork);
            this.bgwCliente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCliente_RunWorkerCompleted);
            // 
            // bgwTelefones
            // 
            this.bgwTelefones.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTelefones_DoWork);
            this.bgwTelefones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTelefones_RunWorkerCompleted);
            // 
            // FormCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1141, 455);
            this.Controls.Add(this.pnEdicao3);
            this.Controls.Add(this.pnEdicao2);
            this.Controls.Add(this.pnEdicao1);
            this.Controls.Add(this.pnDadosCli);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pnTel3);
            this.Controls.Add(this.pnTel2);
            this.Controls.Add(this.pnTel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnTel1.ResumeLayout(false);
            this.pnTel1.PerformLayout();
            this.pnTel2.ResumeLayout(false);
            this.pnTel2.PerformLayout();
            this.pnTel3.ResumeLayout(false);
            this.pnTel3.PerformLayout();
            this.pnDadosCli.ResumeLayout(false);
            this.pnDadosCli.PerformLayout();
            this.pnEdicao1.ResumeLayout(false);
            this.pnEdicao2.ResumeLayout(false);
            this.pnEdicao3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider ep;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.Panel pnTel3;
        private System.Windows.Forms.MaskedTextBox mtbNum3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipo3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chWhats3;
        private System.Windows.Forms.Panel pnTel2;
        private System.Windows.Forms.MaskedTextBox mtbNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAddTel3;
        private System.Windows.Forms.CheckBox chWhats2;
        private System.Windows.Forms.Panel pnTel1;
        private System.Windows.Forms.MaskedTextBox mtbNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.ComboBox cbTipo1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAddTel2;
        private System.Windows.Forms.CheckBox chWhats1;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Panel pnDadosCli;
        private FontAwesome.Sharp.IconButton btnDelTel1;
        private FontAwesome.Sharp.IconButton btnDelTel3;
        private FontAwesome.Sharp.IconButton btnDelTel2;
        private FontAwesome.Sharp.IconButton btnEditar1;
        private System.Windows.Forms.Panel pnEdicao1;
        private FontAwesome.Sharp.IconButton btnSalvarEdicao1;
        private System.Windows.Forms.Panel pnEdicao3;
        private FontAwesome.Sharp.IconButton btnSalvarEdicao3;
        private System.Windows.Forms.Panel pnEdicao2;
        private FontAwesome.Sharp.IconButton btnSalvarEdicao2;
        private FontAwesome.Sharp.IconButton btnEditar3;
        private FontAwesome.Sharp.IconButton btnEditar2;
        private System.ComponentModel.BackgroundWorker bgwCliente;
        private System.ComponentModel.BackgroundWorker bgwTelefones;
    }
}