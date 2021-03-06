﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CourseWork.Client;
using CourseWork.Data;
using CourseWork.Direction;
using CourseWork.Discounts;
using CourseWork.Input;
using CourseWork.Properties;
using CourseWork.Service;

namespace CourseWork
{
    public partial class Main : Form
    {
        private List<Data.Models.Client> _list = new List<Data.Models.Client>();
        private OpenFileDialog _open;
        private readonly IStorage _storage = new Storage();
        private readonly List<string> _agecategory = new List<string>{"Несовершеннолетний","Взрослый","Пожилой(от 65)"};
        private readonly List<string> _payment = new List<string>{"Наличный","Безналичный"};
        private readonly List<string> _decor = new List<string>{"По телефону","По прибытию"}; 
        private readonly List<string> _visit = new List<string>{"Одноразовое","Многоразовое"}; 
        public Main()
        {
            try
            {
                InitializeComponent();
                CurrentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                CurrentDate.Text = CurrentDate.Text.Replace('.', '/');
                button7.Enabled = false;
                RefreshDg(CurrentDate.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!monthCalendar1.Visible)
            {
                monthCalendar1.Show();
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var massive = monthCalendar1.SelectionStart.ToString(CultureInfo.InvariantCulture).Split(' ');
            CurrentDate.Text = massive[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            datagridViewClients.Rows.Clear();
            RefreshDg(CurrentDate.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            datagridViewClients.Rows.Clear();
            RefreshDg(CurrentDate.Text);
        }

        private void RefreshDg(string currentdate)
        {
            try
            {
                var clients = _storage.GetClientByDate(currentdate);
                if (clients.Count > 0)
                {
                    button7.Enabled = true;
                    for (var i = 0; i < clients.Count; i++)
                    {
                        datagridViewClients.Rows.Add();
                        var massive = clients[i].Id.Split('/');
                        datagridViewClients.Rows[i].Cells[0].Value = Convert.ToInt32(massive[1]);
                        datagridViewClients.Rows[i].Cells[1].Value = clients[i].Lastname;
                        datagridViewClients.Rows[i].Cells[2].Value = clients[i].Name;
                        datagridViewClients.Rows[i].Cells[3].Value = clients[i].MiddleName;
                        datagridViewClients.Rows[i].Cells[5].Value = clients[i].AgeCategory;
                        datagridViewClients.Rows[i].Cells[4].Value = clients[i].Date;
                        datagridViewClients.Rows[i].Cells[6].Value = clients[i].Payment;
                        datagridViewClients.Rows[i].Cells[7].Value = clients[i].Decor;
                        datagridViewClients.Rows[i].Cells[8].Value = clients[i].Visit;
                        datagridViewClients.Rows[i].Cells[9].Value = clients[i].Directions[0].NameOfDirection;
                        datagridViewClients.Rows[i].Cells[10].Value = clients[i].Services[0].NameService;
                        datagridViewClients.Rows[i].Cells[11].Value = clients[i].Services[0].Duration;
                        datagridViewClients.Rows[i].Cells[12].Value = clients[i].Services[0].Cost;
                        datagridViewClients.Rows[i].Cells[13].Value = clients[i].Discounts[0].Code;
                        datagridViewClients.Rows[i].Cells[14].Value = clients[i].Discounts[0].Size;
                    }
                }
                else
                {
                    button7.Enabled = false;
                    MessageBox.Show(@"Сегодня клиентов нету!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            if (datagridViewClients.CurrentRow != null)
                            {
                                var index = datagridViewClients.CurrentRow.Index;
                                var id = datagridViewClients.Rows[index].Cells[0].Value.ToString();
                                _storage.DeleteClient(id);
                            }
                            MessageBox.Show(@"Данные успешно удалены!");
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите строку для удаления");
            }
        }

        private void datagridViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagridViewClients.CurrentRow == null) return;
            var index = datagridViewClients.CurrentRow.Index;
            var id = datagridViewClients.Rows[index].Cells[0].Value.ToString();
            var editClient = new EditClient(id);
            editClient.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var search = new SearchClient();
            search.Show();
        }

        private void ViewDirections_Click(object sender, EventArgs e)
        {
            var view = new ViewDirection();
            view.Show();
        }

        private void ViewServices_Click(object sender, EventArgs e)
        {
            var view = new ViewService();
            view.Show();
        }

        private void AddClientFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                var file = new FileExtension.FileExtension();
                _open = new OpenFileDialog
                {
                    Filter = Resources.ViewService_FileExtension_Click____csv____txt____csv___txt
                };
                _open.ShowDialog();
                if (_open.FileName == "") return;
                if (_open.ShowDialog() != DialogResult.OK) return;
                _list = file.LoadingClients(_open.FileName);
                foreach (var t in _list)
                {
                    var flag = true;
                    var count = 0;
                    for (var k = 0; k < _agecategory.Count; k++)
                    {
                        if (t.AgeCategory == _agecategory[k])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        flag = false;
                    }
                    count = 0;
                    for (var k = 0; k < _decor.Count; k++)
                    {
                        if (t.Decor == _decor[k])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        flag = false;
                    }
                    count = 0;
                    for (var k = 0; k < _payment.Count; k++)
                    {
                        if (t.Payment == _payment[k])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        flag = false;
                    }
                    count = 0;
                    for (var k = 0; k < _visit.Count; k++)
                    {
                        if (t.Visit == _visit[k])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        flag = false;
                    }
                    if (!flag) continue;
                    var client = new Data.Models.Client
                    {
                        Id = "clients/",
                        Lastname = t.Lastname,
                        Name = t.Name,
                        MiddleName = t.MiddleName,
                        Date = t.Date,
                        AgeCategory = t.AgeCategory,
                        Decor = t.Decor,
                        Payment = t.Payment,
                        Visit = t.Visit,
                        Directions = new List<Data.Models.Direction>()
                        {
                            new Data.Models.Direction()
                            {
                                NameOfDirection = t.Directions[0].NameOfDirection
                            }
                        },
                        Services = new List<Data.Models.Service>()
                        {
                            new Data.Models.Service()
                            {
                                NameService = t.Services[0].NameService,
                                Cost = t.Services[0].Cost,
                                Duration = t.Services[0].Duration
                            }
                        },
                        Discounts = new List<Data.Models.Discount>()
                        {
                            new Data.Models.Discount()
                            {
                                Code = t.Discounts[0].Code,
                                Size = t.Discounts[0].Size
                            }
                        }
                    };
                    _storage.AddClient(client);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var view = new ViewDiscounts();
            view.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                datagridViewClients.Rows.Clear();
                var clients = _storage.GetAllClients();
                if (clients.Count > 0)
                {
                    button7.Enabled = true;
                    for (var i = 0; i < clients.Count; i++)
                    {
                        datagridViewClients.Rows.Add();
                        var massive = clients[i].Id.Split('/');
                        datagridViewClients.Rows[i].Cells[0].Value = Convert.ToInt32(massive[1]);
                        datagridViewClients.Rows[i].Cells[1].Value = clients[i].Lastname;
                        datagridViewClients.Rows[i].Cells[2].Value = clients[i].Name;
                        datagridViewClients.Rows[i].Cells[3].Value = clients[i].MiddleName;
                        datagridViewClients.Rows[i].Cells[5].Value = clients[i].AgeCategory;
                        datagridViewClients.Rows[i].Cells[4].Value = clients[i].Date;
                        datagridViewClients.Rows[i].Cells[6].Value = clients[i].Payment;
                        datagridViewClients.Rows[i].Cells[7].Value = clients[i].Decor;
                        datagridViewClients.Rows[i].Cells[8].Value = clients[i].Visit;
                        datagridViewClients.Rows[i].Cells[9].Value = clients[i].Directions[0].NameOfDirection;
                        datagridViewClients.Rows[i].Cells[10].Value = clients[i].Services[0].NameService;
                        datagridViewClients.Rows[i].Cells[11].Value = clients[i].Services[0].Duration;
                        datagridViewClients.Rows[i].Cells[12].Value = clients[i].Services[0].Cost;
                        datagridViewClients.Rows[i].Cells[13].Value = clients[i].Discounts[0].Code;
                        datagridViewClients.Rows[i].Cells[14].Value = clients[i].Discounts[0].Size;
                    }
                }
                else
                {
                    button7.Enabled = false;
                    MessageBox.Show(@"Сегодня клиентов нету!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}