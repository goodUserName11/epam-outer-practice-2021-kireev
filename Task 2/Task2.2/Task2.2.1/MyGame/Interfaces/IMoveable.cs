﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1.MyGame.Interfaces
{
    internal interface IMoveable
    {
        float Speed { get; set; }
        void Move();
    }
}