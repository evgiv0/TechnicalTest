﻿using System;

namespace AreaCalculator.Abstract
{
    public abstract class Shape
    {
        private readonly int defaultAccuracy = 2;

        public double GetArea()
        {
            IsRightFigure();
            return RoundValue(GetAreaFigure(), defaultAccuracy);

        }

        protected abstract void IsRightFigure();

        protected abstract double GetAreaFigure();

        protected virtual double RoundValue(double receivedArea, int accuracy)
        {
            return Math.Round(receivedArea, accuracy);
        }
    }
}
