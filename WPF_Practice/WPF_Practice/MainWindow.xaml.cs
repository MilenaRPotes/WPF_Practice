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

namespace WPF_Practice
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid miGrid = new Grid();

            this.Content = miGrid;

            Button miBoton = new Button();

            WrapPanel miWrap = new WrapPanel();
            TextBlock txt1 = new TextBlock();
            txt1.Text = "Click";
            miWrap.Children.Add(txt1);

            miBoton.Content = miWrap;

            miGrid.Children.Add(miBoton);
        }


    }
}
