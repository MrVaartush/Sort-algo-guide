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
    public partial class OnlyText : UserControl // UserControl з заданим стилем
    {
        public OnlyText(string TextToShow) // приймає текст та відображає у собі
        {
            InitializeComponent();           
            LabelText.Text = TextToShow;
        }
    }
}
