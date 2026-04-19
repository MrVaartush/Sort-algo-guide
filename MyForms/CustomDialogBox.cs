using System.Windows.Forms;

namespace SortAlgoGuide.MyForms
{
    public partial class CustomDialogBox : Form
    {
        public CustomDialogBox(string text_toShow, string WindowName)
        {
            InitializeComponent();
            Message_label.Text = text_toShow;
            this.Text = WindowName;
        }
    }
}
