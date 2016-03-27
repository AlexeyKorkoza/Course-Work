using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class EditDirection : Form
    {
        private List<Data.Models.Direction> _direction;
        IStorage storage = new Storage();
        public EditDirection()
        {
            InitializeComponent();
            View();
        }

        private void ChangeDirectionName_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeDirectionName.Checked)
            {
                NewDirection.Enabled = true;
            }
            else
            {
                NewDirection.Enabled = false;
            }
        }

        private void View()
        {
            try
            {
                _direction = storage.GetDirections();
                foreach (var t in _direction)
                {
                        DirectionName.Items.Add(t.NameOfDirection);
                }
                DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DirectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Description.Text = string.Empty;
            try
            {
                Description.Text = string.Empty;
                foreach (var t in _direction)
                {
                    if (t.NameOfDirection == DirectionName.Text)
                    {
                        Description.Text = t.Description;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            View();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectionName.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите направление для редактировании!");
                    return;
                }
                if (Description.Text.Length == 0)
                {
                    MessageBox.Show(@"Описание отсутствует!");
                    return;
                }
                if (ChangeDirectionName.Checked)
                {
                    if (NewDirection.Text.Length == 0)
                    {
                        MessageBox.Show(@"Введите название направления!");
                        return;
                    }
                }
                var editDirection = storage.GetDirectionsDirectionName(DirectionName.Text);
                if (ChangeDirectionName.Checked)
                {
                    editDirection.NameOfDirection = NewDirection.Text;
                }
                else
                {
                    editDirection.NameOfDirection = DirectionName.Text;
                }
                editDirection.Description = Description.Text;
                storage.UpdateDirection(editDirection);
                MessageBox.Show(@"Данные успешно отредактированы!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}