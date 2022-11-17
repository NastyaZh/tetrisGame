using System.Collections.Generic;
using System.Drawing;
using tetrisGame.Classes;
using tetrisGame.Utilities;

namespace tetrisGame.Controller
{
    internal class CreateBlockController
    {
        
        public CreateBlockController()
        {

        }
        public Block CreateBlock(int[,] blockArray)
        {
            GetSizeBlock(blockArray, out int sizeXMin, out int sizeXMax, out int sizeYMin, out int sizeYMax);

            Block block = new Block(sizeYMax - sizeYMin + 1, sizeXMax - sizeXMin + 1, 0,0);

            

            for (int j = sizeYMin; j <= sizeYMax; j++)
            {
                for (int i = sizeXMin; i <= sizeXMax; i++)
                {
                    if (blockArray[i, j] == 1)
                    {
                        block.Shape[j - sizeYMin,i - sizeXMin] = (1, Color.LightBlue);
                    }
                }
                
            }
            return block;
        }
        public List<Block> CreateBlockList()
        {
            return JsonWorker.ReadJson();
        }


        public bool SavePressCommand(Block block)
        {
            List <Block> blocks = CreateBlockList();
            blocks.Add(block);
            return JsonWorker.WriteJson(blocks);
        }

        private void GetSizeBlock(int[,] blockArray, out int sizeXMin, out int sizeXMax, out int sizeYMin, out int sizeYMax)
        {
            sizeXMin = blockArray.GetLength(0);
            sizeXMax = 0;
            sizeYMin = blockArray.GetLength(1);
            sizeYMax = 0;
            

            for (int i = 0; i < blockArray.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < blockArray.GetLength(1); j++)
                {
                    if (blockArray[i,j] == 1)
                    {
                        if (sizeYMin > j)
                        {
                            sizeYMin = j;
                        }
                        if (sizeYMax <= j)
                        {
                            sizeYMax = j;
                        }
                        count++;
                    }
                }
                if (count > 0)
                {
                    if (sizeXMin > i)
                    {
                        sizeXMin = i;
                    }
                    if (sizeXMax <= i)
                    {
                        sizeXMax = i;
                    }
                }
            }
        }
    }
}
