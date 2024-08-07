using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2
{
    public partial class AddInvoice : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public AddInvoice()
        {
            InitializeComponent();
            CustomerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            CurrentMonthComboBox.SelectedItem = currentMonth;
            NumberofpeopleInput.Text = "0";

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValis = true;
            if (LastMonthInput.Text == "")
            {
                isValis = false;
                messages += "Please last month number:\n";
                MessageBox.Show(messages);
                return;
            }
            if (CustomerCodeInput.Text == "")
            {
                isValis = false;
                messages += "Please enter customer code:\n";
            }
            if(!LastMonthInput.Text.All(char.IsDigit))
            {
                isValis = false;
                messages += "Please enter valid last month number!\n";
            }
            if (!ThismonthInput.Text.All(char.IsDigit) || ThismonthInput.Text=="")
            {
                isValis = false;
                messages += "Please enter valid this month number!\n";
            }
            if (!NumberofpeopleInput.Text.All(char.IsDigit)|| NumberofpeopleInput.Text=="")
            {
                isValis = false;
                messages += "Please enter valid Number of people!\n";
            }
            if (!isValis)
            {
                MessageBox.Show(messages);
                
            }
            string customerCode = CustomerCodeInput.Text;
            string customername = CustomerNameInput.Text;
            string customerType = CustomerTypeCombobox.SelectedItem.ToString();
            int customerOfPeople = Convert.ToInt32(NumberofpeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
            int thisMonthNumber = Convert.ToInt32(ThismonthInput.Text);
            int currentMonth = Convert.ToInt32(CurrentMonthComboBox.SelectedIndex + 1);
            
            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;

            if(customerOfPeople <= 0)
            {
                MessageBox.Show("Please enter valid customer of people");
                
            }

            if (customerType == "Household customer")
            {
                decimal comsumtionPerPeople = consumption / customerOfPeople;
                if (comsumtionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                if(comsumtionPerPeople >10 && comsumtionPerPeople<=20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                if (comsumtionPerPeople > 20 && comsumtionPerPeople<=30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                else
                {
                    price = 15929;
                    envFee = 1592.9;
                }
            }
            if (customerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            if (customerType == "Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            if (customerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }
            double subTotal = price * consumption;
            double VATfee = (subTotal + envFee) * 0.1;
            double total = subTotal + envFee + VATfee;

            consumptionLabel.Text = consumption.ToString();
            PriceLabel.Text = price.ToString();
            SubtotalLabel.Text =Math.Round( subTotal,2).ToString();
            EnviromentFeesLable.Text = envFee.ToString();
            VATLabel.Text =Math.Round( VATfee).ToString();
            TotalLabel.Text = Math.Round(total,2).ToString();

            InvoiceManager.AddInvoice(customerCode, customername, customerType,
                customerOfPeople, lastMonthNumber, thisMonthNumber, currentMonth,
                subTotal, envFee, VATfee, total);

        }

        private void CustomerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = CustomerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
            {
                NumberofpeopleInput.Enabled = true;
            }
            else
            {
                NumberofpeopleInput.Enabled = false;
            }
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {

        }

    }
}
