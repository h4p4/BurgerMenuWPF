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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace burger_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string ToggleMenuButtonContent
        //{
        //    get => ToggleMenuBtn.Content.ToString();
        //    set => ToggleMenuBtn.Content = value;
        //}

        public MainWindow()
        {
            InitializeComponent();
        }



        private void CloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
