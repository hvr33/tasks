using System;
using System.Collections.Generic;
using System.Text;

namespace classpoint.Models
{
    internal class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        static public Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);

        }
        static public Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }
        public static Point operator /(Point p1, Point p2)
        {
            if (p2.x == 0 || p2.y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.x > p2.x) && (p1.y > p2.y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.x < p2.x) && (p1.y < p2.y);
        }
        public override bool Equals(object obj)
        {
            if (obj is Point p)
                return this == p;
            return false;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
