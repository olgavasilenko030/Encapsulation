#define getset
#define avtogetset
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		#region getset
		//double x;//smallCamal
		//double y;
		//	public double X // property//BigCamal
		//	{
		//		get
		//		{
		//			return x;
		//		}
		//		set
		//		{
		//			if(value>200) value=200;
		//			x = value;
		//		}
		//	}
		//	public double Y
		//	{
		//		get
		//		{
		//			return y;
		//		}
		//		set
		//		{
		//			if(value>150) value=200; y = value;
		//		}
		//	}
		//	public double GetX()
		//	{		return x; }
		//public double GetY() 
		//	{ return y; }

		//	public void SetX(double x)
		//	{
		//		if (x > 200) x = 200;
		//		this.x = x;

		//	}
		//	public void SetY(double y)
		//	{
		//		if (y > 150) y = 150;
		//		this.y = y;
		//	} 
		#endregion

		#region avtogetset
		//public double X {  get; set; } //Автосвойства
		//public double Y { get; set; }
		//public void Print()
		//{
		//	Console.WriteLine($"X={X}\tY={Y}");
		//	// Console.WriteLine($"X={GetX()}\tY={GetY()}");
		//} 
		#endregion

		public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public double Distance(Point otherPoint)
		{
			int dx = X - otherPoint.X;
			int dy = Y - otherPoint.Y;
			return Math.Sqrt(dx * dx + dy * dy);
		}

	}

}
