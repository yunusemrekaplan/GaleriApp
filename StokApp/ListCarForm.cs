using StokApp.Models;
using StokApp.Services;
using System;
using System.Collections;
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
        /*
        private static readonly ListCarForm _singleton = new ListCarForm();
        public static ListCarForm Instance { get { return _singleton; } }
        */
        
        CarService carService = CarService.Instance;
        bool columnClick = true;
        public ListCarForm()
        {
            try
            {
                //MessageBox.Show(cars.Count.ToString());

                InitializeComponent();

                //Controls.Add(listView2);
                

                ListViewBuildAllCars();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListViewBuildAllCars()
        {
            //cars = carService.GetCarsFromDb();
            List<string[]> rows = new List<string[]>();

            foreach (Car car in carService.Cars!)
            {
                string[] row = { car.SerialNo!.ToString(), car.Brand!, car.Model!.ToString(), car.YearProd.ToString(), car.Gear!.ToString(), car.Plate!.ToString(), (car.IsRented == true ? "Müşteride" : "Stokta") };
                rows.Add(row);
            }
            listView2.Columns.Add("Seri No", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Marka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Model", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Yıl", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Vites", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 75, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        public void ListViewBuildRented()
        {
            //cars = carService.GetCarsFromDb();
            List<string[]> rows = new List<string[]>();

            foreach (Car car in carService.Cars!)
            {
                if (car.IsRented)
                {
                    string[] row = { car.SerialNo!.ToString(), car.Brand!, car.Model!.ToString(), car.YearProd.ToString(), car.Gear!.ToString(), car.Plate!.ToString(), "Müşteride" };
                    rows.Add(row);
                }
            }
            listView2.Columns.Add("Seri No", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Marka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Model", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Yıl", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Vites", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 75, HorizontalAlignment.Left);

            foreach (string[] row in rows)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        public void ListViewBuildNotRented()
        {
            //cars = carService.GetCarsFromDb();
            List<string[]> rows = new List<string[]>();

            foreach (Car car in carService.Cars!)
            {
                if (!car.IsRented)
                {
                    string[] row = { car.SerialNo!.ToString(), car.Brand!, car.Model!.ToString(), car.YearProd.ToString(), car.Gear!.ToString(), car.Plate!.ToString(), "Stokta" };
                    rows.Add(row);
                }
            }
            listView2.Columns.Add("Seri No", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Marka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Model", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Yıl", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Vites", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Plaka", 75, HorizontalAlignment.Left);
            listView2.Columns.Add("Durum", 75, HorizontalAlignment.Left);

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
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = MainMenuForm.Instance;
            this.Hide();
            mainMenuForm.Show();
        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (columnClick)
            {
                this.listView2.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Descending);
                columnClick = false;
            }
            else
            {
                this.listView2.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
                columnClick = true;
            }

            // Sıralama özelliği etkinleştirilir
            this.listView2.Sort();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ListCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}

public class ListViewItemComparer : IComparer
{
    private int col;
    private SortOrder order;

    public ListViewItemComparer(int column, SortOrder order)
    {
        col = column;
        this.order = order;
    }

    public int Compare(object? x, object? y)
    {
        int result = String.Compare(((ListViewItem)x!).SubItems[col].Text, ((ListViewItem)y!).SubItems[col].Text);

        if (order == SortOrder.Descending)
        {
            result *= -1;
        }

        return result;
    }
}
