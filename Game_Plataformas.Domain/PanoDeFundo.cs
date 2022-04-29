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
    public class PanoDeFundo : EntityBase
    {
        Rectangle _rect;
        public PanoDeFundo(Canvas canvas) : base(canvas)
        {
            X = 0;
            Y = 0;
            Height = 680;
            Width = 800;
            _rect = Rect;
            _rect.Fill = Helper.GetImage(Media.Maze_2);
            
        }

        public override void Draw()
        {
            Canvas.Children.Add(_rect);
        }
    }
}
