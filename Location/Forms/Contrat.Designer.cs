namespace Location.Forms
{
    partial class Contrat
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
            this.dgv_contrat = new System.Windows.Forms.DataGridView();
            this.modify_car = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contrat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contrat
            // 
            this.dgv_contrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contrat.Location = new System.Drawing.Point(12, 120);
            this.dgv_contrat.Name = "dgv_contrat";
            this.dgv_contrat.Size = new System.Drawing.Size(864, 342);
            this.dgv_contrat.TabIndex = 0;
            // 
            // modify_car
            // 
            this.modify_car.Location = new System.Drawing.Point(414, 468);
            this.modify_car.Name = "modify_car";
            this.modify_car.Size = new System.Drawing.Size(75, 23);
            this.modify_car.TabIndex = 1;
            this.modify_car.Text = "Modify";
            this.modify_car.UseVisualStyleBackColor = true;
            // 
            // Contrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.modify_car);
            this.Controls.Add(this.dgv_contrat);
            this.Name = "Contrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contrat";
            this.Load += new System.EventHandler(this.Contrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contrat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contrat;
        private System.Windows.Forms.Button modify_car;
    }
}