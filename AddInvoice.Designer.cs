namespace AS2
{
    partial class AddInvoice
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
            CalculateButton = new Button();
            SaveButton = new Button();
            CustomerCodeInput = new TextBox();
            NumberofpeopleInput = new TextBox();
            CustomerNameInput = new TextBox();
            ThismonthInput = new TextBox();
            LastMonthInput = new TextBox();
            CustomerTypeCombobox = new ComboBox();
            CurrentMonthComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label12 = new Label();
            label4 = new Label();
            label6 = new Label();
            label11 = new Label();
            TotalLabel = new Label();
            SubtotalLabel = new Label();
            EnviromentFeesLable = new Label();
            VATLabel = new Label();
            PriceLabel = new Label();
            consumptionLabel = new Label();
            label13 = new Label();
            Labelg = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.PaleGreen;
            CalculateButton.Location = new Point(1575, 1);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(243, 89);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Khaki;
            SaveButton.Location = new Point(1309, 1);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(243, 89);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CustomerCodeInput
            // 
            CustomerCodeInput.Location = new Point(35, 131);
            CustomerCodeInput.Name = "CustomerCodeInput";
            CustomerCodeInput.Size = new Size(480, 47);
            CustomerCodeInput.TabIndex = 2;
            // 
            // NumberofpeopleInput
            // 
            NumberofpeopleInput.Location = new Point(645, 268);
            NumberofpeopleInput.Name = "NumberofpeopleInput";
            NumberofpeopleInput.Size = new Size(480, 47);
            NumberofpeopleInput.TabIndex = 3;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(35, 259);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(480, 47);
            CustomerNameInput.TabIndex = 4;
            // 
            // ThismonthInput
            // 
            ThismonthInput.Location = new Point(645, 399);
            ThismonthInput.Name = "ThismonthInput";
            ThismonthInput.Size = new Size(480, 47);
            ThismonthInput.TabIndex = 5;
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(35, 399);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(480, 47);
            LastMonthInput.TabIndex = 6;
            // 
            // CustomerTypeCombobox
            // 
            CustomerTypeCombobox.DropDownHeight = 150;
            CustomerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerTypeCombobox.DropDownWidth = 600;
            CustomerTypeCombobox.FormattingEnabled = true;
            CustomerTypeCombobox.IntegralHeight = false;
            CustomerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            CustomerTypeCombobox.Location = new Point(645, 129);
            CustomerTypeCombobox.Name = "CustomerTypeCombobox";
            CustomerTypeCombobox.Size = new Size(480, 49);
            CustomerTypeCombobox.TabIndex = 8;
            CustomerTypeCombobox.SelectedIndexChanged += CustomerTypeCombobox_SelectedIndexChanged;
            // 
            // CurrentMonthComboBox
            // 
            CurrentMonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CurrentMonthComboBox.FormattingEnabled = true;
            CurrentMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            CurrentMonthComboBox.Location = new Point(645, 537);
            CurrentMonthComboBox.Name = "CurrentMonthComboBox";
            CurrentMonthComboBox.Size = new Size(480, 49);
            CurrentMonthComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 82);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 10;
            label1.Text = "Customer Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 210);
            label2.Name = "label2";
            label2.Size = new Size(270, 46);
            label2.TabIndex = 11;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 350);
            label3.Name = "label3";
            label3.Size = new Size(544, 46);
            label3.TabIndex = 12;
            label3.Text = "Last month's water meter readings:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(645, 350);
            label5.Name = "label5";
            label5.Size = new Size(544, 46);
            label5.TabIndex = 13;
            label5.Text = "This month's water meter readings:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(645, 493);
            label12.Name = "label12";
            label12.Size = new Size(214, 41);
            label12.TabIndex = 22;
            label12.Text = "Current Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(645, 219);
            label4.Name = "label4";
            label4.Size = new Size(303, 46);
            label4.TabIndex = 23;
            label4.Text = "Number of people:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(645, 80);
            label6.Name = "label6";
            label6.Size = new Size(251, 46);
            label6.TabIndex = 24;
            label6.Text = "Customer Type:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1177, 697);
            label11.Name = "label11";
            label11.Size = new Size(162, 62);
            label11.TabIndex = 41;
            label11.Text = "Total:";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Right;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(1492, 648);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(328, 54);
            TotalLabel.TabIndex = 40;
            TotalLabel.Text = "0";
            TotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SubtotalLabel
            // 
            SubtotalLabel.Anchor = AnchorStyles.Right;
            SubtotalLabel.Location = new Point(1720, 498);
            SubtotalLabel.Name = "SubtotalLabel";
            SubtotalLabel.Size = new Size(98, 41);
            SubtotalLabel.TabIndex = 39;
            SubtotalLabel.Text = "0";
            SubtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EnviromentFeesLable
            // 
            EnviromentFeesLable.Anchor = AnchorStyles.Right;
            EnviromentFeesLable.Location = new Point(1720, 542);
            EnviromentFeesLable.Name = "EnviromentFeesLable";
            EnviromentFeesLable.Size = new Size(98, 41);
            EnviromentFeesLable.TabIndex = 38;
            EnviromentFeesLable.Text = "0";
            EnviromentFeesLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.Right;
            VATLabel.Location = new Point(1720, 597);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(98, 41);
            VATLabel.TabIndex = 37;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Right;
            PriceLabel.Location = new Point(1720, 448);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(98, 41);
            PriceLabel.TabIndex = 36;
            PriceLabel.Text = "0";
            PriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Anchor = AnchorStyles.Right;
            consumptionLabel.Location = new Point(1720, 399);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(98, 41);
            consumptionLabel.TabIndex = 35;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1177, 492);
            label13.Name = "label13";
            label13.Size = new Size(100, 46);
            label13.TabIndex = 34;
            label13.Text = "Price:";
            // 
            // Labelg
            // 
            Labelg.AutoSize = true;
            Labelg.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            Labelg.Location = new Point(1177, 538);
            Labelg.Name = "Labelg";
            Labelg.Size = new Size(153, 46);
            Labelg.TabIndex = 33;
            Labelg.Text = "Subtotal:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1177, 443);
            label9.Name = "label9";
            label9.Size = new Size(393, 46);
            label9.TabIndex = 32;
            label9.Text = "Amount of consumption:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1177, 591);
            label8.Name = "label8";
            label8.Size = new Size(273, 46);
            label8.TabIndex = 31;
            label8.Text = "Enviroment Fees:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1177, 641);
            label7.Name = "label7";
            label7.Size = new Size(168, 46);
            label7.TabIndex = 30;
            label7.Text = "VAT(10%):";
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label11);
            Controls.Add(TotalLabel);
            Controls.Add(SubtotalLabel);
            Controls.Add(EnviromentFeesLable);
            Controls.Add(VATLabel);
            Controls.Add(PriceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(label13);
            Controls.Add(Labelg);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CurrentMonthComboBox);
            Controls.Add(CustomerTypeCombobox);
            Controls.Add(LastMonthInput);
            Controls.Add(ThismonthInput);
            Controls.Add(CustomerNameInput);
            Controls.Add(NumberofpeopleInput);
            Controls.Add(CustomerCodeInput);
            Controls.Add(SaveButton);
            Controls.Add(CalculateButton);
            Name = "AddInvoice";
            Size = new Size(1858, 965);
            Load += AddInvoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button SaveButton;
        private TextBox CustomerCodeInput;
        private TextBox NumberofpeopleInput;
        private TextBox CustomerNameInput;
        private TextBox ThismonthInput;
        private TextBox LastMonthInput;
        private ComboBox CustomerTypeCombobox;
        private ComboBox CurrentMonthComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label12;
        private Label label4;
        private Label label6;
        private Label label11;
        private Label TotalLabel;
        private Label SubtotalLabel;
        private Label EnviromentFeesLable;
        private Label VATLabel;
        private Label PriceLabel;
        private Label consumptionLabel;
        private Label label13;
        private Label Labelg;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}
