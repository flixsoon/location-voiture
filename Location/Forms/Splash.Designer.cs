namespace Location.Forms
{
    partial class Splash
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_client = new System.Windows.Forms.ToolStripMenuItem();
            this.modify_client = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_car = new System.Windows.Forms.ToolStripMenuItem();
            this.modify_car = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_contrat = new System.Windows.Forms.ToolStripMenuItem();
            this.modify_contrat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.voitureToolStripMenuItem,
            this.contractToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_client,
            this.modify_client});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // add_client
            // 
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(112, 22);
            this.add_client.Text = "Add";
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // modify_client
            // 
            this.modify_client.Name = "modify_client";
            this.modify_client.Size = new System.Drawing.Size(112, 22);
            this.modify_client.Text = "Modify";
            this.modify_client.Click += new System.EventHandler(this.modify_client_Click);
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_car,
            this.modify_car});
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.voitureToolStripMenuItem.Text = "Voiture";
            // 
            // add_car
            // 
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(112, 22);
            this.add_car.Text = "Add";
            this.add_car.Click += new System.EventHandler(this.add_car_Click);
            // 
            // modify_car
            // 
            this.modify_car.Name = "modify_car";
            this.modify_car.Size = new System.Drawing.Size(112, 22);
            this.modify_car.Text = "Modify";
            this.modify_car.Click += new System.EventHandler(this.modify_car_Click);
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_contrat,
            this.modify_contrat});
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.contractToolStripMenuItem.Text = "Contrat";
            // 
            // add_contrat
            // 
            this.add_contrat.Name = "add_contrat";
            this.add_contrat.Size = new System.Drawing.Size(112, 22);
            this.add_contrat.Text = "Add";
            this.add_contrat.Click += new System.EventHandler(this.add_contrat_Click);
            // 
            // modify_contrat
            // 
            this.modify_contrat.Name = "modify_contrat";
            this.modify_contrat.Size = new System.Drawing.Size(112, 22);
            this.modify_contrat.Text = "Modify";
            this.modify_contrat.Click += new System.EventHandler(this.modify_contrat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 97);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_client;
        private System.Windows.Forms.ToolStripMenuItem modify_client;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_car;
        private System.Windows.Forms.ToolStripMenuItem modify_car;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_contrat;
        private System.Windows.Forms.ToolStripMenuItem modify_contrat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

