using StokApp.Models;
using StokApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokApp
{
    public partial class ContractForm : Form
    {

        CarService carService = CarService.Instance;
        Customer? customer;
        Contract? contract;
        Car? car;

        bool columnClick = true;

        public ContractForm()
        {
            customer = new Customer();
            contract = new Contract();

            InitializeComponent();

            ComboBoxCar();
            ListViewBuildNotRented();
        }

        private void ListViewBuildNotRented()
        {
            List<string[]> rows = new List<string[]>();

            foreach (Car car in carService.Cars!)
            {
                if (!car.IsRented)
                {
                    string[] row = { car.SerialNo!.ToString(), car.Gear!.ToString(), car.Brand!, car.Model!.ToString(), car.YearProd.ToString(), car.Plate!.ToString(), car.DailyPrice.ToString(), car.WeeklyPrice.ToString(), car.MonthlyPrice.ToString(), car.SixMonthPrice.ToString(), car.AnnualPrice.ToString() };
                    rows.Add(row);
                }
            }

            foreach (string[] row in rows)
            {
                listView1.Items.Add(new ListViewItem(row));
            }
        }
        /*
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Tıklanan öğeyi al
                ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y)!;

                try
                {
                    if (clickedItem != null)
                    {
                        foreach (Car car in carService.Cars!)
                        {
                            if (car.SerialNo == int.Parse(clickedItem.Text))
                            {
                                CarInfoForm carInfoForm = new CarInfoForm(car);
                                this.Hide();
                                carInfoForm.Show();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        */

        private void ComboBoxCar()
        {
            foreach (Car car in carService.Cars!)
            {
                comboBoxCar.Items.Add(car.Plate);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (columnClick)
            {
                this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Descending);
                columnClick = false;
            }
            else
            {
                this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
                columnClick = true;
            }

            // Sıralama özelliği etkinleştirilir
            this.listView1.Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ControlInfos())
            {
                return;
            }
            else
            {
                customer = new Customer();
                contract = new Contract();
                customer.Name = textBoxName.Text;
                customer.Surname = textBoxSurname.Text;
                customer.TelNo = textBoxTelNo.Text;
                customer.LicenseNo = textBoxLicenseNo.Text;
                customer.LicenseDate = dateTimePickerLicenseTime.Value;
            }
        }

        private bool ControlInfos()
        {
            if (!ControlTc())
            {
                return false;
            }
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz");
                return false;
            }
            if (textBoxSurname.Text.Length == 0)
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz");
                return false;
            }
            if (textBoxTelNo.Text.Length == 0)
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz");
                return false;
            }
            if (textBoxLicenseNo.Text.Length == 0)
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz");
                return false;
            }
            if (!ControlComboBoxCar())
            {
                return false;
            }
            if (!ControlComboBoxRentType())
            {
                return false;
            }
            if (textBoxPrice.Text.Length == 0)
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz");
                return false;
            }

            return true;
        }

        private bool ControlTc()
        {
            string tc = textBoxTc.Text;
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };

            if (tc.Length != 11)
            {
                MessageBox.Show("Hatalı Tc No girdiniz!!!");
                return false;
            }

            foreach (char c in tc)
            {
                if (!chars.Contains(c))
                {
                    MessageBox.Show("Hatalı Tc No girdiniz!!!");
                    return false;
                }
            }
            return true;
        }

        private bool ControlComboBoxCar()
        {
            if (comboBoxCar.SelectedItem == null)
            {
                MessageBox.Show("Araç seçmediniz!!!");
                return false;
            }
            return true;
        }

        private bool ControlComboBoxRentType()
        {
            if (comboBoxRentType.SelectedItem == null)
            {
                MessageBox.Show("Kiralama türü seçmediniz!!!");
                return false;
            }
            return true;
        }

        public void comboBoxRentCar_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Car car in carService.Cars!)
            {
                if (car.Plate == (string)comboBoxCar.SelectedItem)
                {
                    this.car = car;
                }
            }
        }

        public void comboBoxRentType_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxRentType.SelectedItem == "Günlük")
            {
                textBoxPrice.Text = car!.DailyPrice.ToString();
            }
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}
