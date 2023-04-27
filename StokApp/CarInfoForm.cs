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
    public partial class CarInfoForm : Form
    {
        Car? car;
        public CarInfoForm(Car car)
        {
            this.car = car;
            InitializeComponent();

            
        }
    }
}
