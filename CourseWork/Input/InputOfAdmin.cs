using System;
using System.Configuration;
using System.Windows.Forms;
using CourseWork.Input;

namespace CourseWork
{
    public partial class InputOfAdmin : Form
    {
        public static string Filename = ConfigurationManager.AppSettings["AdminPath"];
        public InputOfAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var check = new CheckInput();
            if (!check.Check(Filename, Login.Text, Password.Text))
            {
                MessageBox.Show(@"Проверьте введенные данные");
                return;
            }
            else
            {
                var main = new Main();
                main.Show();
                Close();
            }
        }
    }
}
