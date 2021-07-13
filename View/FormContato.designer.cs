
namespace View
{
    partial class FormContato
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDialogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cbTipoContato = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarContato = new FontAwesome.Sharp.IconButton();
            this.cbContatante = new System.Windows.Forms.ComboBox();
            this.bgwIni = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatusContato = new System.Windows.Forms.ComboBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(109)))), ((int)(((byte)(187)))));
            this.panelTitleBar.Controls.Add(this.btn_Close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(857, 34);
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
            this.btn_Close.IconColor = System.Drawing.Color.Crimson;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 35;
            this.btn_Close.Location = new System.Drawing.Point(821, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 8, 5, 0);
            this.btn_Close.Size = new System.Drawing.Size(36, 32);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dialogo";
            // 
            // tbDialogo
            // 
            this.tbDialogo.Location = new System.Drawing.Point(32, 60);
            this.tbDialogo.Multiline = true;
            this.tbDialogo.Name = "tbDialogo";
            this.tbDialogo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDialogo.Size = new System.Drawing.Size(217, 86);
            this.tbDialogo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contatante";
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(286, 117);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(165, 29);
            this.cbNumero.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(269, 93);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 21);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Numero";
            // 
            // cbTipoContato
            // 
            this.cbTipoContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoContato.FormattingEnabled = true;
            this.cbTipoContato.Items.AddRange(new object[] {
            "WhatsApp",
            "Ligacao",
            "Presencial"});
            this.cbTipoContato.Location = new System.Drawing.Point(286, 60);
            this.cbTipoContato.Name = "cbTipoContato";
            this.cbTipoContato.Size = new System.Drawing.Size(165, 29);
            this.cbTipoContato.TabIndex = 8;
            this.cbTipoContato.SelectedIndexChanged += new System.EventHandler(this.cbTipoContato_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(270, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(673, 60);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(165, 29);
            this.cbEstado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status do Aparelho";
            // 
            // btnSalvarContato
            // 
            this.btnSalvarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarContato.FlatAppearance.BorderSize = 0;
            this.btnSalvarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarContato.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarContato.ForeColor = System.Drawing.Color.White;
            this.btnSalvarContato.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSalvarContato.IconColor = System.Drawing.Color.White;
            this.btnSalvarContato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarContato.IconSize = 35;
            this.btnSalvarContato.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalvarContato.Location = new System.Drawing.Point(688, 103);
            this.btnSalvarContato.Name = "btnSalvarContato";
            this.btnSalvarContato.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSalvarContato.Size = new System.Drawing.Size(135, 55);
            this.btnSalvarContato.TabIndex = 29;
            this.btnSalvarContato.Text = "Adicionar Contato";
            this.btnSalvarContato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarContato.UseVisualStyleBackColor = true;
            this.btnSalvarContato.Click += new System.EventHandler(this.btnSalvarContato_Click);
            // 
            // cbContatante
            // 
            this.cbContatante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatante.FormattingEnabled = true;
            this.cbContatante.Location = new System.Drawing.Point(478, 60);
            this.cbContatante.Name = "cbContatante";
            this.cbContatante.Size = new System.Drawing.Size(165, 29);
            this.cbContatante.TabIndex = 30;
            // 
            // bgwIni
            // 
            this.bgwIni.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIni_DoWork);
            this.bgwIni.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwIni_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Status do Contato";
            // 
            // cbStatusContato
            // 
            this.cbStatusContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusContato.FormattingEnabled = true;
            this.cbStatusContato.Items.AddRange(new object[] {
            "Atendido",
            "Nao Atendido",
            "Caixa de Mensagens"});
            this.cbStatusContato.Location = new System.Drawing.Point(478, 117);
            this.cbStatusContato.Name = "cbStatusContato";
            this.cbStatusContato.Size = new System.Drawing.Size(165, 29);
            this.cbStatusContato.TabIndex = 31;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(138)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(857, 220);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatusContato);
            this.Controls.Add(this.cbContatante);
            this.Controls.Add(this.btnSalvarContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoContato);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDialogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormContato";
            this.Text = "Contato";
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDialogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cbTipoContato;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSalvarContato;
        private System.Windows.Forms.ComboBox cbContatante;
        private System.ComponentModel.BackgroundWorker bgwIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatusContato;
        private System.Windows.Forms.ErrorProvider ep;
    }
}