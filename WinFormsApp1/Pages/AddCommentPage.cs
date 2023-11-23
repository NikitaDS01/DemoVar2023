using DemoVar2023.Classes.Database;
using DemoVar2023.Classes.Database.Enum;
using DemoVar2023.Classes.Database.Table;
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
    public partial class AddCommentPage : Form
    {
        private Order _order;
        private int _width;
        private int _height;
        public AddCommentPage(Order order)
        {
            _order = order;
            InitializeComponent();

            txtBoxIndex.Text = _order.Id.ToString();
            _width = this.Width;
            _height = this.Height;
        }

        private void textBoxChanged(object sender, EventArgs e)
        {
            if (txtBoxDescriptionError.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            btnAddOrder.Enabled = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            TemplateDatabase.UpdateExecutorOrder(_order, CurrentUser.GetUser(), txtBoxDescriptionError.Text);

            this.Close();
        }

        private void UpdateOrderPage_SizeChanged(object sender, EventArgs e)
        {
            _width = this.Width;
            _height = this.Height;
        }
    }
}
