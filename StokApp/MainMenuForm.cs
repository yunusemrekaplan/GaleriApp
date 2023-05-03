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
    public partial class MainMenuForm : Form
    {

        private static readonly MainMenuForm _singleton = new MainMenuForm();

        public static MainMenuForm Instance { get { return _singleton; } }

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListCarForm listCarForm = new ListCarForm();
            this.Hide();
            listCarForm.Show();
        }
    }
}
