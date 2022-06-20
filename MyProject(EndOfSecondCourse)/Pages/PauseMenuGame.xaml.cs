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
    /// Логика взаимодействия для PauseMenuGame.xaml
    /// </summary>
    public partial class PauseMenuGame : Window
    {
        public PauseMenuGame()
        {
            InitializeComponent();
        }

        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BackToTheMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Classes.Manager.MainAppFrame.Navigate(new Pages.MainMenuPage());
        }
    }
}
