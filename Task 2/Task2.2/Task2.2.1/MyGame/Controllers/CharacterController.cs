using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2._2._1.MyGame.GameObjects.Characters;

namespace Task2._2._1.MyGame.Controllers
{
    public abstract class CharacterController : Controller
    {
        public abstract void Move();

        public abstract void Attack();
    }
}
