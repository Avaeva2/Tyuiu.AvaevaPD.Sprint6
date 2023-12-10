using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AvaevaPD.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18

    {
        public string CollectTextFromFile(string str, string path)
        {
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line; 
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains(str))
                        {
                            strLine += word + " ";
                        }
                    }
                }
            }
            return strLine.Trim();
        }

    }
}
