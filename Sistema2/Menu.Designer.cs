namespace Sistema2
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSpic = new System.Windows.Forms.Panel();
            this.btnBuscarSp = new System.Windows.Forms.Button();
            this.btnAgregarSP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPanelSp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPanel = new System.Windows.Forms.TabPage();
            this.btnCargarD = new System.Windows.Forms.Button();
            this.btnPanelUsers = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelSpic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.panelUsuarios);
            this.panel1.Controls.Add(this.btnPanelUsers);
            this.panel1.Controls.Add(this.panelSpic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPanelSp);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 750);
            this.panel1.TabIndex = 1;
            // 
            // panelSpic
            // 
            this.panelSpic.Controls.Add(this.btnCargarD);
            this.panelSpic.Controls.Add(this.btnBuscarSp);
            this.panelSpic.Controls.Add(this.btnAgregarSP);
            this.panelSpic.Location = new System.Drawing.Point(0, 212);
            this.panelSpic.Name = "panelSpic";
            this.panelSpic.Size = new System.Drawing.Size(290, 143);
            this.panelSpic.TabIndex = 1;
            // 
            // btnBuscarSp
            // 
            this.btnBuscarSp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnBuscarSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarSp.Location = new System.Drawing.Point(0, 49);
            this.btnBuscarSp.Name = "btnBuscarSp";
            this.btnBuscarSp.Size = new System.Drawing.Size(290, 43);
            this.btnBuscarSp.TabIndex = 2;
            this.btnBuscarSp.Text = "Buscar S.P en contratacion";
            this.btnBuscarSp.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSP
            // 
            this.btnAgregarSP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSP.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAgregarSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarSP.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarSP.Name = "btnAgregarSP";
            this.btnAgregarSP.Size = new System.Drawing.Size(290, 43);
            this.btnAgregarSP.TabIndex = 1;
            this.btnAgregarSP.Text = "Agregar S.P en  contratacion";
            this.btnAgregarSP.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema2.Properties.Resources.Logo_SEA390X194_Mesa_de_trabajo_1_Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPanelSp
            // 
            this.btnPanelSp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPanelSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnPanelSp.Image = global::Sistema2.Properties.Resources.flechaAzul;
            this.btnPanelSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelSp.Location = new System.Drawing.Point(0, 163);
            this.btnPanelSp.Name = "btnPanelSp";
            this.btnPanelSp.Size = new System.Drawing.Size(290, 43);
            this.btnPanelSp.TabIndex = 0;
            this.btnPanelSp.Text = "Administrar datos";
            this.btnPanelSp.UseVisualStyleBackColor = false;
            this.btnPanelSp.Click += new System.EventHandler(this.btnPanelSp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPanel);
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 18);
            this.tabControl1.Location = new System.Drawing.Point(299, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 750);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Location = new System.Drawing.Point(4, 22);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(854, 724);
            this.MainPanel.TabIndex = 0;
            // 
            // btnCargarD
            // 
            this.btnCargarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarD.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCargarD.Location = new System.Drawing.Point(0, 98);
            this.btnCargarD.Name = "btnCargarD";
            this.btnCargarD.Size = new System.Drawing.Size(290, 43);
            this.btnCargarD.TabIndex = 3;
            this.btnCargarD.Text = "Cargar Datos";
            this.btnCargarD.UseVisualStyleBackColor = true;
            // 
            // btnPanelUsers
            // 
            this.btnPanelUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelUsers.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnPanelUsers.Image = global::Sistema2.Properties.Resources.flechaAzul;
            this.btnPanelUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelUsers.Location = new System.Drawing.Point(0, 361);
            this.btnPanelUsers.Name = "btnPanelUsers";
            this.btnPanelUsers.Size = new System.Drawing.Size(290, 43);
            this.btnPanelUsers.TabIndex = 2;
            this.btnPanelUsers.Text = "Administrar Usuarios";
            this.btnPanelUsers.UseVisualStyleBackColor = true;
            this.btnPanelUsers.Click += new System.EventHandler(this.btnPanelUsers_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.button2);
            this.panelUsuarios.Controls.Add(this.button1);
            this.panelUsuarios.Location = new System.Drawing.Point(0, 410);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(293, 100);
            this.panelUsuarios.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button2.Location = new System.Drawing.Point(3, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consultar Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 706);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(293, 44);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panelSpic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panelSpic;
        private System.Windows.Forms.Button btnPanelSp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage MainPanel;
        private System.Windows.Forms.Button btnBuscarSp;
        private System.Windows.Forms.Button btnAgregarSP;
        private System.Windows.Forms.Button btnCargarD;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPanelUsers;
    }
}