namespace AS2
{
    partial class WaterBill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addInToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            manageInvoices = new ManageInvoices();
            addInvoice = new AddInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addInToolStripMenuItem, manageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1807, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInToolStripMenuItem
            // 
            addInToolStripMenuItem.Name = "addInToolStripMenuItem";
            addInToolStripMenuItem.Size = new Size(199, 48);
            addInToolStripMenuItem.Text = "Add Invoice";
            addInToolStripMenuItem.Click += addInToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(265, 48);
            manageToolStripMenuItem.Text = "Manage Invoices";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // manageInvoices
            // 
            manageInvoices.Location = new Point(0, 64);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(1802, 903);
            manageInvoices.TabIndex = 1;
            // 
            // addInvoice
            // 
            addInvoice.BackColor = SystemColors.ActiveCaption;
            addInvoice.Location = new Point(0, 52);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(1807, 1093);
            addInvoice.TabIndex = 2;
            addInvoice.Load += addInvoice1_Load;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1807, 953);
            Controls.Add(addInvoice);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WaterBill";
            Text = "WaterBills.";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addInToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ManageInvoices manageInvoices;
        private AddInvoice addInvoice;
    }
}