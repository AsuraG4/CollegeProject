using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyProject_EndOfSecondCourse_.Classes
{
    internal class EnemyView : DockPanel
    {
        public static string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"ImagesAndSprites\NPC\Enemies\";
    

    private Enemy _enemy;                                       
    private Image _image = new Image();                         
    private DockPanel _healthPanel = new DockPanel();
    private ProgressBar _healthBar = new ProgressBar()
        {
            Foreground = Brushes.Tomato,            
        };         
    private TextBlock _healthTextBlock = new TextBlock()
        {
            FontSize = 16,
            Foreground = Brushes.White
        };             
    private TextBlock _levelTextBlock = new TextBlock();
    private TextBlock _hpView = new TextBlock()
        {
            Text = "HP",
            FontSize = 16,
            Foreground = Brushes.White
        };

    public EnemyView(Enemy enemy)                               
        {
            _enemy = enemy;                                         
            _levelTextBlock.Text = _enemy.GetEnemyLevel().ToString();       
                                                                        
            _healthBar.Maximum = _enemy.GetEnemyHealth();           
                                                                
            _healthTextBlock.Text = _enemy.GetEnemyHealth().ToString();  

            UpdateBar();                                            
            UpdateImage();

            _image.MouseDown += TakenDamage;

            _healthPanel.Children.Add(_healthTextBlock);         
            _healthPanel.Children.Add(_healthBar);                  

            Children.Add(_levelTextBlock);                          
            Children.Add(_healthPanel);                             
            Children.Add(_image);                                   
        }

    public void UpdateBar()                                     
        {
            _healthBar.Value = _enemy.GetEnemyHealth();             
        }                                                           

    public void UpdateImage()                                   
        {                                                           
            _image.Source = new BitmapImage(new Uri(ImagePath + "enemy" + _enemy.GetEnemyType() + ".png")); 
        }

        public void TakenDamage(object sender, EventArgs e)         // метод получения урона у EnemyView
        {                                                           // на него неообходимо подписаться при создании объекта
            _enemy.TakenDamage(GameSetter.HeroDamage);              // обращаемся к монстру чей EnemyView и вызываем метод получения урона
                                                                    // куда передаем значение урона Героя из статического класса GameSetter
            UpdateBar();                                            // обновляем полоску здоровья
            UpdateImage();                                          // обновляем изображение (если враг умер, то изображение должно изменится)

            //(Parent as Grid).Children.Remove(this);               // потом допишу, это удаление противника с грида
        }
    }
}
