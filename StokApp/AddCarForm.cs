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

namespace StokApp
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 1; i++)
            {
                if (!SerialNoControl())
                {
                    break;
                }
                if (!NameControl())
                {
                    break;
                }
                if (!LicensePlateControl())
                {
                    break;
                }
                if (!RentCheckBoxControl())
                {
                    break;
                }

                CarService carService = CarService.Instance;
                Car car = new Car();

                car.SerialNo = textBox1.Text;
                car.Name = textBox2.Text;
                car.LicensePlate = textBox3.Text;
                car.IsRented = trueCheckBox.Checked;

                carService.AddCar(car);

                ListCarForm listCarForm = new ListCarForm();
                this.Hide();
                listCarForm.Show();
            }
        }

        public bool SerialNoControl()
        {
            string serialNo = textBox1.Text;
            string nums = "0123456789";

            bool control = false;
            bool baseControl = true;
            try
            {
                if (serialNo.Length > 5)
                {
                    MessageBox.Show("Seri numarasının boyutu 5'ten büyük olamaz");
                    baseControl = false;
                }
                if (serialNo.Length < 5)
                {
                    MessageBox.Show("Seri numarasının boyutu 5'ten küçük olamaz");
                    baseControl = false;
                }

                for (int i = 0; i < serialNo.Length; i++)
                {
                    foreach (char s in nums)
                    {
                        if (s == serialNo[i])
                        {
                            control = true;
                            break;
                        }
                    }
                    if (!control)
                    {
                        MessageBox.Show("Seri numarasında harf bulunamaz");
                        baseControl = false;
                        break;
                    }
                    control = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return baseControl;
        }

        public bool NameControl()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Aracın ismini giriniz!");
                return false;
            }
            return true;
        }

        public bool LicensePlateControl()
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen araç plakasını giriniz!");
                return false;
            }
            return true;
        }
        
        public bool RentCheckBoxControl()
        {
            if (trueCheckBox.Checked == false && falseCheckBox.Checked == false)
            {
                MessageBox.Show("Araç kiralandı mı?");
                return false;
            }
            return true;
        }

        private void trueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trueCheckBox.Checked == true)
            {
                falseCheckBox.Checked = false;
            }
        }

        private void falseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (falseCheckBox.Checked == true)
            {
                trueCheckBox.Checked = false;
            }
        }
    }
}
