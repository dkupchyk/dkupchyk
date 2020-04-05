using System.Windows.Controls;
using Lab5_Kupchyk.Tools.Navigation;
using Lab5_Kupchyk.ViewModels;

namespace Lab5_Kupchyk.Views
{
    /// <summary>
    /// Логика взаимодействия для ThreadsModulesView.xaml
    /// </summary>
    public partial class ThreadsModulesView : UserControl, INavigatable
    {
        public ThreadsModulesView()
        {
            InitializeComponent();
            DataContext = new ThreadModuleViewModel();
        }
    }
}
