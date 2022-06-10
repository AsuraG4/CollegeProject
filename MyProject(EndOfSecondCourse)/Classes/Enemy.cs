using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_EndOfSecondCourse_.Classes
{
    internal class Enemy
    {
        private string MonsterType;

        private int HeathPoints;

        private int EnemyLevel;

        private int AttackPoints;
        

        public Enemy(string ImagePath, int Heath, int Level, int Attack)
        {
            MonsterType = ImagePath;
            HeathPoints = Heath;
            EnemyLevel = Level;
            AttackPoints = Attack;
        }
    }
}
