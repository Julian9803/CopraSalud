namespace CopraSalud.Reportes
{
    partial class frmCitaHistorial
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dstCita = new CopraSalud.Reportes.dstCita();
            this.historialCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialCitaTableAdapter = new CopraSalud.Reportes.dstCitaTableAdapters.historialCitaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dstCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tblCita";
            reportDataSource1.Value = this.historialCitaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CopraSalud.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(597, 557);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dstCita
            // 
            this.dstCita.DataSetName = "dstCita";
            this.dstCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialCitaBindingSource
            // 
            this.historialCitaBindingSource.DataMember = "historialCita";
            this.historialCitaBindingSource.DataSource = this.dstCita;
            // 
            // historialCitaTableAdapter
            // 
            this.historialCitaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCitaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 557);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCitaHistorial";
            this.Text = "Historial Medico";
            this.Load += new System.EventHandler(this.frmCitaHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dstCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource historialCitaBindingSource;
        private dstCita dstCita;
        private dstCitaTableAdapters.historialCitaTableAdapter historialCitaTableAdapter;
    }
}