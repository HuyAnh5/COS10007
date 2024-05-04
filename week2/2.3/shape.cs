using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Shape
    {
        
            private Color _color;
            private float _x, _y;
            private float _width, _height;

            public Shape()
            {
                _color = Color.Red;
                _x = 800 / 2;
                _y = 600 / 2;
                _width = 80;
                _height = 60;
            }

            public Color Color
            {
                get
                {
                    return _color;
                }
                set
                {
                    _color = value;
                }
            }

            public float X
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }

            public float Y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }

            public float Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    _width = value;
                }
            }

            public float Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    _height = value;
                }
            }
            public void Draw()
            {
                SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            }
            public bool IsAt(Point2D pt)
            {
                return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, Width, Height));
            }
        
    }
}
