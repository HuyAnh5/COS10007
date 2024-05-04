using System.Collections.Generic;
using System.Linq;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {

        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectShapeAt(Point2D point)
        {
            foreach (Shape s in _shapes)
            {
                s.Selected = (s.IsAt(point) | s.Selected) & !(s.IsAt(point) & s.Selected);
            }
        }

        public void DeleteSelectedShapes()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }
            }
        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public List<Shape> SelectedShape()
        {
            List<Shape> _selectedShapes = new List<Shape>();
            foreach (Shape s in _shapes)
            {
                if (s.Selected)
                {
                    _selectedShapes.Add(s);
                }
            }
            return _selectedShapes;
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }
    }
}