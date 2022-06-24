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
    public partial class TutorialPage : Page
    {
        public TutorialPage()
        {
            InitializeComponent();
            Classes.Manager.MainGameGrid = MainGameBG;
            Classes.GameSetter.FightPlace = fightZone;      // устанавливаю значение свойству

            Classes.GameSetter.CurrentEnemy = new Classes.EnemyView(new Classes.Enemy(100, 3, 5, 1));
            fightZone.Children.Add(Classes.GameSetter.CurrentEnemy);            // добавляю первого врага

            Classes.GameSetter.EnemyCounter = 0;
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
        
    }
}
