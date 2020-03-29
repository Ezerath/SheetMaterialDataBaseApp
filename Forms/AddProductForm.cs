using System.Windows.Forms;

namespace SheetMaterialDataBaseApp.Forms
{
    public partial class AddProductForm : Form
    {
        public string TextBoxValue { get => productTextBox.Text; }
        public AddProductForm()
        {
            InitializeComponent();
        }

    }
}
