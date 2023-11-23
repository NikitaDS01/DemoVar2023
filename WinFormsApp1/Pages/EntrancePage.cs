using DemoVar2023.Classes.Database;
using DemoVar2023.Classes.Programm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoVar2023.Pages
{
    public partial class EntrancePage : Form
    {
        private int _width;
        private int _height;
        public EntrancePage()
        {
            InitializeComponent();
            _width = this.Width;
            _height = this.Height;
        }

        private void txtBoxChanged(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == string.Empty)
            {
                StatusButton(false);
                return;
            }
            if (txtBoxPassword.Text == string.Empty)
            {
                StatusButton(false);
                return;
            }
            StatusButton(true);
        }
        private void StatusButton(bool value)
        {
            btnEntrance.Enabled = value;
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;
            var list = TemplateDatabase.GetListUser();
            var result = list.Where(user => user.Password == password
                                    && user.Login == login);
            if (result.Count() == 1)
            {
                CurrentUser.SetUser(result.First());
                OrderListPage page = new OrderListPage();
                this.Hide();
                page.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны");
            }
        }

        private void EntrancePage_SizeChanged(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }
    }
}
