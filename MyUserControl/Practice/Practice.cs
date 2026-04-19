using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using SortAlgoGuide.MyForms;
using SortingAlgo;

namespace SortAlgoGuide.MyUserControl.Practice
{
  
    public partial class Practice : UserControl
    {
        #region variables

        bool FuncMenuClosed = true,   
            RandomMenuClosed = true,
            TempMenuClosed = true,
            CompareMenuClosed = true,
            ImportMenuClosed = true;

        string[] arrOfAlgos =   // алгоритми, що відображаються при виборі в ComboBox
        {
            "bubble",
            "shaker",
            "comb",
            "insertion",
            "shell",
            "counting",
            "selection",
            "merge",
            "quick",
            "radix LCD"            
        };
        List<string> ListOfAlgosSearched = new List<string>();  // алгоритми що шукаються в ComboBox

        List<int> ListToSort = new List<int>();  // елементи для сортування, може бути скільки завгодно
        BindingList<int> ListToSortShown = new BindingList<int>();  // список з елементами, що відображаються для користувача (500 макс)
        //BindingList needed - listbox dont see List 

        #endregion
        public Practice()
        {
            InitializeComponent();

            comboBox_Algo.Items.AddRange(arrOfAlgos);

            Temp_comboBox.Items.AddRange(new string[] {
                "Відсорт.(від більш. до менш.)",
                "Відсорт. Частинами",
                "Випадкова множина",
                "Відсорт.(100 свапів)" });

            #region Elements_Style

            Func_panel.Height = 35;
            // відображення елементів в listBox посередині
            ElemToSort_listBox.DrawMode = DrawMode.OwnerDrawFixed;
            ElemToSort_listBox.DrawItem += new DrawItemEventHandler(Helpfull_func.listBox_CenterItem);
            UsingAlgo_listBox.DrawMode = DrawMode.OwnerDrawFixed;
            UsingAlgo_listBox.DrawItem += new DrawItemEventHandler(Helpfull_func.listBox_CenterItem);
            WastedTime_listBox.DrawMode = DrawMode.OwnerDrawFixed;
            WastedTime_listBox.DrawItem += new DrawItemEventHandler(Helpfull_func.listBox_CenterItem);

            ElemToSort_listBox.DataSource = ListToSortShown;

            ElementToAdd_numericUpDown.Maximum = Int32.MaxValue;
            ElementToAdd_numericUpDown.Minimum = Int32.MinValue;

            RandomMin_numericUpDown.Maximum = Int32.MaxValue;
            RandomMin_numericUpDown.Minimum = Int32.MinValue;

            RandomMax_numericUpDown.Maximum = Int32.MaxValue;
            RandomMax_numericUpDown.Minimum = Int32.MinValue;

            RandomMin_numericUpDown.Value = 0;
            RandomMax_numericUpDown.Value = 0;

            #endregion

            #region Events
            ElementToAdd_numericUpDown.KeyUp += AddElem_OnEnter;
            ElemToSort_listBox.KeyDown += DeleteNumberInDel;

            comboBox_Algo.KeyUp += comboBox_Algo_KeyUp;

            comboBox_Algo.MouseMove += HoverMouseHelper;
            Func_btn.MouseMove += HoverMouseHelper;
            Random_btn.MouseMove += HoverMouseHelper;
            Temp_btn.MouseMove += HoverMouseHelper;
            Import_btn.MouseMove += HoverMouseHelper;
            Compare_btn.MouseMove += HoverMouseHelper;            
            ElemToSort_listBox.MouseMove += HoverMouseHelper;
            
            
            Temp_comboBox.MouseMove += HoverMouseHelper;
            
            this.MouseMove += HoverMouseHelper;

            #endregion

        }
        #region logicFunc  
        private void CheckSortSet() // перевіряє значення в спику з елементами для відображення (ListToSortShown) та в списку з усіма елементами (ListToSort)
        {
            ListToSortShown.Clear();
            if (ListToSort.Count > 500)
                for (int i = 0; i < 500; i++)
                    ListToSortShown.Add(ListToSort[i]);
            else
                for (int i = 0; i < ListToSort.Count; i++)
                    ListToSortShown.Add(ListToSort[i]);
        }
        
       
        #endregion

        #region EventsClick

