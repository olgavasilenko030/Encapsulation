#define print
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region print
			//Point A = new Point();
			////Console.WriteLine($"X={A.GetX()}\tY={A.GetY()}");
			////A.SetX(2000);
			////A.SetY(3000);
			////A.Print();
			//A.X = 22;
			//A.Y = 33;
			//A.Print(); 
			#endregion

			Point point1 = new Point(0, 0);
			Point point2 = new Point(6, 8);

			double distance = point1.Distance(point2);

			Console.WriteLine($"Distance between point1 and point2 is: {distance}");
		}
	}
}
