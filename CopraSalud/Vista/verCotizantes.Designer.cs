namespace CopraSalud.Vista
{
    partial class verCotizantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.dgvCotizantes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvCotizantes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotizantes Registrados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFamilia);
            this.groupBox2.Location = new System.Drawing.Point(233, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas";
            // 
            // btnFamilia
            // 
            this.btnFamilia.Location = new System.Drawing.Point(121, 45);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(112, 40);
            this.btnFamilia.TabIndex = 0;
            this.btnFamilia.Text = "Ver Familia";
            this.btnFamilia.UseVisualStyleBackColor = true;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // dgvCotizantes
            // 
            this.dgvCotizantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizantes.Location = new System.Drawing.Point(20, 41);
            this.dgvCotizantes.Name = "dgvCotizantes";
            this.dgvCotizantes.Size = new System.Drawing.Size(743, 150);
            this.dgvCotizantes.TabIndex = 0;
            this.dgvCotizantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCotizantes_CellClick);
            this.dgvCotizantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCotizantes_CellContentClick);
            // 
            // verCotizantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 407);
            this.Controls.Add(this.groupBox1);
            this.Name = "verCotizantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Cotizantes";
            this.Load += new System.EventHandler(this.verCotizantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.DataGridView dgvCotizantes;
    }
}