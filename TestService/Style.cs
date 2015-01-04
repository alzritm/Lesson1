using System;
using System.Drawing;

namespace TestService
{
    public class Style
    {
        private Color color;
        private Color backgroundColor;

        public Style()
        {
            color = Color.Empty;
            backgroundColor = Color.Empty;
        }

        public Style(Color color, Color backgroundColor)
        {
            if (!color.IsEmpty && !backgroundColor.IsEmpty)
            {
                throw new Exception("Color and backgroung Color cannot be used in the same time ! Choose color or backgroung Color only one !");
            }
            this.color = color;
            this.backgroundColor = backgroundColor;
        }



        public string GetString()
        {
            string res = "";
            if (!color.IsEmpty && !backgroundColor.IsEmpty)
            {
                throw new Exception("Color and backgroung Color cannot be used in the same time ! Choose color or backgroung Color only one !");
            }
            if (!color.IsEmpty)
            {
                res = String.Format("{0} color: #{1}{2}{3}", 
                    res, 
                    color.R.ToString("X2"), 
                    color.G.ToString("X2"), 
                    color.B.ToString("X2"));
            }
            if (!backgroundColor.IsEmpty)
            {
                res = String.Format("{0} background-color: #{1}{2}{3}", 
                    res, 
                    backgroundColor.R.ToString("X2"), 
                    backgroundColor.G.ToString("X2"), 
                    backgroundColor.B.ToString("X2"));
            }
            return res;
        }
    }
}
