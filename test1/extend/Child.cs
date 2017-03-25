using System;

namespace test1.extend
{
    public class Circle : Parent
    {
        private int myRadius;

        /*
        直接用父类的方法也用冒号同 java的super(id)相似 */
        public Circle(int radius, string id) : base(id)
        {
            myRadius = radius;
        }
       
        public override double Area
        {
            get
            {
                return myRadius * myRadius * Math.PI;
            }
        } 
    }

    public class Rect : Parent
    {
        private int w;
        private int h;

        public Rect(int w, int h, string id) : base(id)        {
            this.w = w;
            this.h = h;
        }
        public override Double Area
        {
            get
            {
                return w * h;
            }
        }
    }
}