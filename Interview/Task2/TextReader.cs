using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TextReader
    {
        private List<LetterData> letterData;

        public TextReader()
        {
            letterData = new List<LetterData>();
        }

        public void ReadText(string filePath)
        {
            string text = System.IO.File.ReadAllText(filePath);

            foreach(char c in text)
            {
                if (Char.IsLetter(c))
                {
                    var letterInList = letterData.FirstOrDefault(x => x.Letter == c);
                    if (letterInList != null)
                    {
                        letterData[letterData.IndexOf(letterInList)].Count++;
                    }
                    else
                    {
                        letterData.Add(new LetterData
                        {
                            Letter = c,
                            Count = 1
                        });
                    }
                }
            }
        }

        public List<string> GetLetters(bool orderByCount)
        {
            decimal max = letterData.Sum(x=>x.Count);
            if (orderByCount)
            {
                return letterData.OrderBy(x => x.Count).Select(x=> $"{x.Letter} - {x.Count} / {Math.Round(x.Count/max * 100, 2)}%").ToList();
            }
            else
            {
                return letterData.OrderBy(x => x.Letter).Select(x => $"{x.Letter} - {x.Count} / {Math.Round(x.Count / max * 100, 2)}%").ToList();
            }
        }
    }
}
