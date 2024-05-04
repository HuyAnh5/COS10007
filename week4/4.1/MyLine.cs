using SplashKitSDK;
using System.Drawing;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _endX,_endY;
        public MyLine(int startX, int startY, float endX,float endY)
        {
            _endX = endX;
            _endY = endY;
            X = startX;
            Y = startY;
            
        }

        public MyLine() : this(0, 0,10,10)
        {
        }

        public float endX
        {
            get { return _endX; }
            set { _endX = value; }
        }

        public float endY
        {
            get { return _endY; }
            set { _endY = value; }
        }

        public override void Draw()
        {
            if (Selected)
                DrawOutLine();
            SplashKit.DrawLine(Color, X, Y, _endX, _endY);
        }

        public override void DrawOutLine()
        {
            SplashKit.DrawLine(Color, X, Y, _endX + 5, _endY + 5);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, _endX, _endY));
        }

    }
}