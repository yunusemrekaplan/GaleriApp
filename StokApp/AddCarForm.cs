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
using System.Windows.Forms.VisualStyles;

namespace StokApp
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ControlInfos())
            {
                CarService carService = CarService.Instance;
                ListCarForm listCarForm = new ListCarForm();
                Car car = new Car();

                car!.SerialNo = int.Parse(textBoxSeriNo.Text);
                car!.Brand = textBoxBrand.Text;
                car.Model = textBoxModel.Text;
                car.YearProd = int.Parse(textBoxYear.Text);
                car.Gear = textBoxGear.Text;
                car.Plate = textBoxPlate.Text;
                car.IsRented = checkBoxYes.Checked;

                carService.AddCar(car);
                this.Hide();
                //System.Threading.Thread.Sleep(1000);
                listCarForm.Show();
            }
        }

        private bool ControlInfos()
        {
            if (!SerialNoControl())
            {
                return false;
            }
            if (!BrandControl())
            {
                return false;
            }
            if (!ModelControl())
            {
                return false;
            }
            if (!YearControl())
            {
                return false;
            }
            if (!GearControl())
            {
                return false;
            }
            if (!PlateControl())
            {
                return false;
            }
            if (!RentCheckBoxControl())
            {
                return false;
            }
            return true;
        }
        public bool SerialNoControl()
        {
            string serialNo = textBoxSeriNo.Text;
            string nums = "0123456789";

            bool control = false;
            bool baseControl = true;
            try
            {
                if (serialNo.Length == 0)
                {
                    MessageBox.Show("Aracın seri numarasını girin!");
                    baseControl = false;
                }
                else if (serialNo.Length > 5)
                {
                    MessageBox.Show("Seri numarasının boyutu 5'ten büyük olamaz");
                    baseControl = false;
                }
                else if (serialNo.Length < 5)
                {
                    MessageBox.Show("Seri numarasının boyutu 5'ten küçük olamaz");
                    baseControl = false;
                }
                else
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return baseControl;
        }
        public bool BrandControl()
        {
            if (textBoxBrand.Text == "")
            {
                MessageBox.Show("Aracın markasını giriniz!");
                return false;
            }
            return true;
        }

        public bool ModelControl()
        {
            if (textBoxModel.Text == "")
            {
                MessageBox.Show("Aracın modelini giriniz!");
                return false;
            }
            return true;
        }

        public bool YearControl()
        {
            if (textBoxYear.Text == "")
            {
                MessageBox.Show("Aracın üretim yılını giriniz!");
                return false;
            }
            return true;
        }

        public bool GearControl()
        {
            if (textBoxGear.Text == "")
            {
                MessageBox.Show("Aracın vites türünü giriniz!");
                return false;
            }
            return true;
        }

        public bool PlateControl()
        {
            if (textBoxPlate.Text == "")
            {
                MessageBox.Show("Lütfen aracın plakasını giriniz!");
                return false;
            }
            return true;
        }

        public bool RentCheckBoxControl()
        {
            if (checkBoxYes.Checked == false && checkBoxNo.Checked == false)
            {
                MessageBox.Show("Araç kiralandı mı?");
                return false;
            }
            return true;
        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Checked = checkBoxYes.Checked == true ? false : true;
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxYes.Checked = checkBoxNo.Checked == true ? false : true;
        }

    }
}
