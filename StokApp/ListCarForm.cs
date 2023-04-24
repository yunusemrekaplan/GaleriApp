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
    public partial class ListCarForm : Form
    {
        List<Car>? cars;
        public ListCarForm()
        {

            CarService carService = CarService.Instance;
            cars = carService.GetCarsFromDb();
            //MessageBox.Show(cars.Count.ToString());

            InitializeComponent();

            Controls.Add(listView1);

            List<string[]> rows = new List<string[]>();

            foreach (Car car in cars)
            {
                string[] row = { car.SerialNo.ToString(), car.Name!, car.LicensePlate! };
                rows.Add(row);
            }

            ListViewBuild(rows);
        }

        public void ListViewBuild(List<string[]> rows)
        {
            listView1.Columns.Add("Seri No", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("İsim", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Plaka", 100, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView1.Items.Add(new ListViewItem(row));
            }
        }

    }
}
