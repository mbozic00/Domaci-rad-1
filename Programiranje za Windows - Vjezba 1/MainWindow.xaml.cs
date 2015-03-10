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

namespace Programiranje_za_Windows___Vjezba_1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LeftButton.Click += LeftButton_Click;
            this.RightButton.Click += RightButton_Click;
        }

        void RightButton_Click(object sender, RoutedEventArgs e)
        {
            this.RightRectangleContainer.Children.Add
            (
                new Rectangle()
                {
                    Height = 30,
                    Width = 280,
                    Stroke = Brushes.LightGray,
                    StrokeThickness = 1,
                    Margin = new Thickness(8),
                    Fill = Brushes.Red
                }
            );
        }

        void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            this.LeftRectangleContainer.Children.Add
            (
                new Rectangle()
                {
                    Height = 60,
                    Width = 60,
                    Stroke = Brushes.LightGray,
                    StrokeThickness = 1,
                    Margin = new Thickness(8),
                    Fill = Brushes.Orange
                }
            );

        }
    }
}
