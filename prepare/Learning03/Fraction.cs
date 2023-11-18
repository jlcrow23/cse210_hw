
using System;


public class Fraction
    {
        private int _top;
        private int _bottom;

        // public string GetTop()
        // {
        //     return SetTop;
        // }

        // public void SetTop(int top)
        // {
        //     _top = top;
        // }

        // public string GetBottom()
        // {
        //     return SetBottom;
        // }

        // public void SetBottom(int bottom)
        // {
        //     _bottom = bottom;
        // }

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }

        public double GetDecimalValue()
        {
            return (double)_top / (double)_bottom;
        }
    }