using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Game_Plataformas.Domain
{
    public abstract class EntityBase
    {
        const int GRAVITY = 3;
        const int JUMPFORCE = -24;
        const int VELOCITY = 2;
        public EntityBase(Canvas canvas)
        {
            Canvas = canvas;
            IsAlive = true;
        }

        public Canvas Canvas { get; set; }
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int FallVelocity { get; set; }
        public Rectangle Rect { get { return GetRetangle(); } }
        public Rect Area { get { return GetArea(); } }
        public Rect Left { get { return GetLeft(); } }
        public Rect Top { get { return GetTop(); } }
        public Rect Right { get { return GetRight(); } }
        public Rect Bottom { get { return GetBottom(); } }

        public abstract void Draw();

        public virtual void Gravity()
        {

            FallVelocity += GRAVITY;
            Y += FallVelocity;          

        }

        public virtual void MoveLeft()
        {
            X -= VELOCITY;
        }

        public virtual void MoveRight()
        {
            X += VELOCITY;
        }

        public virtual void MoveUp()
        {
            Y -= VELOCITY;
        }

        public virtual void MoveDown()
        {
            Y += VELOCITY;
        }

        public virtual void Jump()
        {
            FallVelocity = JUMPFORCE;
        }

        private Rectangle GetRetangle()
        {
            return new Rectangle
            {
                Height = this.Height,
                Width = this.Width,
            };
        }

        protected Thickness GetPosition()
        {
            return new Thickness(X, Y, X + Width, Y + Height);
        }

        private Rect GetArea()
        {
            return new Rect(new Point(X, Y), new Size(Width, Height));
        }

        private Rect GetLeft()
        {
            return new Rect(new Point(X, Y), new Size(Width / 4, Height));
        }

        private Rect GetTop()
        {
            return new Rect(new Point(X, Y), new Size(Width, Height / 4));
        }

        private Rect GetRight()
        {
            return new Rect(new Point(X + (Width / 2) + (Width / 4), Y), new Size(Width / 4, Height));
        }

        private Rect GetBottom()
        {
            return new Rect(new Point(X, Y + (Height / 4) + (Height / 2)), new Size(Width, Height / 4));
        }
    }
}
