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
    public partial class CarInfoForm : Form
    {
        Car? car;
        public CarInfoForm(Car car)
        {
            this.car = car;
            InitializeComponent();

            txtSeriNo.Text = car.SerialNo.ToString();
            textBoxBrand.Text = car.Brand!.ToString();
            textBoxModel.Text = car.Model!.ToString();
            textBoxYear.Text = car.YearProd.ToString();
            textBoxGear.Text = car.Gear!.ToString();
            textBoxPlate.Text = car.Plate!.ToString();

            if (car.IsRented)
            {
                checkBoxYes.Checked = true;
            }
            else
            {
                checkBoxNo.Checked = true;
            }
        }

        private bool ControlInfos()
        {
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ControlInfos())
            {
                CarService carService = CarService.Instance;

                car!.Brand = textBoxBrand.Text;
                car.Model = textBoxModel.Text;
                car.YearProd = int.Parse(textBoxYear.Text);
                car.Gear = textBoxGear.Text;
                car.Plate = textBoxPlate.Text;
                car.IsRented = checkBoxYes.Checked;

                carService.UpdateCar(car);
                this.Hide();

                ListCarForm listCarForm = new ListCarForm();
                listCarForm.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CarService carService = CarService.Instance;
            carService.DeleteCar(car!);

            ListCarForm listCarForm = new ListCarForm();
            this.Hide();
            listCarForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ListCarForm listCarForm = new ListCarForm();
            this.Hide();
            listCarForm.Show();
        }
    }
}
