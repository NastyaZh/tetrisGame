using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetrisGame.Views
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }
        protected void ReplaceCurrentForm(Form form)
        {
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Show(); };
            form.Show();
            Hide();
        }
    }
}
