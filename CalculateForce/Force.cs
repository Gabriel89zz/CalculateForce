using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateForce
{
    internal class Force
    {
		private double mass;

		public double Mass
		{
			get { return mass; }
			set { mass = value; }
		}

		private double acceleration;

		public double Acceleration
        {
			get { return acceleration; }
			set { acceleration = value; }
		}

        public Force()
        {
			mass = 0;
			acceleration = 0;
        }

		public double CalculeteForce(Force blow) 
		{
			return blow.mass*blow.acceleration;
		}
    }
}
