using StokApp.Models;
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
    public partial class UpdateCarForm : Form
    {
        public UpdateCarForm(Car car)
        {
            InitializeComponent();

            label6.Text = car.SerialNo;
            textBox1.Text = car.Name;
            textBox2.Text = car.LicensePlate;
            textBox3.Text = car.IsRented.ToString();
        }
    }
}
