using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1.MyGame
{
    /// <summary>
    /// Game cycle
    /// </summary>
    public static class GameCycle
    {
        private static Window window;

        /// <summary>
        /// Start game cycle
        /// </summary>
        public static void StartGame()
        {
            Start();

            bool something = true;

            while (something)
            {
                Update();
                Render();
            }
        }

        /// <summary>
        /// Initialize values
        /// </summary>
        private static void Start()
        {
            window = new Window();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actions that repeats every iteration
        /// </summary>
        private static void Update()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Render current frame
        /// </summary>
        private static void Render()
        {
            throw new NotImplementedException();
        }
    }
}
