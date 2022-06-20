using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_EndOfSecondCourse_.Classes
{
    internal class Enemy
    {
        private float _healthPoints;                    
        private float _damagePoints;                    
        private float _level;                           
        private int _typeEnemy;                         
                                                                                                                                                                                                                               
        public Enemy(float health, float damage, float level, int type) 
        {
            _healthPoints = health;                     
            _damagePoints = damage;                     
            _level = level;
            _typeEnemy = type;
        }

        public void TakenDamage(float incommingDamage)  // все методы с большой буквы, передаем урон проходящий по врагу
        {
            _healthPoints -= incommingDamage;           // изменяем значение поля здоровья на значение входящего урона
            CheckHealthPoints();                        // вызываем метод CheckHealth после нанесения урона
        }

        public void CheckHealthPoints()                 // метод, проверяющий уровень здоровья врага
        {
            if (_healthPoints <= 0)                     // если поле здоровья хранит в себе число ниже равно нуля враг умирает
                Die();                                  // вызываю метод умереть у врага с нулевым здоровьем
        }

        public void Die()                               // когда враг умирает, тип его изображения меняется
        {
            _typeEnemy = 0;                             // можешь сделать файл enemy0.png, где будет труп противника
        }

        // МЕТОДЫ ДЛЯ EnemyView ||| СНАЧАЛА ИДИ ТУДА, ПОТОМ ВЕРНИСЬ

        public float GetEnemyHealth()                   // метод возвращающий текущее значение здоровья
        {
            return _healthPoints;                       // вернул значение из поля здоровья
        }

        public float GetEnemyType()                     // метод возвращающий тип врага, используется для обновления изображения
        {
            return _typeEnemy;                          // вернул значение из поля типа
        }

        public float GetEnemyLevel()                    // метод возвращающий уровень врага, используется для отображения уровня
        {
            return _level;                              // вернул значение из поля уровня
        }
    }
}
