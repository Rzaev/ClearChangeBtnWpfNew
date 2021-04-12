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

namespace ClearChangeBtnWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        Brush customColor;
        Random r = new Random();

        private void Btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                this.Title = btn.Content.ToString();
                myCanvas.Children.Remove(btn);
            }
        }


        private static SolidColorBrush CreateColor()
        {
            Random random = new Random();
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            return new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void Btn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                btn.Background = CreateColor();
                MessageBox.Show($"My color is {btn.Background}");
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Background = CreateColor();
                MessageBox.Show($"My color is {btn.Background}");
            }
        }
    }
}
