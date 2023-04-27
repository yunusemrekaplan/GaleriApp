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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokApp
{
    public partial class ListCarForm : Form
    {
        List<Car>? cars;
        public ListCarForm()
        {

            CarService carService = CarService.Instance;
            cars = carService.GetCarsFromDb();
            //MessageBox.Show(cars.Count.ToString());

            InitializeComponent();

            //Controls.Add(listView2);


            ListViewBuildAllCars();
        }

        public void ListViewBuildAllCars()
        {
            List<string[]> rows = new List<string[]>();

            foreach (Car car in cars!)
            {
                string[] row = { car.SerialNo!.ToString(), car.Name!, car.LicensePlate!, (car.IsRented == true ? "Müşteride" : "Stokta") };
                rows.Add(row);
            }
            listView2.Columns.Add("Seri No", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("İsim", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 100, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        public void ListViewBuildRented()
        {
            List<string[]> rows = new List<string[]>();

            foreach (Car car in cars!)
            {
                if (car.IsRented)
                {
                    string[] row = { car.SerialNo!.ToString(), car.Name!, car.LicensePlate!, "Müşteride" };
                    rows.Add(row);
                }
            }
            listView2.Columns.Add("Seri No", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("İsim", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 100, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        public void ListViewBuildNotRented()
        {
            List<string[]> rows = new List<string[]>();

            foreach (Car car in cars!)
            {
                if (!car.IsRented)
                {
                    string[] row = { car.SerialNo!.ToString(), car.Name!, car.LicensePlate!, "Stokta" };
                    rows.Add(row);
                }
            }
            listView2.Columns.Add("Seri No", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("İsim", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 100, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            ListViewBuildAllCars();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            ListViewBuildRented();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            ListViewBuildNotRented();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            this.Hide();
            addCarForm.Show();
        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Tıklanan öğeyi al
                ListViewItem clickedItem = listView2.GetItemAt(e.X, e.Y)!;

                if (clickedItem != null)
                {
                    foreach (Car car in cars!)
                    {
                        if (car.SerialNo == clickedItem.Text)
                        {
                            CarInfoForm carInfoForm = new CarInfoForm(car);
                            this.Hide();
                            carInfoForm.Show();
                            break;
                        }
                    }
                }
            }
        }
    }
}
