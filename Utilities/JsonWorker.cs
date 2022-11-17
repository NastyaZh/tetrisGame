using System;
using System.Collections.Generic;
using tetrisGame.Classes;
using System.IO;
using Newtonsoft.Json;

namespace tetrisGame.Utilities
{
    public static class JsonWorker
    {
        private static readonly string FilePath = $"..\\..\\Asserts\\block.json";

        public static bool WriteJson(List<Block> BlockList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    string json = JsonConvert.SerializeObject(BlockList, Formatting.Indented);
                    writer.WriteLine(json);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Block> ReadJson()
        {
            List<Block> BlockList;

            using (StreamReader file = File.OpenText(FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                BlockList = (List<Block>)serializer.Deserialize(file, typeof(List<Block>));
            }
            return BlockList;
        }
    }

    
}
