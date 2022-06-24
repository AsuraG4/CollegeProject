using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyProject_EndOfSecondCourse_.Classes
{
    internal class Manager
    {
        public static Frame MainAppFrame
        {
            get;
            set;
        }

        public static Grid MainGameGrid
        {
            get;
            set;
        }

        public static TextBlock EnemyCounterTextBlock
        {
            get;
            set;
        }
    }
}
