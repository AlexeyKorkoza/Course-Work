using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class EditService : Form
    {
        private string _id;
        IStorage storage = new Storage();
        public EditService(string id)
        {
            InitializeComponent();
            _id = id;
            DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
            NewNameService.BackColor = Color.White;
            View();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var pattern = "[A-Za-zА-Яа-я]";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(NewNameService.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                pattern = "[0-9]";
                regex = new Regex(pattern, RegexOptions.IgnoreCase);
                match = regex.Match(Duration.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                match = regex.Match(CostService.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                var service = storage.GetServiceId(_id);
                service.NameOfDirection = DirectionName.Text;
                if (changeNameService.Checked)
                {
                    service.Services[0].NameService = NewNameService.Text;
                }
                else
                {
                    service.Services[0].NameService = NameService.Text;
                }
                service.Services[0].Duration = Convert.ToInt32(Duration.Text);
                service.Services[0].Cost = Convert.ToInt32(CostService.Text);
                storage.UpdateService(service);
                MessageBox.Show(@"Услуга успешно редактирована");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void View()
        {
            try
            {
                var service = storage.GetServiceId(_id);
                DirectionName.Text = service.NameOfDirection;
                NameService.Text = service.Services[0].NameService;
                Duration.Text = service.Services[0].Duration.ToString();
                CostService.Text = service.Services[0].Cost.ToString();
                var direction = storage.GetDirections();
                foreach (var t in direction)
                {
                    if (!DirectionName.Items.Contains(t.NameOfDirection))
                    {
                        DirectionName.Items.Add(t.NameOfDirection);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changeNameService_CheckedChanged(object sender, EventArgs e)
        {
            if (changeNameService.Checked)
            {
                NewNameService.Enabled = true;
            }
            else
            {
                NewNameService.Enabled = false;
            }
        }
    }
}
