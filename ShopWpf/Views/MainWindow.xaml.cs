using ShopProgramWpf.FakeDatas;
using ShopProgramWpf.UserControls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            DataContext = this;

            FakeProducts Products = new();


            foreach (var item in Products.products)
            {
                Uc_Control uc_Control = new();
                uc_Control.product = item;
                firstrow.Children.Add(uc_Control);
            }

        }
    }
}
