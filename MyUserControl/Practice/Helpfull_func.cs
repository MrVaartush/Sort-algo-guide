using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SortAlgoGuide.MyUserControl.Practice
{
    internal class Helpfull_func
    {
        public static void listBox_CenterItem(object sender, DrawItemEventArgs e)  // To center elem in listbox
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));

            }
        }

        public static void RandomizeElements(List<int> ListToSort)
        {
            Random rndm = new Random();
            for (int i = 0; i < ListToSort.Count; i++)
            {
                int buffIndex = rndm.Next(ListToSort.Count);
                int buf = ListToSort[buffIndex];

                ListToSort[buffIndex] = ListToSort[i];
                ListToSort[i] = buf;

            }
            
        }

        public static void SafeClearItems(ComboBox comboBox)  // видаляє елменти з ComboBox не переміщуючи курсор на початок у власному полі
        {
            while (comboBox.Items.Count > 0)
                comboBox.Items.RemoveAt(0);
        }

    }
}


