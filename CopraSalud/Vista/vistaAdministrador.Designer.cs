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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem,
            this.medicoToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEspecialidadToolStripMenuItem,
            this.verEspecialidadesToolStripMenuItem});
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            // 
            // registrarEspecialidadToolStripMenuItem
            // 
            this.registrarEspecialidadToolStripMenuItem.Name = "registrarEspecialidadToolStripMenuItem";
            this.registrarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registrarEspecialidadToolStripMenuItem.Text = "Registrar Especialidad";
            this.registrarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.registrarEspecialidadToolStripMenuItem_Click);
            // 
            // verEspecialidadesToolStripMenuItem
            // 
            this.verEspecialidadesToolStripMenuItem.Name = "verEspecialidadesToolStripMenuItem";
            this.verEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verEspecialidadesToolStripMenuItem.Text = "Ver Especialidades";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMedicoToolStripMenuItem,
            this.verMedicosToolStripMenuItem});
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // registrarMedicoToolStripMenuItem
            // 
            this.registrarMedicoToolStripMenuItem.Name = "registrarMedicoToolStripMenuItem";
            this.registrarMedicoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarMedicoToolStripMenuItem.Text = "Registrar Medico";
            this.registrarMedicoToolStripMenuItem.Click += new System.EventHandler(this.registrarMedicoToolStripMenuItem_Click);
            // 
            // verMedicosToolStripMenuItem
            // 
            this.verMedicosToolStripMenuItem.Name = "verMedicosToolStripMenuItem";
            this.verMedicosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verMedicosToolStripMenuItem.Text = "Ver Medicos";
            this.verMedicosToolStripMenuItem.Click += new System.EventHandler(this.verMedicosToolStripMenuItem_Click);
            // 
            // vistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 429);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "vistaAdministrador";
            this.Text = "Vista Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}