using System.Windows.Controls;
using MyAABExample.ViewModel;

namespace MyAABExample.Views
{
    /// <summary>
    /// Interaction logic for ItemMaintView.xaml
    /// </summary>
    public partial class CategoryView : UserControl
    {
        public CategoryView(CategoryViewModel viewmodel)
        {
            InitializeComponent();
            this.DataContext = viewmodel;
        }

    }
}
