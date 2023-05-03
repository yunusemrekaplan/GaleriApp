using StokApp.Models;
using StokApp.Services;
using System;

namespace StokApp
{
    public partial class Form1 : Form
    {
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
                            MainMenuForm mainMenuForm= new MainMenuForm();
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
    }
}