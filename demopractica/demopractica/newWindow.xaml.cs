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

namespace demopractica
{
    /// <summary>
    /// Логика взаимодействия для newWindow.xaml
    /// </summary>
    public partial class newWindow : Window
    {
        public newWindow()
        {
            InitializeComponent();

            var products = Instance.db.Товар_декор;
            listView.ItemsSource = products.ToList();
        }
    }
}
