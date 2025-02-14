using specek_test_task.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace specek_test_task.Views
{
    /// <summary>
    /// Логика взаимодействия для SomeView.xaml
    /// </summary>
    public partial class SomeView : Window
    {
        public SomeView()
        {
            InitializeComponent();
            DataContext = new SomeViewModel();
        }
    }
}
