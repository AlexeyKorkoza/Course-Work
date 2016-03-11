using System;
using System.Windows.Forms;
using CourseWork.Client;
using CourseWork.Direction;
using CourseWork.Input;

namespace CourseWork
{
    public partial class Main : Form
    {
        public Main()
        {
          InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var setting = new Settings();
            setting.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new AddClient();
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var input = new InputOfAdmin();
            input.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var adddirection = new AddDirection();
            adddirection.Show();
        }
    }
}
