using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1.MyGame.Interfaces
{
    public interface IDestructable
    {
        int HP { get; set; }
        int MaxHP { get; set; }

        void Death();
    }
}
