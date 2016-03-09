using System;
using System.Configuration;
using System.Windows.Forms;

namespace CourseWork.Input
{
    public partial class InputOfAdmin : Form
    {
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
            try
            {
                var check = new CheckInput();
                if (!check.Check(ConfigurationManager.AppSettings["AdminPath"], Login.Text, Password.Text))
                {
                    MessageBox.Show(@"Некорректные данные для входа");
                    return;
                }
                else
                {
                    var main = new Main();
                    main.Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
