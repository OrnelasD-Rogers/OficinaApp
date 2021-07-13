
namespace View
{
    partial class FormPagamento
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
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumParc = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblTipoSaida = new System.Windows.Forms.Label();
            this.cbTipoSaida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new FontAwesome.Sharp.IconButton();
            this.pnParcelas = new System.Windows.Forms.Panel();
            this.pnTipoSaida = new System.Windows.Forms.Panel();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.pnParcelas.SuspendLayout();
            this.pnTipoSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Close.Location = new System.Drawing.Point(356, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 7, 5, 0);
            this.btn_Close.Size = new System.Drawing.Size(29, 27);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Credito",
            "Debito",
            "Pix"});
            this.cbTipoPag.Location = new System.Drawing.Point(219, 70);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(138, 29);
            this.cbTipoPag.TabIndex = 6;
            this.cbTipoPag.SelectedIndexChanged += new System.EventHandler(this.cbTipoPag_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 29);
            this.panel1.TabIndex = 8;
            // 
            // lblNumParc
            // 
            this.lblNumParc.AutoSize = true;
            this.lblNumParc.Location = new System.Drawing.Point(3, 1);
            this.lblNumParc.Name = "lblNumParc";
            this.lblNumParc.Size = new System.Drawing.Size(150, 21);
            this.lblNumParc.TabIndex = 53;
            this.lblNumParc.Text = "Numero de Parcelas";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(8, 25);
            this.nudParcelas.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(62, 29);
            this.nudParcelas.TabIndex = 54;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTipoSaida
            // 
            this.lblTipoSaida.AutoSize = true;
            this.lblTipoSaida.Location = new System.Drawing.Point(3, 1);
            this.lblTipoSaida.Name = "lblTipoSaida";
            this.lblTipoSaida.Size = new System.Drawing.Size(103, 21);
            this.lblTipoSaida.TabIndex = 61;
            this.lblTipoSaida.Text = "Tipo de Saida";
            // 
            // cbTipoSaida
            // 
            this.cbTipoSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoSaida.FormattingEnabled = true;
            this.cbTipoSaida.Items.AddRange(new object[] {
            "APV_Entregue",
            "NAP_Entregue",
            "Descarte"});
            this.cbTipoSaida.Location = new System.Drawing.Point(12, 25);
            this.cbTipoSaida.Name = "cbTipoSaida";
            this.cbTipoSaida.Size = new System.Drawing.Size(138, 29);
            this.cbTipoSaida.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Valor";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(38, 70);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(138, 29);
            this.tbValor.TabIndex = 58;
            this.tbValor.Text = "R$ 0,00";
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnFinalizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(218)))), ((int)(((byte)(15)))));
            this.btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizar.IconSize = 35;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(132, 201);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFinalizar.Size = new System.Drawing.Size(132, 57);
            this.btnFinalizar.TabIndex = 57;
            this.btnFinalizar.Text = "Finalizar Transação";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pnParcelas
            // 
            this.pnParcelas.Controls.Add(this.nudParcelas);
            this.pnParcelas.Controls.Add(this.lblNumParc);
            this.pnParcelas.Location = new System.Drawing.Point(211, 119);
            this.pnParcelas.Name = "pnParcelas";
            this.pnParcelas.Size = new System.Drawing.Size(156, 64);
            this.pnParcelas.TabIndex = 62;
            this.pnParcelas.Visible = false;
            // 
            // pnTipoSaida
            // 
            this.pnTipoSaida.Controls.Add(this.lblTipoSaida);
            this.pnTipoSaida.Controls.Add(this.cbTipoSaida);
            this.pnTipoSaida.Location = new System.Drawing.Point(26, 119);
            this.pnTipoSaida.Name = "pnTipoSaida";
            this.pnTipoSaida.Size = new System.Drawing.Size(159, 64);
            this.pnTipoSaida.TabIndex = 63;
            this.pnTipoSaida.Visible = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(389, 270);
            this.Controls.Add(this.pnTipoSaida);
            this.Controls.Add(this.pnParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoPag);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPagamento";
            this.Text = "FormPagamento";
            this.Click += new System.EventHandler(this.FormPagamento_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.pnParcelas.ResumeLayout(false);
            this.pnParcelas.PerformLayout();
            this.pnTipoSaida.ResumeLayout(false);
            this.pnTipoSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumParc;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblTipoSaida;
        private System.Windows.Forms.ComboBox cbTipoSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private FontAwesome.Sharp.IconButton btnFinalizar;
        private System.Windows.Forms.Panel pnParcelas;
        private System.Windows.Forms.Panel pnTipoSaida;
        private System.Windows.Forms.ErrorProvider ep;
    }
}