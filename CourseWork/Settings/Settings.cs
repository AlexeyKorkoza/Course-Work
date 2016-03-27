using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Input;

namespace CourseWork
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           Hide();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                var check = new CheckInput();
                foreach (var control in Controls.OfType<TextBox>().Where(control => control.Text.Length == 0))
                {
                    MessageBox.Show(@"Поле должно быть заполнено!");
                    control.BackColor = Color.Yellow;
                    return;
                }
                const string pattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\w+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(newpassword.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Пароль должен содержать строчные и прописные латинские буквы, цифры, спецсимволы. Минимум 8 символов");
                    return;
                }
                if (!check.Check(ConfigurationManager.AppSettings["AdminPath"], "admin", oldpassword.Text))
                {
                    MessageBox.Show(@"Проверьте введенные данные");
                    return;
                }
                var sw = new StreamWriter(ConfigurationManager.AppSettings["AdminPath"], false);
                sw.Close();
                var formatter = new BinaryFormatter();
                var fs = new FileStream(ConfigurationManager.AppSettings["AdminPath"], FileMode.Open);
                var admin = new Admin("admin", newpassword.Text);
                formatter.Serialize(fs, admin);
                fs.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void oldpassword_TextChanged(object sender, EventArgs e)
        {
           oldpassword.BackColor = Color.White;
        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            newpassword.BackColor = Color.White;
        }
    }
}