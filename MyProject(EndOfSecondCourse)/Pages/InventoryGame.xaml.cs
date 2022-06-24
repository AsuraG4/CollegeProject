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

namespace MyProject_EndOfSecondCourse_.Pages
{
    /// <summary>
    /// Логика взаимодействия для InventoryGame.xaml
    /// </summary>
    public partial class InventoryGame : Window
    {
        public InventoryGame()
        {
            InitializeComponent();
        }

        private void Others_MouseEnter(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Visible;
        }

        private void Potions_MouseEnter(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Visible;
        }

        private void Weapons_MouseEnter(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Visible;
        }

        private void Armor_MouseEnter(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Visible;
        }

        private void Armor_MouseLeave(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Hidden;
        }

        private void Weapons_MouseLeave(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Hidden;
        }

        private void Potions_MouseLeave(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Hidden;
        }

        private void Others_MouseLeave(object sender, MouseEventArgs e)
        {
            ((sender as Button).Content as TextBlock).Visibility = Visibility.Hidden;
        }
    }
}
