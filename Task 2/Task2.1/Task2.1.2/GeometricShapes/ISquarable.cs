﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    /// <summary>
    /// *Квадрируемая фигура
    /// </summary>
    public interface ISquarable
    {
        /// <summary>
        /// Area of shape
        /// </summary>
        /// <returns></returns>
        float Area
        {
            get;
        }
    }
}
