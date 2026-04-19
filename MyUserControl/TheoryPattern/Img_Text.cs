using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoGuide.MyUserControl.TheoryPattern
{
    public partial class Img_Text : UserControl // UserControl з заданим стилем
    {
        public Img_Text(string Text, Bitmap img)  // приймає текст та картинку та відображає у собі
        {
            InitializeComponent();            
            label1.Text = Text; 
            pictureBox1.Image = img;
        }
    }
}
