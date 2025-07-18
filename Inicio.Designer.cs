namespace Proyecto
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pbLogo = new PictureBox();
            btnInicioSesion = new Button();
            btnRegistrar = new Button();
            btnFavoritos = new Button();
            lblLogo = new Label();
            txtBusqueda = new TextBox();
            panelLogo = new Panel();
            lblMensaje = new Label();
            panel1Destacado = new Panel();
            lbl1DescripDestacado = new Label();
            lbl1DestacadoName = new Label();
            pb1Destacado = new PictureBox();
            pb2Destacado = new PictureBox();
            panel2Destacado = new Panel();
            lbl2DescripDestacado = new Label();
            lbl2DestacadoName = new Label();
            pb3Destacado = new PictureBox();
            panel3Destacado = new Panel();
            lbl3DescripDestacado = new Label();
            lbl3DestacadoName = new Label();
            lblIniciosub = new Label();
            panelFooterInicio = new Panel();
            lblCreadoPor = new Label();
            lblCopyMaya = new Label();
            btnTerminos = new Button();
            panelLogoFooter = new Panel();
            pbLogoFooter = new PictureBox();
            labelFooter = new Label();
            btnAvisoPrivacidad = new Button();
            btnExplorar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelLogo.SuspendLayout();
            panel1Destacado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1Destacado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2Destacado).BeginInit();
            panel2Destacado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb3Destacado).BeginInit();
            panel3Destacado.SuspendLayout();
            panelFooterInicio.SuspendLayout();
            panelLogoFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoFooter).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(3, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(85, 85);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInicioSesion.FlatAppearance.BorderSize = 0;
            btnInicioSesion.FlatStyle = FlatStyle.Flat;
            btnInicioSesion.Location = new Point(761, 38);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(123, 29);
            btnInicioSesion.TabIndex = 1;
            btnInicioSesion.Text = "Inicio de Sesión";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(890, 38);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(84, 29);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrate";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnFavoritos
            // 
            btnFavoritos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFavoritos.FlatAppearance.BorderSize = 0;
            btnFavoritos.FlatStyle = FlatStyle.Flat;
            btnFavoritos.Location = new Point(980, 38);
            btnFavoritos.Name = "btnFavoritos";
            btnFavoritos.Size = new Size(76, 29);
            btnFavoritos.TabIndex = 3;
            btnFavoritos.Text = "Favoritos";
            btnFavoritos.UseVisualStyleBackColor = true;
            btnFavoritos.Click += btnFavoritos_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Lucida Fax", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(94, 29);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(199, 31);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "Maya Connect";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.BackColor = SystemColors.ControlLight;
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Cursor = Cursors.IBeam;
            txtBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.ForeColor = SystemColors.WindowFrame;
            txtBusqueda.Location = new Point(385, 36);
            txtBusqueda.Multiline = true;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "             Encuentra tu próxima actividad";
            txtBusqueda.Size = new Size(311, 36);
            txtBusqueda.TabIndex = 5;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pbLogo);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Location = new Point(12, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(299, 93);
            panelLogo.TabIndex = 6;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.Top;
            lblMensaje.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(140, 285);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(873, 88);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = resources.GetString("lblMensaje.Text");
            // 
            // panel1Destacado
            // 
            panel1Destacado.Anchor = AnchorStyles.Left;
            panel1Destacado.Controls.Add(lbl1DescripDestacado);
            panel1Destacado.Controls.Add(lbl1DestacadoName);
            panel1Destacado.Controls.Add(pb1Destacado);
            panel1Destacado.Location = new Point(61, 428);
            panel1Destacado.Name = "panel1Destacado";
            panel1Destacado.Size = new Size(306, 284);
            panel1Destacado.TabIndex = 8;
            // 
            // lbl1DescripDestacado
            // 
            lbl1DescripDestacado.Anchor = AnchorStyles.Left;
            lbl1DescripDestacado.AutoSize = true;
            lbl1DescripDestacado.Location = new Point(3, 226);
            lbl1DescripDestacado.Name = "lbl1DescripDestacado";
            lbl1DescripDestacado.Size = new Size(93, 20);
            lbl1DescripDestacado.TabIndex = 2;
            lbl1DescripDestacado.Text = "Tour guiado ";
            // 
            // lbl1DestacadoName
            // 
            lbl1DestacadoName.Anchor = AnchorStyles.Left;
            lbl1DestacadoName.AutoSize = true;
            lbl1DestacadoName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1DestacadoName.Location = new Point(3, 206);
            lbl1DestacadoName.Name = "lbl1DestacadoName";
            lbl1DestacadoName.Size = new Size(121, 20);
            lbl1DestacadoName.TabIndex = 1;
            lbl1DestacadoName.Text = "Cenote Dos Ojos";
            // 
            // pb1Destacado
            // 
            pb1Destacado.Anchor = AnchorStyles.Left;
            pb1Destacado.Location = new Point(3, 3);
            pb1Destacado.Name = "pb1Destacado";
            pb1Destacado.Size = new Size(300, 200);
            pb1Destacado.TabIndex = 0;
            pb1Destacado.TabStop = false;
            // 
            // pb2Destacado
            // 
            pb2Destacado.Anchor = AnchorStyles.None;
            pb2Destacado.Location = new Point(3, 3);
            pb2Destacado.Name = "pb2Destacado";
            pb2Destacado.Size = new Size(300, 200);
            pb2Destacado.TabIndex = 0;
            pb2Destacado.TabStop = false;
            // 
            // panel2Destacado
            // 
            panel2Destacado.Anchor = AnchorStyles.None;
            panel2Destacado.Controls.Add(lbl2DescripDestacado);
            panel2Destacado.Controls.Add(lbl2DestacadoName);
            panel2Destacado.Controls.Add(pb2Destacado);
            panel2Destacado.Location = new Point(390, 428);
            panel2Destacado.Name = "panel2Destacado";
            panel2Destacado.Size = new Size(306, 284);
            panel2Destacado.TabIndex = 9;
            // 
            // lbl2DescripDestacado
            // 
            lbl2DescripDestacado.Anchor = AnchorStyles.None;
            lbl2DescripDestacado.AutoSize = true;
            lbl2DescripDestacado.Location = new Point(3, 226);
            lbl2DescripDestacado.Name = "lbl2DescripDestacado";
            lbl2DescripDestacado.Size = new Size(93, 20);
            lbl2DescripDestacado.TabIndex = 3;
            lbl2DescripDestacado.Text = "Tour guiado ";
            // 
            // lbl2DestacadoName
            // 
            lbl2DestacadoName.Anchor = AnchorStyles.None;
            lbl2DestacadoName.AutoSize = true;
            lbl2DestacadoName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2DestacadoName.Location = new Point(3, 206);
            lbl2DestacadoName.Name = "lbl2DestacadoName";
            lbl2DestacadoName.Size = new Size(121, 20);
            lbl2DestacadoName.TabIndex = 3;
            lbl2DestacadoName.Text = "Cenote Dos Ojos";
            // 
            // pb3Destacado
            // 
            pb3Destacado.Anchor = AnchorStyles.Right;
            pb3Destacado.Location = new Point(3, 3);
            pb3Destacado.Name = "pb3Destacado";
            pb3Destacado.Size = new Size(300, 200);
            pb3Destacado.TabIndex = 0;
            pb3Destacado.TabStop = false;
            // 
            // panel3Destacado
            // 
            panel3Destacado.Anchor = AnchorStyles.Right;
            panel3Destacado.Controls.Add(lbl3DescripDestacado);
            panel3Destacado.Controls.Add(lbl3DestacadoName);
            panel3Destacado.Controls.Add(pb3Destacado);
            panel3Destacado.Location = new Point(710, 428);
            panel3Destacado.Name = "panel3Destacado";
            panel3Destacado.Size = new Size(306, 284);
            panel3Destacado.TabIndex = 10;
            // 
            // lbl3DescripDestacado
            // 
            lbl3DescripDestacado.Anchor = AnchorStyles.Right;
            lbl3DescripDestacado.AutoSize = true;
            lbl3DescripDestacado.Location = new Point(3, 226);
            lbl3DescripDestacado.Name = "lbl3DescripDestacado";
            lbl3DescripDestacado.Size = new Size(93, 20);
            lbl3DescripDestacado.TabIndex = 4;
            lbl3DescripDestacado.Text = "Tour guiado ";
            // 
            // lbl3DestacadoName
            // 
            lbl3DestacadoName.Anchor = AnchorStyles.Right;
            lbl3DestacadoName.AutoSize = true;
            lbl3DestacadoName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3DestacadoName.Location = new Point(3, 206);
            lbl3DestacadoName.Name = "lbl3DestacadoName";
            lbl3DestacadoName.Size = new Size(121, 20);
            lbl3DestacadoName.TabIndex = 4;
            lbl3DestacadoName.Text = "Cenote Dos Ojos";
            // 
            // lblIniciosub
            // 
            lblIniciosub.Anchor = AnchorStyles.Left;
            lblIniciosub.AutoSize = true;
            lblIniciosub.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIniciosub.Location = new Point(59, 379);
            lblIniciosub.Name = "lblIniciosub";
            lblIniciosub.Size = new Size(399, 22);
            lblIniciosub.TabIndex = 11;
            lblIniciosub.Text = "Lugares Turísticos de Quintana Roo Más Famosos";
            // 
            // panelFooterInicio
            // 
            panelFooterInicio.BackColor = SystemColors.ButtonHighlight;
            panelFooterInicio.Controls.Add(lblCreadoPor);
            panelFooterInicio.Controls.Add(lblCopyMaya);
            panelFooterInicio.Controls.Add(btnTerminos);
            panelFooterInicio.Controls.Add(panelLogoFooter);
            panelFooterInicio.Controls.Add(btnAvisoPrivacidad);
            panelFooterInicio.Dock = DockStyle.Bottom;
            panelFooterInicio.Location = new Point(0, 791);
            panelFooterInicio.Name = "panelFooterInicio";
            panelFooterInicio.Size = new Size(1082, 112);
            panelFooterInicio.TabIndex = 12;
            // 
            // lblCreadoPor
            // 
            lblCreadoPor.Anchor = AnchorStyles.Right;
            lblCreadoPor.AutoSize = true;
            lblCreadoPor.Location = new Point(645, 16);
            lblCreadoPor.Name = "lblCreadoPor";
            lblCreadoPor.Size = new Size(403, 80);
            lblCreadoPor.TabIndex = 17;
            lblCreadoPor.Text = "Sitio creado por:\r\n- Uwe Tonathiu Wolf Rivera      - Suaste Pablo Axel David     \r\n- Cordova Sanchez Oswaldo     - Cano Chan Kevin Ariel\r\n- Cortez Vargas Kristopher Eiael";
            // 
            // lblCopyMaya
            // 
            lblCopyMaya.AutoSize = true;
            lblCopyMaya.Font = new Font("Lucida Fax", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyMaya.Location = new Point(15, 83);
            lblCopyMaya.Name = "lblCopyMaya";
            lblCopyMaya.Size = new Size(232, 15);
            lblCopyMaya.TabIndex = 16;
            lblCopyMaya.Text = "Copyright © 2025 Maya Connect";
            // 
            // btnTerminos
            // 
            btnTerminos.Anchor = AnchorStyles.Left;
            btnTerminos.FlatAppearance.BorderSize = 0;
            btnTerminos.FlatStyle = FlatStyle.Flat;
            btnTerminos.Location = new Point(440, 14);
            btnTerminos.Name = "btnTerminos";
            btnTerminos.Size = new Size(190, 29);
            btnTerminos.TabIndex = 15;
            btnTerminos.Text = " Terminos y Condiciones";
            btnTerminos.UseVisualStyleBackColor = true;
            btnTerminos.Click += btnTerminos_Click;
            // 
            // panelLogoFooter
            // 
            panelLogoFooter.Controls.Add(pbLogoFooter);
            panelLogoFooter.Controls.Add(labelFooter);
            panelLogoFooter.Location = new Point(15, 12);
            panelLogoFooter.Name = "panelLogoFooter";
            panelLogoFooter.Size = new Size(215, 68);
            panelLogoFooter.TabIndex = 14;
            // 
            // pbLogoFooter
            // 
            pbLogoFooter.Location = new Point(3, 4);
            pbLogoFooter.Name = "pbLogoFooter";
            pbLogoFooter.Size = new Size(60, 60);
            pbLogoFooter.TabIndex = 0;
            pbLogoFooter.TabStop = false;
            // 
            // labelFooter
            // 
            labelFooter.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFooter.Location = new Point(69, 25);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(143, 27);
            labelFooter.TabIndex = 4;
            labelFooter.Text = "Maya Connect";
            // 
            // btnAvisoPrivacidad
            // 
            btnAvisoPrivacidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAvisoPrivacidad.FlatAppearance.BorderSize = 0;
            btnAvisoPrivacidad.FlatStyle = FlatStyle.Flat;
            btnAvisoPrivacidad.Location = new Point(278, 12);
            btnAvisoPrivacidad.Name = "btnAvisoPrivacidad";
            btnAvisoPrivacidad.Size = new Size(151, 29);
            btnAvisoPrivacidad.TabIndex = 14;
            btnAvisoPrivacidad.Text = "Aviso de Privacidad";
            btnAvisoPrivacidad.UseVisualStyleBackColor = true;
            btnAvisoPrivacidad.Click += btnAvisoPrivacidad_Click;
            // 
            // btnExplorar
            // 
            btnExplorar.Anchor = AnchorStyles.Right;
            btnExplorar.BackColor = SystemColors.Control;
            btnExplorar.Cursor = Cursors.Hand;
            btnExplorar.FlatAppearance.BorderSize = 0;
            btnExplorar.FlatStyle = FlatStyle.System;
            btnExplorar.Location = new Point(882, 748);
            btnExplorar.Name = "btnExplorar";
            btnExplorar.Size = new Size(135, 30);
            btnExplorar.TabIndex = 13;
            btnExplorar.Text = "Explorar más";
            btnExplorar.UseVisualStyleBackColor = false;
            btnExplorar.Click += btnExplorar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1082, 903);
            Controls.Add(btnExplorar);
            Controls.Add(panelFooterInicio);
            Controls.Add(lblIniciosub);
            Controls.Add(panel3Destacado);
            Controls.Add(panel2Destacado);
            Controls.Add(panel1Destacado);
            Controls.Add(lblMensaje);
            Controls.Add(panelLogo);
            Controls.Add(txtBusqueda);
            Controls.Add(btnFavoritos);
            Controls.Add(btnRegistrar);
            Controls.Add(btnInicioSesion);
            MinimumSize = new Size(1100, 950);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1Destacado.ResumeLayout(false);
            panel1Destacado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1Destacado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2Destacado).EndInit();
            panel2Destacado.ResumeLayout(false);
            panel2Destacado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb3Destacado).EndInit();
            panel3Destacado.ResumeLayout(false);
            panel3Destacado.PerformLayout();
            panelFooterInicio.ResumeLayout(false);
            panelFooterInicio.PerformLayout();
            panelLogoFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogoFooter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnInicioSesion;
        private Button btnRegistrar;
        private Button btnFavoritos;
        private Label lblLogo;
        private TextBox txtBusqueda;
        private Panel panelLogo;
        private Label lblMensaje;
        private Panel panel1Destacado;
        private PictureBox pb1Destacado;
        private PictureBox pb2Destacado;
        private Panel panel2Destacado;
        private PictureBox pb3Destacado;
        private Panel panel3Destacado;
        private Label lblIniciosub;
        private Label lbl1DestacadoName;
        private Label lbl1DescripDestacado;
        private Label lbl2DescripDestacado;
        private Label lbl2DestacadoName;
        private Label lbl3DescripDestacado;
        private Label lbl3DestacadoName;
        private Panel panelFooterInicio;
        private Button btnExplorar;
        private Button btnAvisoPrivacidad;
        private Panel panelLogoFooter;
        private PictureBox pbLogoFooter;
        private Label labelFooter;
        private Button btnTerminos;
        private Label lblCopyMaya;
        private Label lblCreadoPor;
    }
}
