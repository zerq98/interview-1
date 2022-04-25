using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Task1
{
    public class Task1Code
    {
        private int[] tab;
        private Random rand;
        private List<int> thirdSelection;
        private List<int> averages;
        private List<int> moreThan90;

        public Task1Code()
        {
            GenerateArray();
            GenerateLists();
            MultiplyElements();
            DisplayGrowingElements();
        }

        private void DisplayGrowingElements()
        {
            for(int i = 0; i < tab.Length; i++)
            {
                int[] modifiedTab=new int[tab.Length];
                var growingSequences = new List<int[]>();
                tab.CopyTo(modifiedTab, 0);
                if (i > 0)
                {
                    var temp = modifiedTab[i];
                    modifiedTab[i] = modifiedTab[i - 1];
                    modifiedTab[i - 1] = temp;
                }

                for(int j = 0; j < modifiedTab.Length-2; j++)
                {
                    if(modifiedTab[j]<modifiedTab[j+1] && modifiedTab[j + 1] < modifiedTab[j + 2])
                    {
                        growingSequences.Add(new int[] { modifiedTab[j], modifiedTab[j + 1], modifiedTab[j + 2] });
                    }
                }
                DisplayGrowingElementsInfo(i, modifiedTab, growingSequences);
            }
        }

        private void DisplayGrowingElementsInfo(int tabNumber,int[] tab,List<int[]> growingSequences)
        {
            if (tabNumber == 0)
            {
                DisplayInfo($"pierwotna tablica T{tabNumber}", tab);
            }
            else
            {
                DisplayInfo($"tablica T{tabNumber} z zmianą elementów {tabNumber-1} i {tabNumber} względem tablicy T0", tab);
            }

            DisplayInfo($"sekwencje rosnące w T{tabNumber}", growingSequences);
            Console.WriteLine("Liczba sekwencji: " + growingSequences.Count);
            Console.WriteLine("zamieniona para: " + (tabNumber == 0 ? "brak" : $"{tabNumber - 1} i {tabNumber}"));
            Console.WriteLine();

        }

        private void MultiplyElements()
        {
            var display = "Pomnożone indeksy: ";
            var baseMultiplier = 0;
            while (baseMultiplier < tab.Length)
            {
                for (int i = 0; i < 200; i++)
                {
                    if ((tab[baseMultiplier] * tab[i]) > 9000)
                    {
                        display += $"({baseMultiplier},{i})";
                    }
                }
                baseMultiplier++;
            }

            Console.WriteLine(display);
            Console.WriteLine();
        }

        private void GenerateLists()
        {
            thirdSelection = new List<int>();
            averages = new List<int>();
            moreThan90 = new List<int>();

            for(int i = 199; i >= 0; i -= 3)
            {
                thirdSelection.Add(tab[i]);
            }
            DisplayInfo("Lista z co trzecią liczbą", thirdSelection);

            averages.Add((50 + tab[0] + tab[1]) / 3);
            for (int i = 1; i < 199; i++)
            {
                averages.Add((tab[i - 1] + tab[i] + tab[i + 1]) / 3);
            }
            averages.Add((50 + tab[tab.Length-2] + tab[tab.Length-1]) / 3);
            DisplayInfo("Lista ze średnimi", averages);

            for (int i = 0; i < 200; i++)
            {
                if (tab[i] > 90)
                {
                    moreThan90.Add(tab[i]);
                }
            }
            DisplayInfo("Lista z liczbami większymi od 90", moreThan90);
        }

        private void GenerateArray()
        {
            tab = new int[200];
            rand = new Random();

            for (int i = 0; i < 200; i++)
            {
                tab[i] = rand.Next(0, 100);
            }

            DisplayInfo("Pierwotna tablica", tab);
        }

        private void DisplayInfo(string collectionName,int[] collection)
        {
            string display = $"{collectionName}: [";
            foreach(int element in collection)
            {
                display += $"{element},";
            }

            display = display.Remove(display.Length - 1);
            display += "]";
            Console.WriteLine(display);
            Console.WriteLine();
        }

        private void DisplayInfo(string collectionName, List<int[]> collection)
        {
            Console.Write($"{collectionName}: ");
            foreach (int[] element in collection)
            {
                var seqDisplay = "[";
                foreach(int innerElement in element)
                {
                    seqDisplay += $"{innerElement},";
                }
                seqDisplay = seqDisplay.Remove(seqDisplay.Length - 1);
                seqDisplay += "], ";
                Console.Write(seqDisplay);
            }

            Console.WriteLine();
        }

        private void DisplayInfo(string collectionName, List<int> collection)
        {
            string display = $"{collectionName}: [";
            foreach (int element in collection)
            {
                display += $"{element},";
            }

            display = display.Remove(display.Length - 1);
            display += "]";
            Console.WriteLine(display);
            Console.WriteLine();
        }
    }
}
