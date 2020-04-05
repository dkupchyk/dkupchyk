using System.Windows.Controls;
using Lab5_Kupchyk.Tools.Navigation;
using Lab5_Kupchyk.ViewModels;

namespace Lab5_Kupchyk.Views
{
    /// <summary>
    /// Логика взаимодействия для TaskManagerView.xaml
    /// </summary>
    public partial class TaskManagerView : UserControl, INavigatable
    {
        public TaskManagerView()
        {
            InitializeComponent();
            DataContext = new TaskManagerViewModel();
        }
    }
}
