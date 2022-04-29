using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game_Plataformas.Domain
{
    public class Bloco : EntityBase
    {
        Rectangle _rect;
        List<Plataforma> _plataforma;
        public Bloco(Canvas canvas, List<Plataforma> plataforma) : base(canvas)
        {
            _plataforma = plataforma;
            X = 385;
            Y = 3;
            Height = 20;
            Width = 20;
            _rect = Rect;
            _rect.Fill = Brushes.Red;
            _rect.Margin = GetPosition();
        }

        public override void Draw()
        {
            Canvas.Children.Add(_rect);

        }
        public override void Gravity()
        {
            if (_plataforma.Any(p => p.IsTouchingBottom(this)))
            {
                _rect.Margin = GetPosition();
                GameOver();
            }
            else
            {
                base.Gravity();
                _rect.Margin = GetPosition();
            }
        }
        public override void MoveLeft()
        {
            if (_plataforma.Any(p => p.IsTouchingLeft(this)))
            {
                _rect.Margin = GetPosition();
                GameOver();
            }
            else
            {
                base.MoveLeft();
                _rect.Margin = GetPosition();
            }
        }
        public override void MoveRight()
        {
            if (_plataforma.Any(p => p.IsTouchingRight(this)))
            {
                _rect.Margin = GetPosition();
                GameOver();
            }
            else
            {
                base.MoveRight();
                _rect.Margin = GetPosition();
            }
        }
        public override void MoveDown()
        {
            if (_plataforma.Any(p => p.IsTouchingBottom(this)))
            {
                _rect.Margin = GetPosition();
                GameOver();
            }
            else
            {
                base.MoveDown();
                _rect.Margin = GetPosition();
            }
        }
        public override void MoveUp()
        {
            if (_plataforma.Any(p => p.IsTouchingTop(this)))
            {
                _rect.Margin = GetPosition();
                GameOver();
            }
            else
            {
                base.MoveUp();
                _rect.Margin = GetPosition();
            }
        }
        public override void Jump()
        {

            base.Jump();
            _rect.Margin = GetPosition();


        }

        public void GameOver()
        {
            throw new ApplicationException("Game Over!");
        }
    }
}
