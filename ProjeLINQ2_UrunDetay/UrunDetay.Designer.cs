namespace ProjeLINQ2_UrunDetay
{
    partial class UrunDetay
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
            this.label_UrunAdi = new System.Windows.Forms.Label();
            this.label_Qpu = new System.Windows.Forms.Label();
            this.label3_qpu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_UrunAdi
            // 
            this.label_UrunAdi.AutoSize = true;
            this.label_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_UrunAdi.Location = new System.Drawing.Point(29, 27);
            this.label_UrunAdi.Name = "label_UrunAdi";
            this.label_UrunAdi.Size = new System.Drawing.Size(119, 31);
            this.label_UrunAdi.TabIndex = 0;
            this.label_UrunAdi.Text = "UrunAdi";
            // 
            // label_Qpu
            // 
            this.label_Qpu.AutoSize = true;
            this.label_Qpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Qpu.Location = new System.Drawing.Point(29, 92);
            this.label_Qpu.Name = "label_Qpu";
            this.label_Qpu.Size = new System.Drawing.Size(85, 31);
            this.label_Qpu.TabIndex = 1;
            this.label_Qpu.Text = "QPU:";
            // 
            // label3_qpu
            // 
            this.label3_qpu.AutoSize = true;
            this.label3_qpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3_qpu.Location = new System.Drawing.Point(120, 92);
            this.label3_qpu.Name = "label3_qpu";
            this.label3_qpu.Size = new System.Drawing.Size(62, 31);
            this.label3_qpu.TabIndex = 2;
            this.label3_qpu.Text = "qpu";
            // 
            // UrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 294);
            this.Controls.Add(this.label3_qpu);
            this.Controls.Add(this.label_Qpu);
            this.Controls.Add(this.label_UrunAdi);
            this.Name = "UrunDetay";
            this.Text = "UrunDetay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_UrunAdi;
        private System.Windows.Forms.Label label_Qpu;
        public System.Windows.Forms.Label label3_qpu;
    }
}