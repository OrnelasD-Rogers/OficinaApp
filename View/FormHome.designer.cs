
namespace View
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Vendas = new FontAwesome.Sharp.IconButton();
            this.btn_CadAp = new FontAwesome.Sharp.IconButton();
            this.btn_CadCli = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_Vendas);
            this.panelMenu.Controls.Add(this.btn_CadAp);
            this.panelMenu.Controls.Add(this.btn_CadCli);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 509);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_Vendas
            // 
            this.btn_Vendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Vendas.FlatAppearance.BorderSize = 0;
            this.btn_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vendas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vendas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Vendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btn_Vendas.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Vendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Vendas.IconSize = 32;
            this.btn_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vendas.Location = new System.Drawing.Point(0, 269);
            this.btn_Vendas.Name = "btn_Vendas";
            this.btn_Vendas.Size = new System.Drawing.Size(200, 50);
            this.btn_Vendas.TabIndex = 4;
            this.btn_Vendas.Text = "Vendas";
            this.btn_Vendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Vendas.UseVisualStyleBackColor = true;
            this.btn_Vendas.Visible = false;
            this.btn_Vendas.Click += new System.EventHandler(this.btn_Vendas_Click);
            // 
            // btn_CadAp
            // 
            this.btn_CadAp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadAp.FlatAppearance.BorderSize = 0;
            this.btn_CadAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadAp.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadAp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_CadAp.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_CadAp.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_CadAp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CadAp.IconSize = 32;
            this.btn_CadAp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadAp.Location = new System.Drawing.Point(0, 219);
            this.btn_CadAp.Name = "btn_CadAp";
            this.btn_CadAp.Size = new System.Drawing.Size(200, 50);
            this.btn_CadAp.TabIndex = 2;
            this.btn_CadAp.Text = "Cadastro de Aparelho";
            this.btn_CadAp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadAp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CadAp.UseVisualStyleBackColor = true;
            this.btn_CadAp.Click += new System.EventHandler(this.btn_CadAp_Click);
            // 
            // btn_CadCli
            // 
            this.btn_CadCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadCli.FlatAppearance.BorderSize = 0;
            this.btn_CadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadCli.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadCli.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_CadCli.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_CadCli.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_CadCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CadCli.IconSize = 32;
            this.btn_CadCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadCli.Location = new System.Drawing.Point(0, 169);
            this.btn_CadCli.Name = "btn_CadCli";
            this.btn_CadCli.Size = new System.Drawing.Size(200, 50);
            this.btn_CadCli.TabIndex = 1;
            this.btn_CadCli.Text = "Cadastro de Cliente";
            this.btn_CadCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CadCli.UseVisualStyleBackColor = true;
            this.btn_CadCli.Click += new System.EventHandler(this.btn_CadCli_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 169);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(6, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(188, 151);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btn_Close);
            this.panelTitleBar.Controls.Add(this.btn_Minimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1141, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.White;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 35;
            this.btn_Close.Location = new System.Drawing.Point(1114, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(0, 5, 4, 0);
            this.btn_Close.Size = new System.Drawing.Size(24, 22);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 28;
            this.btn_Minimize.Location = new System.Drawing.Point(1084, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_Minimize.Size = new System.Drawing.Size(24, 22);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 34);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1141, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1141, 425);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1341, 509);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Vendas;
        private FontAwesome.Sharp.IconButton btn_CadCli;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Close;
        public FontAwesome.Sharp.IconButton btn_CadAp;
    }
}