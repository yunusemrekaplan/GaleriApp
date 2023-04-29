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

            label6.Text = car.SerialNo;
            textBox1.Text = car.Name;
            textBox2.Text = car.LicensePlate;
            if (car.IsRented)
            {
                trueCheckBox.Checked = true;
            }
            else
            {
                falseCheckBox.Checked = true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControlInfos())
            {
                CarService carService = CarService.Instance;

                car!.Name = textBox1.Text;
                car!.LicensePlate = textBox2.Text;
                car!.IsRented = trueCheckBox.Checked;

                carService.UpdateCar(car);

                ListCarForm listCarForm = new ListCarForm();
                this.Hide();
                listCarForm.Show();
            }
        }

        private bool ControlInfos()
        {
            if (!NameControl())
            {
                return false;
            }
            if (!LicensePlateControl())
            {
                return false;
            }
            if (!RentCheckBoxControl())
            {
                return false;
            }
            return true;
        }

        public bool NameControl()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Aracın ismini giriniz!");
                return false;
            }
            return true;
        }

        public bool LicensePlateControl()
        {
            if (textBox2.Text == "")
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

        private void button2_Click(object sender, EventArgs e)
        {
            CarService carService = CarService.Instance;
            carService.DeleteCar(car);

            ListCarForm listCarForm = new ListCarForm();
            this.Hide();
            listCarForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListCarForm listCarForm = new ListCarForm();
            this.Hide();
            listCarForm.Show();
        }

        
    }
}
