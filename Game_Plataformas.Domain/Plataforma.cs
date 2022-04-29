using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game_Plataformas.Domain
{
    public class Plataforma : EntityBase
    {
        Rectangle _rect;
        public Plataforma(Canvas canvas, int x, int y, int width, int height) : base(canvas)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
            _rect = Rect;
            _rect.Fill = Brushes.Transparent;
            _rect.Margin = GetPosition();
        }

        public override void Draw()
        {           
            Canvas.Children.Add(_rect);
        }
    }
}
