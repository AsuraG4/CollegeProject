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

namespace MyProject_EndOfSecondCourse_.Pages
{
    /// <summary>
    /// Логика взаимодействия для TutorialPage.xaml
    /// </summary>
    public partial class TutorialPage : Page
    {
        public TutorialPage()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MainMenuBt_Click(object sender, RoutedEventArgs e)
        {
            new Pages.PauseMenuGame().ShowDialog();
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            new Pages.InventoryGame().ShowDialog();
        }

        private void fightZone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            fightZone.Children.Add(new Classes.EnemyView(new Classes.Enemy(10, 3, 5, 1)));
        }
    }
}
