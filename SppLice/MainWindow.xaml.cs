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

namespace SppLice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Wpf.Ui.Controls.UiWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Wpf.Ui.Appearance.Theme.Apply(
            Wpf.Ui.Appearance.ThemeType.Dark,
            Wpf.Ui.Appearance.BackgroundType.Mica,
            true
            );
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Grid;
            rectangle.Opacity = 0.8;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var rectangle = sender as Grid;
            rectangle.Opacity = 1;
        }
    }
}
