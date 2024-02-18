using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velocity_of_a_car
{
	internal class Car
	{
		//Properties 
		protected double distence;

		public double Distance 
		{
			get { return distence; }
			set { distence = value; }
		}

		protected double time;

		public double Time
		{
			get { return time; }
			set { time = value; }
		}

		//Constructor 

		public Car() 
		{ 
			time = 0;
			distence = 0;	
		}



		//Method 
		public double GetSpeed() 
		{
		return Distance/time;
		}

			

	}
}
