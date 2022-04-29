using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game_Plataformas.Domain
{
   public static class Helper
    {
        public static bool IsCollidingWith(this EntityBase o1, EntityBase o2)
        {
            if (o1.Area.IntersectsWith(o2.Area))
                return true;
            return false;
        }

        public static bool IsTouchingLeft(this EntityBase o1, EntityBase o2)
        {
            if (o1.Right.IntersectsWith(o2.Left))
                return true;
            return false;
        }

        public static bool IsTouchingRight(this EntityBase o1, EntityBase o2)
        {
            if (o1.Left.IntersectsWith(o2.Right))
                return true;
            return false;
        }

        public static bool IsTouchingTop(this EntityBase o1, EntityBase o2)
        {
            if (o1.Bottom.IntersectsWith(o2.Top))
                return true;
            return false;
        }

        public static bool IsTouchingBottom(this EntityBase o1, EntityBase o2)
        {
            if (o1.Top.IntersectsWith(o2.Bottom))
                return true;
            return false;
        }

        public static ImageBrush GetImage(byte[] bytes)
        {
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.StreamSource = new MemoryStream(bytes);
            img.EndInit();  

            return new ImageBrush(img);
        }
    }
}
