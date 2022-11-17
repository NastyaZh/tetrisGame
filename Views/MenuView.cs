using System;
using System.Windows.Forms;

namespace tetrisGame.Views
{
    public partial class MenuView : View
    {
        public MenuView()
        {
            InitializeComponent();
            WidthNumericUpDown.Minimum = 15;
            WidthNumericUpDown.Maximum = 25;
            HeightNumericUpDown.Minimum = 20;
            HeightNumericUpDown.Maximum = 30;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameView form = new GameView();
            form.SettngHeightLabel.Text = HeightNumericUpDown.Value.ToString();
            form.SettingWidthLabel.Text = WidthNumericUpDown.Value.ToString();
            ReplaceCurrentForm(form);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ReplaceCurrentForm(new CreateView());
        }
    }
}
