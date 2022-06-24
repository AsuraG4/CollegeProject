using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace MyProject_EndOfSecondCourse_.Classes
{
    static class GameSetter
    {
        public static float HeroDamage { get; set; } = 25;    

        public static EnemyView CurrentEnemy { get; set; }

        public static Grid FightPlace { get; set; }             // свойство хранящее грид куда добавляется противник

        public static int EnemyCounter { get; set; } = 0;       // счетчик убитых противников, по умолчанию равняется 0


        public static DispatcherTimer deathTimer = new DispatcherTimer()    // создаю новый таймер, не забудь про импорт
        {
            Interval = TimeSpan.FromSeconds(1.5)                // указываю периодичность срабатывания - 1.5 секунды
        };

        public static void UpdateEnemy()                        // метод обновления противников, вызывается из метода Die внутри Enemy
        {
            EnemyCounter++;                                     // увеличиваю счетчик убитых врагов
            CurrentEnemy.UpdateImage();                         // обновляю изображение, чтобы показать RIP
            deathTimer.Tick += NextEnemy;                       // подписываю срабатывание таймера на метод
            deathTimer.Start();                                 // запускаю таймер
        }

        public static void NextEnemy(object sender, EventArgs e)    // метод срабатывает по таймеру
        {
            Manager.EnemyCounterTextBlock.Text = EnemyCounter.ToString();
            Manager.MainGameGrid.Background = new ImageBrush()// обновляю фон главного окна приложения
            {                                                   // фон меняется каждые 10 врагов так как счетчик делится на 10
                ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "bg" + EnemyCounter / 10 + ".jpg"))
            };                                                  // при делении целых чисел - рез целая часть, поэтому получаю bg0, bg1 и тд
            FightPlace.Children.Clear();                        // очищаю грид с противниками чтобы там никого не было
            FightPlace.Children.Add(GenerateEnemy());    // добавляю нового врага, можно повесить рандом
            deathTimer.Stop();
        }

        public static EnemyView GenerateEnemy()
        {
            Random rndm = new Random();

            return new EnemyView(new Enemy
                (
                    rndm.Next(50, 251), // hp
                    rndm.Next(1, 11),   // dmg
                    rndm.Next(1, 6),    // lvl
                    rndm.Next(1, 13))   // img
                );
        }
    }
}
