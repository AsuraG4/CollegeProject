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
            _typeEnemy = 0;
            GameSetter.UpdateEnemy();
        }


        public float GetEnemyHealth()                   
        {
            return _healthPoints;                       
        }

        public float GetEnemyType()                     
        {
            return _typeEnemy;                          
        }

        public float GetEnemyLevel()                    
        {
            return _level;                              
        }
    }
}
