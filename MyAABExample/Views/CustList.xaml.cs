using System.Windows.Controls;
using MyAABExample.ViewModel;

namespace MyAABExample.Views
{
    /// <summary>
    /// Interaction logic for CustList.xaml
    /// </summary>
    public partial class CustList : UserControl
    {
        public CustList(CustomerListVM viewModel)
        {
            this.InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
