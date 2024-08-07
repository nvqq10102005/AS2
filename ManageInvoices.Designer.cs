namespace AS2
{
    partial class ManageInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InvoicedataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)InvoicedataGridView).BeginInit();
            SuspendLayout();
            // 
            // InvoicedataGridView
            // 
            InvoicedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicedataGridView.Location = new Point(0, 0);
            InvoicedataGridView.Name = "InvoicedataGridView";
            InvoicedataGridView.RowHeadersWidth = 102;
            InvoicedataGridView.RowTemplate.Height = 49;
            InvoicedataGridView.Size = new Size(1737, 827);
            InvoicedataGridView.TabIndex = 0;
            InvoicedataGridView.CellContentClick += InvoicedataGridView_CellContentClick;
            // 
            // ManageInvoices
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InvoicedataGridView);
            Name = "ManageInvoices";
            Size = new Size(1262, 827);
            ((System.ComponentModel.ISupportInitialize)InvoicedataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView InvoicedataGridView;
    }
}
