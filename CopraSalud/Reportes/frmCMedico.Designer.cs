namespace CopraSalud.Reportes
{
    partial class frmCMedico
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
            this.dtsCertMedico = new CopraSalud.Reportes.dtsCertMedico();
            this.certMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certMedicoTableAdapter = new CopraSalud.Reportes.dtsCertMedicoTableAdapters.certMedicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCertMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certMedicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dstCM";
            reportDataSource1.Value = this.certMedicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CopraSalud.Reportes.rptCertMedico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsCertMedico
            // 
            this.dtsCertMedico.DataSetName = "dtsCertMedico";
            this.dtsCertMedico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certMedicoBindingSource
            // 
            this.certMedicoBindingSource.DataMember = "certMedico";
            this.certMedicoBindingSource.DataSource = this.dtsCertMedico;
            // 
            // certMedicoTableAdapter
            // 
            this.certMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 605);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCMedico";
            this.Load += new System.EventHandler(this.frmCMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsCertMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certMedicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource certMedicoBindingSource;
        private dtsCertMedico dtsCertMedico;
        private dtsCertMedicoTableAdapters.certMedicoTableAdapter certMedicoTableAdapter;
    }
}