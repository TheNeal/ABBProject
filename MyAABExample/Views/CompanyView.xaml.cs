using System.Windows.Controls;
using MyAABExample.ViewModel;

namespace MyAABExample.Views
{
    /// <summary>
    /// Interaction logic for Companies.xaml
    /// </summary>
    public partial class CompanyView : UserControl
    {
        public CompanyView(CompanyViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
