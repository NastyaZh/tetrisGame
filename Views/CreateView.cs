using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tetrisGame.Controller;
namespace tetrisGame.Views
{
    public partial class CreateView : Form
    {
        public CreateView()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int[,] blockArray = new int[4,4];
            int count = 0;
            bool statusInputData = true;
            this.Controls.Cast<Control>().OfType<Button>().ToList().ForEach(item =>
            {
                if (!(item.Tag is null))
                {
                    int i = Int32.Parse(item.Tag.ToString().Substring(0, 1));
                    int j = Int32.Parse(item.Tag.ToString().Substring(1, 1));
                    
                    blockArray[i,j] = item.BackColor != Color.LightGreen ? 1 : 0;
                }
                
            });
            for (int i = 0; i < blockArray.GetLength(0); i++)
            {
                for (int j = 0; j < blockArray.GetLength(1); j++)
                {
                    if (blockArray[i,j] == 1)
                    {
                        count++;

                        if(!CheckNeighbor(blockArray, i, j))
                        {
                            MessageBox.Show("Wrong block will be discarded", "You can't create this block.");
                            string tagString = i.ToString() + j.ToString();
                            this.Controls.Cast<Control>().OfType<Button>().ToList().ForEach(item =>
                            {
                                if (!(item.Tag is null) && item.Tag.ToString() == tagString)
                                {
                                    item.BackColor = Color.LightGreen;
                                }

                            });
                            statusInputData = false;
                        }
                    }
                }
            }
            if (count > 8 || count < 2)
            {
                MessageBox.Show("Number of blocks should not be more than 8 and less then 2", "You can't create this block.");
                statusInputData = false;
            }

            if (statusInputData)
            {
                var newBlock = new CreateBlockController();
                if (newBlock.SavePressCommand(newBlock.CreateBlock(blockArray)))
                {
                    MessageBox.Show("New block saved successfully", "Save this block.");
                }
                else
                {
                    MessageBox.Show("There was a problem saving the block", "Save this block.");
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.BackColor == Color.LightGreen ? Color.Plum : Color.LightGreen;
        }

        private bool CheckNeighbor(int[,] array, int posI, int posJ)
        {
            if (posI - 1 >= 0 && array[posI - 1, posJ] == 1)
            {
                return true;
            }

            if (posI + 1 < array.GetLength(0) && array[posI + 1,posJ] == 1)
            {
                return true;
            }

            if (posJ - 1 >= 0 && array[posI, posJ - 1] == 1)
            {
                return true;
            }

            
            if (posJ + 1 < array.GetLength(1) && array[posI, posJ + 1] == 1)
            {
                return true;
            }

            return false;
        }
    }
}
