using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoGuide.MyUserControl.TheoryPattern
{
    public partial class MainControl : UserControl // UserControl з заданим стилем для відображення інформації про алгоритми
    {
        UserControl[] UControls;
        int currentUControl = 0;
        public MainControl(UserControl[] UControls) // отримує масив UserControl[] та відображає перший елемент (першу сторінку)
        {
            InitializeComponent();
            this.UControls = UControls;
            OpenNextUC(UControls[0]);
            UpDatePages();
        }
        private void button1_Click(object sender, EventArgs e) // перейти до попереднього слайду
        {
            if (currentUControl - 1 < 0)
                currentUControl = UControls.Length - 1;
            else
                currentUControl--;
            UpDatePages();
            OpenNextUC(UControls[currentUControl]);
        }
        private void button2_Click(object sender, EventArgs e) // перейти до наступного слайду
        {
            if (currentUControl + 1 > UControls.Length - 1)
                currentUControl = 0;
            else
                currentUControl++;
            UpDatePages();
            OpenNextUC(UControls[currentUControl]);
        }

        private void OpenNextUC(UserControl panel) // відобразити (відкрити) новий слайд (UserControl)
        {
            if (InfoPanel_bubble.Controls.Count > 0)
            {
                for (int i = 0; i < InfoPanel_bubble.Controls.Count; i++)
                {
                    if (!(InfoPanel_bubble.Controls[i] is Button))
                    {
                        InfoPanel_bubble.Controls.RemoveAt(i);
                    }
                }
                InfoPanel_bubble.Controls.Add(panel);

                panel.Dock = DockStyle.Fill;

            }
            else
            {
                InfoPanel_bubble.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;

            }
        }

        private void UpDatePages() // строка, що відображає максимальну кіл-кість слайдів та на якому слайді зараз користувач
        {
            pages_label.Text = (currentUControl + 1).ToString() + "/" + UControls.Length;
        }
    }
}

