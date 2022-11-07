using ShopProgramWpf.FakeDatas;
using ShopProgramWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace ShopProgramWpf.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Uc_Control.xaml
    /// </summary>
    public partial class Uc_Control : UserControl
    {
        public Product? product { get; set; }

        public Uc_Control()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
