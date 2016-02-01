namespace CopraSalud.Vista
{
    partial class vistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaAdministrador));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCotizanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCotizanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem,
            this.medicoToolStripMenuItem});
            this.tareasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tareasToolStripMenuItem.Image")));
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEspecialidadToolStripMenuItem,
            this.verEspecialidadesToolStripMenuItem});
            this.especialidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("especialidadToolStripMenuItem.Image")));
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            // 
            // registrarEspecialidadToolStripMenuItem
            // 
            this.registrarEspecialidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarEspecialidadToolStripMenuItem.Image")));
            this.registrarEspecialidadToolStripMenuItem.Name = "registrarEspecialidadToolStripMenuItem";
            this.registrarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registrarEspecialidadToolStripMenuItem.Text = "Registrar Especialidad";
            this.registrarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.registrarEspecialidadToolStripMenuItem_Click);
            // 
            // verEspecialidadesToolStripMenuItem
            // 
            this.verEspecialidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verEspecialidadesToolStripMenuItem.Image")));
            this.verEspecialidadesToolStripMenuItem.Name = "verEspecialidadesToolStripMenuItem";
            this.verEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.verEspecialidadesToolStripMenuItem.Text = "Ver Especialidades";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMedicoToolStripMenuItem,
            this.verMedicosToolStripMenuItem});
            this.medicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("medicoToolStripMenuItem.Image")));
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // registrarMedicoToolStripMenuItem
            // 
            this.registrarMedicoToolStripMenuItem.Name = "registrarMedicoToolStripMenuItem";
            this.registrarMedicoToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.registrarMedicoToolStripMenuItem.Text = "Registrar Medico";
            this.registrarMedicoToolStripMenuItem.Click += new System.EventHandler(this.registrarMedicoToolStripMenuItem_Click);
            // 
            // verMedicosToolStripMenuItem
            // 
            this.verMedicosToolStripMenuItem.Name = "verMedicosToolStripMenuItem";
            this.verMedicosToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.verMedicosToolStripMenuItem.Text = "Ver Medicos";
            this.verMedicosToolStripMenuItem.Click += new System.EventHandler(this.verMedicosToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizanteToolStripMenuItem});
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cotizanteToolStripMenuItem
            // 
            this.cotizanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCotizanteToolStripMenuItem,
            this.verCotizanteToolStripMenuItem});
            this.cotizanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cotizanteToolStripMenuItem.Image")));
            this.cotizanteToolStripMenuItem.Name = "cotizanteToolStripMenuItem";
            this.cotizanteToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.cotizanteToolStripMenuItem.Text = "Cotizante";
            // 
            // registrarCotizanteToolStripMenuItem
            // 
            this.registrarCotizanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarCotizanteToolStripMenuItem.Image")));
            this.registrarCotizanteToolStripMenuItem.Name = "registrarCotizanteToolStripMenuItem";
            this.registrarCotizanteToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.registrarCotizanteToolStripMenuItem.Text = "Registrar Cotizante";
            this.registrarCotizanteToolStripMenuItem.Click += new System.EventHandler(this.registrarCotizanteToolStripMenuItem_Click);
            // 
            // verCotizanteToolStripMenuItem
            // 
            this.verCotizanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verCotizanteToolStripMenuItem.Image")));
            this.verCotizanteToolStripMenuItem.Name = "verCotizanteToolStripMenuItem";
            this.verCotizanteToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.verCotizanteToolStripMenuItem.Text = "Ver Cotizante";
            this.verCotizanteToolStripMenuItem.Click += new System.EventHandler(this.verCotizanteToolStripMenuItem_Click);
            // 
            // vistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "vistaAdministrador";
            this.Text = "Vista Administrador";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vistaAdministrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCotizanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCotizanteToolStripMenuItem;
    }
}