        //Click
        private void Func_btn_Click(object sender, EventArgs e) // відкрити список функцій для тестування
        {
            if (ImportMenuClosed)
            {
                Import_textBox.Visible = true;
                ImportMenuClosed = !ImportMenuClosed;
            }
            else
            {
                Import_textBox.Visible = false;
                ImportMenuClosed = !ImportMenuClosed;
            }

            Timer_functions.Start();

        }
        private void Compare_btn_Click(object sender, EventArgs e)
        {
            if (CompareMenuClosed)
            {
                Compare_label.Visible = true;
                CompareMenuClosed = !CompareMenuClosed;

            }
            else
            {
                Compare_label.Visible = false;
                CompareMenuClosed = !CompareMenuClosed;
                UsingAlgo_listBox.Items.Clear();
                WastedTime_listBox.Items.Clear();
            }
        } // ввімкнути функцію порівння
        
        private void Temp_btn_Click(object sender, EventArgs e)
        {
            if (TempMenuClosed)
            {
                Temp_panel.Visible = true;
                TempMenuClosed = !TempMenuClosed;
            }
            else
            {
                Temp_panel.Visible = false;
                TempMenuClosed = !TempMenuClosed;
            }
        } // відобразити\приховати функції вик шаблонів
        
        private void Import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.

                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog.FileName;
                    if (file.Substring(file.Length - 3) == "txt")
                    {
                        string text = File.ReadAllText(file);
                        string number = "";
                        List<int> listOfNumbers = new List<int>();


                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i] != ',')
                            {
                                number += text[i].ToString();
                            }
                            else
                            {
                                if (number != "" &&
                               text.Substring(i, Import_textBox.Text.Length) == Import_textBox.Text &&
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
                            if (i == text.Length - 1 && int.TryParse(number, out _))
                            {
                                listOfNumbers.Add(Convert.ToInt32(number));
                                number = "";
                            }
                        }
                        ListToSort.Clear();
                        if (listOfNumbers.Count != 0)
                            foreach (int item in listOfNumbers)
                                ListToSort.Add(item);

                        CheckSortSet();



                    }
                    else
                    {
                        new CustomDialogBox("Файл повинен бути розширення .txt", "Error").ShowDialog();
                    }

                }
            }
            catch   // if error happend
            {
                new CustomDialogBox("Невідома помилка, перевірте чи правильно попередньо введені дані", "Error").ShowDialog();
            }

        } // конвертація тексту у послідовність чисел та додавання цих чисел для списку сортування
        
        private void Random_btn_Click(object sender, EventArgs e)
        {
            if (RandomMenuClosed)
            {
                Random_panel.Visible = true;
                RandomMenuClosed = !RandomMenuClosed;
            }
            else
            {
                Random_panel.Visible = false;
                RandomMenuClosed = !RandomMenuClosed;
            }
        } // відобразити\приховати функції випадкової генерації чисел

        private void Add_btn_Click(object sender, EventArgs e)
        {
            ListToSort.Add((int)ElementToAdd_numericUpDown.Value);
            CheckSortSet();
        } // додати елемент після клацання на кнопку "Додати"

        private void RndmGen_btn_Click(object sender, EventArgs e)
        {
            if (RandomMax_numericUpDown.Value != RandomMin_numericUpDown.Value &&
                RandomMax_numericUpDown.Value > RandomMin_numericUpDown.Value)
            {
                Random random = new Random();
                ListToSort.Clear();
                if (!Repeat_checkBox.Checked)
                {
                    for (int i = 0; i < Count_numericUpDown.Value; i++)
                    {
                        int number = random.Next((int)RandomMin_numericUpDown.Value, (int)RandomMax_numericUpDown.Value);
                        if (!ListToSort.Contains(number))
                            ListToSort.Add(number);
                    }
                }
                else
                {
                    for (int i = 0; i < Count_numericUpDown.Value; i++)
                    {
                        ListToSort.Add(random.Next((int)RandomMin_numericUpDown.Value, (int)RandomMax_numericUpDown.Value));
                    }
                }
            }
            else
                new CustomDialogBox("Неправильно вказаний діапазон чисел", "Помилка");
            CheckSortSet();


        } // генерування випадкової послідовності чисел з заданими діапазонами

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            int[] ArrToSort = ListToSort.ToArray();
            WastedTime_listBox.Items.Clear();
            for (int i = 0; i < UsingAlgo_listBox.Items.Count; i++)
            {
                ArrToSort = ListToSort.ToArray();
                Stopwatch stopWatch = new Stopwatch();

                stopWatch.Start();
                SortingAlgos.DoSort(ref ArrToSort, UsingAlgo_listBox.Items[i].ToString());                
                stopWatch.Stop();

                WastedTime_listBox.Items.Add(((float)stopWatch.ElapsedTicks / 10000).ToString());

            }
            if (UsingAlgo_listBox.Items.Count == 1)
            {
                Form ShowSortedSet = new CustomDialogBox("", "Sorted set");
                ShowSortedSet.Controls.Clear();
                ShowSortedSet.Controls.Add(new ListBox());
                ListBox box = ShowSortedSet.Controls[0] as ListBox;

                box.Dock = DockStyle.Fill;
                box.DataSource = ArrToSort;
                box.DrawMode = DrawMode.OwnerDrawFixed;
                box.DrawItem += new DrawItemEventHandler(Helpfull_func.listBox_CenterItem);
                box.BackColor = System.Drawing.Color.DarkGray;
                box.BorderStyle = System.Windows.Forms.BorderStyle.None;
                box.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                box.ForeColor = System.Drawing.Color.DimGray;
                box.ItemHeight = 30;

                ShowSortedSet.ShowDialog();
            }

        } // відсортувати послідовінсть за заданими алгоритмами
        
        private void TempChosen_btn_Click(object sender, EventArgs e)
        {
            if (Temp_comboBox.Text != "" &&
                 Temp_comboBox.Items.Contains(Temp_comboBox.Text))
                switch (Temp_comboBox.SelectedItem.ToString())
                {
                    case "Відсорт.(від більш. до менш.)":
                        ListToSort.Clear();
                        ListToSort = MyTemplates.GetPattert("back").ToList();
                        CheckSortSet();
                        break;

                    case "Відсорт. Частинами":
                        ListToSort.Clear();
                        ListToSort = MyTemplates.GetPattert("part").ToList();
                        CheckSortSet();
                        break;

                    case "Випадкова множина":
                        ListToSort.Clear();
                        ListToSort = MyTemplates.GetPattert("random").ToList();
                        CheckSortSet();
                        break;
                    case "Відсорт.(100 свапів)":
                        ListToSort.Clear();
                        ListToSort = MyTemplates.GetPattert("100_swaps").ToList();
                        CheckSortSet();
                        break;

                }
            else
                new CustomDialogBox("Виберіть шаблон", "Помилка").ShowDialog();





        } // додати нову послідовність чисел до сортування з шаблонів

        private void mixElem_btn_Click(object sender, EventArgs e)
        {
            Helpfull_func.RandomizeElements(ListToSort);
            CheckSortSet();
        } // перемішати елементи

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ListToSort.Clear();
            ListToSortShown.Clear();
        } // очистити список для сортування


        #endregion

        #region OtherEvents

        private void AddElem_OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListToSort.Add((int)ElementToAdd_numericUpDown.Value);
                CheckSortSet();
            }
        }  // додавання новго елемента до списку для сортування
               
        private void DeleteNumberInDel(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListToSort.RemoveAt(ElemToSort_listBox.SelectedIndex);
                CheckSortSet();
            }

        } // видалення елементу зі списку для сорутвання

        private void Import_textBox_Enter(object sender, EventArgs e)
        {
            if (Import_textBox.Text == "розділовий знак")
                Import_textBox.Text = "";
        } // видаляє допоміжний текст коли textBox стає активним елементои

        private void HoverMouseHelper(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control.Name == comboBox_Algo.Name)           // switch dont work            
                Helper_label.Text = "Введіть/оберіть назву алгоритму сортування та натисність Enter для його використання в подальшому\n " +
                    "(можна вибрати декілька алгоритмів для порівняння ввімкнувши функцію 'Порівняти' в функціях)";
            else if (control.Name == Func_btn.Name)
                Helper_label.Text = "Натисніть для відкриття/закриття вікна для огляду функцій тестування";
            else if (control.Name == Random_btn.Name)
                Helper_label.Text = "Генерує задану множину цілих чисел у вибраному діапазоні";
            else if (control.Name == Temp_btn.Name)
                Helper_label.Text = "Застосовує заготовлену множену чисел для сорування. Для застосування шаблону натисність кнопку '«' поруч\n" +
                    "(Кількість чисел у шаблонах = +- 10 000)";
            else if (control.Name == Import_btn.Name)
                Helper_label.Text = "Імпортувати множину ЦІЛИХ ЧИСЕЛ з файлу формату .txt .\n" +
                    " В полі поруч вводиться знак(-и) що розділяють числа в файлі. (Приклад: 4,5,-3,0,45  де кома це роздільний знак)";
            else if (control.Name == Compare_btn.Name)
                Helper_label.Text = "Ввімкнути функцію порівння, що дозволяє вибрати майже всі алгоритми сортування для порівняння " +
                    "їхньої часової ефективності в мікросекундах";
            else if (control.Name == ElemToSort_listBox.Name)
                Helper_label.Text = "Список чисел для сортвуання, які можна додати ввівши по одному у текстовому полі зверху " +
                     "від списку та натиснувши Enter/кнопку 'Додати' або" +
                     "імпортувавши вже готову послідовність чисел. Вибравши елемент в списку можна його видалити натиснувши 'delete'";
            else if (control.Name == Temp_comboBox.Name)
                Helper_label.Text = "`Відсорт.(від більш.до менш.)` - відсортована послідовність від більшого до меншого.\n" +
                    "`Відсорт. Частинами` - відсортованa послідовність, але її частини (діапазонами по 1-2 тис.) були перемішані.\n" +
                    "`Випадкова множина` - повністю випадкова послідовність чисел.\n" +
                    "`Відсорт.(100 свапів)` - 100 випадкових перестановок в повністю відсортованій послідовності.\n";            
            else
                Helper_label.Text = " ";
                        
        } // коли вказівник знаходиться над певним елементом, висвічується текст, що роз'яснює застосування функції

        //comboBox_Algo Searcher on KeyUP/ use sorting algo after choose by Enter 
        private void comboBox_Algo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (arrOfAlgos.Contains(comboBox_Algo.Text) &&
                    !UsingAlgo_listBox.Items.Contains(comboBox_Algo.Text) &&
                    CompareMenuClosed)
                {
                    UsingAlgo_listBox.Items.Clear();
                    UsingAlgo_listBox.Items.Add(comboBox_Algo.Text);
                }
                else if (arrOfAlgos.Contains(comboBox_Algo.Text) &&
                    !UsingAlgo_listBox.Items.Contains(comboBox_Algo.Text) &&
                    !CompareMenuClosed)

                    UsingAlgo_listBox.Items.Add(comboBox_Algo.Text);
            }
            else if
                (e.KeyCode != Keys.Up &&
                e.KeyCode != Keys.Down &&
                e.KeyCode != Keys.Left &&
                e.KeyCode != Keys.Right)
            {
                comboBox_Algo.DroppedDown = true;

                string toSearch = comboBox_Algo.Text;
                ListOfAlgosSearched.Clear();
                if (toSearch != "")
                {
                    foreach (string key in arrOfAlgos)
                    {
                        if (key.Contains(toSearch) && !ListOfAlgosSearched.Contains(key))
                        {
                            ListOfAlgosSearched.Add(key);
                        }
                    }
                }
                if (ListOfAlgosSearched.Count > 0)
                {
                    Helpfull_func.SafeClearItems(comboBox_Algo);
                    int a = comboBox_Algo.Items.Count;
                    comboBox_Algo.Items.AddRange(ListOfAlgosSearched.ToArray());
                }
                else
                {
                    int a = comboBox_Algo.Items.Count;
                    Helpfull_func.SafeClearItems(comboBox_Algo);
                    a = comboBox_Algo.Items.Count;
                    comboBox_Algo.Items.AddRange(arrOfAlgos);
                }
            }


        } 

        // Timer
        private void Timer_functions_Tick(object sender, EventArgs e)  // плавне відкриття списку функцій для тестування
        {
            if (!FuncMenuClosed)
            {
                Func_panel.Height -= 10;
                if (Func_panel.Height == Func_panel.MinimumSize.Height)
                {
                    Func_panel.BackColor = Color.FromArgb(47, 49, 54);
                    FuncMenuClosed = true;
                    Timer_functions.Stop();
                }
            }
            else
            {
                Func_panel.Height += 10;
                if (Func_panel.Height == Func_panel.MaximumSize.Height)
                {
                    Func_panel.BackColor = Color.FromArgb(41, 43, 47);
                    FuncMenuClosed = false;
                    Timer_functions.Stop();

                }
            }
        }
        #endregion


    }
}




