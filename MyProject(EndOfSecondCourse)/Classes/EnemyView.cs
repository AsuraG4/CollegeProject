using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MyProject_EndOfSecondCourse_.Classes
{
    internal class EnemyView : DockPanel
    {
        public static string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"ImagesAndSprites\NPC\Enemies\";
    

    private Enemy _enemy;                                       
    private Image _image = new Image();                         
    private DockPanel _healthPanel = new DockPanel();           
    private ProgressBar _healthBar = new ProgressBar();         
    private TextBlock _maxHealthTextBlock = new TextBlock();             
    private TextBlock _levelTextBlock = new TextBlock();                 

    public EnemyView(Enemy enemy)                               
    {
        _enemy = enemy;                                         
        _levelTextBlock.Text = _enemy.GetEnemyLevel().ToString();       
                                                                        

        _healthBar.Maximum = _enemy.GetEnemyHealth();           
                                                                

        _maxHealthTextBlock.Text = _enemy.GetEnemyHealth().ToString();  

        UpdateBar();                                            
        UpdateImage();                                          

        _healthPanel.Children.Add(_maxHealthTextBlock);         
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
}
}
