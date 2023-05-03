using StokApp.Models;
using StokApp.Services;
using System;

namespace StokApp
{
    public partial class Form1 : Form
    {
        private static readonly Form1 _singleton = new Form1();
        public static Form1 Instance { get { return _singleton; } }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nickname = textBox1.Text;
            string password = textBox2.Text;
            bool nameControl = false;
            try
            {
                PersonService personServiceInstance = PersonService.Instance;
                List<Person> persons = personServiceInstance.GetPersonsFromDb();

                foreach (var person in persons)
                {
                    if (person.Nickname == nickname)
                    {
                        nameControl = true;
                        if (person.Password == password)
                        {
                            MainMenuForm mainMenuForm = MainMenuForm.Instance;
                            this.Hide();
                            mainMenuForm.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password!!");
                            break;
                        }
                    }
                }
                if (!nameControl)
                {
                    MessageBox.Show("Name Not Found!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}