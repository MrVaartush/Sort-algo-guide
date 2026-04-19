using System;
using System.Collections.Generic;
using SortAlgoGuide.MyForms;

namespace SortAlgoGuide.MyUserControl.Practice
{
    internal class MyTemplates
    {

        

        public static int[] GetPattert(string Name) // отримати шаблон по назві
        {
            switch (Name)
            {
                case "random": return GetArrFromFile(Properties.Resources.Random);
                case "part": return GetArrFromFile(Properties.Resources.PartSorted);
                case "back": return GetArrFromFile(Properties.Resources.SortedBack);
                case "100_swaps": return GetArrFromFile(Properties.Resources.Sorted_100RandomSwaps_);
            }
            return null;
        }
        private static int[] GetArrFromFile(string File)  // конвертує шаблон у вигляді текст файлу у масив int[]
        {
            try
            {              

                string file_text = File;

                string number = "";
                List<int> listOfNumbers = new List<int>();
                for (int i = 0; i < file_text.Length; i++)
                {
                    if (file_text[i] != ',')
                    {
                        number += file_text[i].ToString();
                    }
                    else
                    {
                        if (number != "" &&
                       file_text.Substring(i, 1) == "," &&
                       int.TryParse(number, out _))
                        {
                            listOfNumbers.Add(Convert.ToInt32(number));
                            number = "";
                        }
                        else
                        {
                            listOfNumbers.Clear();
                            new CustomDialogBox("Невідомий символ в числі { " + number + " }." +
                                "\n Або введений невірний розділовий знак", "Warning").ShowDialog();
                            break;
                        }
                    }
                    if (i == file_text.Length - 1 && int.TryParse(number, out _))
                    {
                        listOfNumbers.Add(Convert.ToInt32(number));
                        number = "";
                    }
                }
                return listOfNumbers.ToArray();

            }
            catch
            {
                new CustomDialogBox("Невідома помилка, перевірте чи правильно попередньо введені дані", "Error").ShowDialog();
                return null;
            }
        }



    }
}



