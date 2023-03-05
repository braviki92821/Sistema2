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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPNU = new System.Windows.Forms.Button();
            this.panelSpic = new System.Windows.Forms.Panel();
            this.btnCargarD = new System.Windows.Forms.Button();
            this.btnBuscarSp = new System.Windows.Forms.Button();
            this.btnAgregarSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPanelUsers = new System.Windows.Forms.Button();
            this.btnPanelSp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panelSpic.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panelUsuarios);
            this.panel1.Controls.Add(this.btnPanelUsers);
            this.panel1.Controls.Add(this.panelSpic);
            this.panel1.Controls.Add(this.btnPanelSp);
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 476);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(0, 419);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(293, 57);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Cerrar Sesion";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.button2);
            this.panelUsuarios.Controls.Add(this.btnPNU);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 231);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(293, 100);
            this.panelUsuarios.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button2.Location = new System.Drawing.Point(0, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consultar Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPNU
            // 
            this.btnPNU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPNU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPNU.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnPNU.Location = new System.Drawing.Point(0, 0);
            this.btnPNU.Name = "btnPNU";
            this.btnPNU.Size = new System.Drawing.Size(293, 43);
            this.btnPNU.TabIndex = 0;
            this.btnPNU.Text = "Crear Usuario";
            this.btnPNU.UseVisualStyleBackColor = true;
            this.btnPNU.Click += new System.EventHandler(this.btnPNU_Click);
            // 
            // panelSpic
            // 
            this.panelSpic.Controls.Add(this.btnCargarD);
            this.panelSpic.Controls.Add(this.btnBuscarSp);
            this.panelSpic.Controls.Add(this.btnAgregarSP);
            this.panelSpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpic.Location = new System.Drawing.Point(0, 43);
            this.panelSpic.Name = "panelSpic";
            this.panelSpic.Size = new System.Drawing.Size(293, 145);
            this.panelSpic.TabIndex = 1;
            // 
            // btnCargarD
            // 
            this.btnCargarD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarD.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCargarD.Location = new System.Drawing.Point(0, 86);
            this.btnCargarD.Name = "btnCargarD";
            this.btnCargarD.Size = new System.Drawing.Size(293, 43);
            this.btnCargarD.TabIndex = 3;
            this.btnCargarD.Text = "Cargar Datos";
            this.btnCargarD.UseVisualStyleBackColor = true;
            this.btnCargarD.Click += new System.EventHandler(this.btnCargarD_Click);
            // 
            // btnBuscarSp
            // 
            this.btnBuscarSp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarSp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnBuscarSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarSp.Location = new System.Drawing.Point(0, 43);
            this.btnBuscarSp.Name = "btnBuscarSp";
            this.btnBuscarSp.Size = new System.Drawing.Size(293, 43);
            this.btnBuscarSp.TabIndex = 2;
            this.btnBuscarSp.Text = "Buscar S.P en contratacion";
            this.btnBuscarSp.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSP
            // 
            this.btnAgregarSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarSP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSP.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAgregarSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarSP.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarSP.Name = "btnAgregarSP";
            this.btnAgregarSP.Size = new System.Drawing.Size(293, 43);
            this.btnAgregarSP.TabIndex = 1;
            this.btnAgregarSP.Text = "Agregar S.P en  contratacion";
            this.btnAgregarSP.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 211);
            this.panel2.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Location = new System.Drawing.Point(299, -1);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(859, 687);
            this.panelContenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Sistema2.Properties.Resources.Logo_SEA390X194_Mesa_de_trabajo_1_Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPanelUsers
            // 
            this.btnPanelUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelUsers.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnPanelUsers.Image = global::Sistema2.Properties.Resources.flechaAzul;
            this.btnPanelUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelUsers.Location = new System.Drawing.Point(0, 188);
            this.btnPanelUsers.Name = "btnPanelUsers";
            this.btnPanelUsers.Size = new System.Drawing.Size(293, 43);
            this.btnPanelUsers.TabIndex = 2;
            this.btnPanelUsers.Text = "Administrar Usuarios";
            this.btnPanelUsers.UseVisualStyleBackColor = true;
            this.btnPanelUsers.Click += new System.EventHandler(this.btnPanelUsers_Click);
            // 
            // btnPanelSp
            // 
            this.btnPanelSp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelSp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelSp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPanelSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnPanelSp.Image = global::Sistema2.Properties.Resources.flechaAzul;
            this.btnPanelSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelSp.Location = new System.Drawing.Point(0, 0);
            this.btnPanelSp.Name = "btnPanelSp";
            this.btnPanelSp.Size = new System.Drawing.Size(293, 43);
            this.btnPanelSp.TabIndex = 0;
            this.btnPanelSp.Text = "Administrar datos";
            this.btnPanelSp.UseVisualStyleBackColor = false;
            this.btnPanelSp.Click += new System.EventHandler(this.btnPanelSp_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 687);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.panelSpic.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSpic;
        private System.Windows.Forms.Button btnPanelSp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarSp;
        private System.Windows.Forms.Button btnAgregarSP;
        private System.Windows.Forms.Button btnCargarD;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPNU;
        private System.Windows.Forms.Button btnPanelUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContenedor;
    }
}