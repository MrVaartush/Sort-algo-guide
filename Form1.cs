using System;
using System.Drawing;
using System.Windows.Forms;
using SortAlgoGuide.MyUserControl.TheoryPattern;
using SortAlgoGuide.MyUserControl.Practice;

namespace SortAlgoGuide
{
    public partial class Form1 : Form
    {      

        private bool sideBarOpen = true, MenuPanel_Tick = false;        
     
        public Form1()
        {
            InitializeComponent();
           
            SideBarBtns();

            SideBar.AutoScroll = false;

            SideBar.HorizontalScroll.Enabled = false;

            SideBar.AutoScroll = true;
        }


        #region logic
        private void SideBarBtns()  // задає властивості та події кнопкам в меню користвача
        {
            for (int i = 0; i < SideBar.Controls.Count; i++)
            {
                SideBar.Controls[i].Height = 35;
                for (int j = 0; j < SideBar.Controls[i].Controls.Count; j++)
                {
                    if (SideBar.Controls[i].Controls[j] is Button)
                    {
                        Button btn = SideBar.Controls[i].Controls[j] as Button;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 68, 71);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 43, 47);
                        if (btn.Name == "theory_btn")
                            SideBar.Controls[i].Controls[j].Click += btn_Menu_Open;
                    }
                }
            }
        }

        private void currentBtn(Button btn)  // замальовує кнопку, що відп. за певний алгоритм при розгляді його теоретичної частини
        {

            foreach (Control c in Theory_panel.Controls)
                c.BackColor = Color.FromArgb(41, 43, 47);

            btn.BackColor = Color.FromArgb(33, 34, 38);

        }

        private void OpenNextUC(UserControl panel) // відображає в робочій панелі програми нові UserControl для зміни слайдів через меню
        {
            if (panel_UserControl.Controls.Count > 0)
            {
                for (int i = 0; i < panel_UserControl.Controls.Count; i++)
                {
                    if (!(panel_UserControl.Controls[i] is Button))
                    {
                        panel_UserControl.Controls.RemoveAt(i);
                    }
                }
                panel_UserControl.Controls.Add(panel);

                panel.Dock = DockStyle.Fill;

            }
            else
            {
                panel_UserControl.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;

            }
        }

        private void btn_Menu_Open(object sender, EventArgs e) // запуск таймера, що відп. за кнопку "Теорія"
        {            
            MenuPanel_T.Start();
        }

        private void MenuPanel_T_Tick(object sender, EventArgs e) //повільне закриття\відкритя меню Теорії
        {
            if (MenuPanel_Tick)
            {
                Theory_panel.Height -= 10;
                if (Theory_panel.Height == Theory_panel.MinimumSize.Height)
                {
                    Theory_panel.BackColor = Color.FromArgb(47, 49, 54);
                    MenuPanel_Tick = false;
                    MenuPanel_T.Stop();

                }
            }
            else
            {
                Theory_panel.Height += 10;
                if (Theory_panel.Height == Theory_panel.MaximumSize.Height)
                {
                    Theory_panel.BackColor = Color.FromArgb(41, 43, 47);
                    MenuPanel_Tick = true;
                    MenuPanel_T.Stop();

                }
            }
        }

        private void side_btn_Click(object sender, EventArgs e) // закриття\відкриття голвного меню
        {
            if (sideBarOpen)
            {
                SideBar.Width = SideBar.MinimumSize.Width;
                sideBarOpen = false;
                side_btn.BackgroundImage = Properties.Resources.MenuBtn_right;
            }
            else
            {
                SideBar.Width = SideBar.MaximumSize.Width;
                side_btn.BackgroundImage = Properties.Resources.MenuBtn_left;
                sideBarOpen = true;
            }

        }

        #endregion

        private void Practice_Click(object sender, EventArgs e)  // відкриття сторінки для тестування алгоритмів
        {
            OpenNextUC(new Practice());
        }

        #region Theory
        // Подія Clicl для кожної кнопки, ща відповідає за відкриття своєї теорії свого алгоритму (кнопка btn_Quick відкриває теорію алгоритма Quick sort )
        private void btn_GeneralInfo_Click(object sender, EventArgs e)
        {            
            OpenNextUC(new MainControl(OnClick_Theory.GetText("General")));
        }

        private void bubble_theory_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("bubble")));
        }
       
        private void btn_Random_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("random")));
        }

        private void btn_Quick_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);

            OpenNextUC(new MainControl(OnClick_Theory.GetText("quick")));

        }

        private void btn_Shell_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("shell")));
        }

        private void btn_Comb_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("comb")));
        }

        private void btn_Radix_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("radix")));
        }

        private void btn_Shaker_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("shaker")));
        }

        private void btn_Inserion_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("insertion")));
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("select")));
        }

        private void time_compl_btn_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("time_compl")));            
        }

        private void btn_Count_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("count")));
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            currentBtn(sender as Button);
            OpenNextUC(new MainControl(OnClick_Theory.GetText("merge"))); 
        }
        #endregion 

    }
}

