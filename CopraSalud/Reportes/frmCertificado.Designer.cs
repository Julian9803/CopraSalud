namespace CopraSalud.Reportes
{
    partial class frmCertificado
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
            this.certificado1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstCertificado = new CopraSalud.Reportes.dstCertificado();
            this.certificado1TableAdapter = new CopraSalud.Reportes.dstCertificadoTableAdapters.certificado1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.certificado1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstCertificado)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dstCer";
            reportDataSource1.Value = this.certificado1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CopraSalud.Reportes.rptCert.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(577, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // certificado1BindingSource
            // 
            this.certificado1BindingSource.DataMember = "certificado1";
            this.certificado1BindingSource.DataSource = this.dstCertificado;
            // 
            // dstCertificado
            // 
            this.dstCertificado.DataSetName = "dstCertificado";
            this.dstCertificado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificado1TableAdapter
            // 
            this.certificado1TableAdapter.ClearBeforeFill = true;
            // 
            // frmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Certificado Medico";
            this.Load += new System.EventHandler(this.frmCertificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certificado1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstCertificado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource certificado1BindingSource;
        private dstCertificado dstCertificado;
        private dstCertificadoTableAdapters.certificado1TableAdapter certificado1TableAdapter;
    }
}