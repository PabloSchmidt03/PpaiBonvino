namespace Presentacion
{
    partial class frmBodegas
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
            this.dgvBodegas = new System.Windows.Forms.DataGridView();
            this.btnObtenerActu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBodegas
            // 
            this.dgvBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodegas.Location = new System.Drawing.Point(21, 12);
            this.dgvBodegas.Name = "dgvBodegas";
            this.dgvBodegas.Size = new System.Drawing.Size(252, 278);
            this.dgvBodegas.TabIndex = 5;
            // 
            // btnObtenerActu
            // 
            this.btnObtenerActu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObtenerActu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnObtenerActu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerActu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnObtenerActu.Location = new System.Drawing.Point(21, 307);
            this.btnObtenerActu.Name = "btnObtenerActu";
            this.btnObtenerActu.Size = new System.Drawing.Size(252, 34);
            this.btnObtenerActu.TabIndex = 6;
            this.btnObtenerActu.Text = "Obtener actualizaciones";
            this.btnObtenerActu.UseVisualStyleBackColor = false;
            this.btnObtenerActu.Click += new System.EventHandler(this.btnObtenerActu_Click);
            // 
            // frmBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(411, 368);
            this.Controls.Add(this.btnObtenerActu);
            this.Controls.Add(this.dgvBodegas);
            this.MaximizeBox = false;
            this.Name = "frmBodegas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion Bodegas";
            this.Load += new System.EventHandler(this.frmBodegas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBodegas;
        private System.Windows.Forms.Button btnObtenerActu;
    }
}