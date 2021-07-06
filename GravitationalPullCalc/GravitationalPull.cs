using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationalPullCalc
{
    class GravitationalPull
    {
        //Gravitational Constant
        private double gravConst;
        public Double GetGravConst()
        {
            return gravConst;
        }
        public void SetGravConst(double gravConst)
        {
            this.gravConst = gravConst;
            Calc();
        }

        //Mass1
        private double mass1;
        public Double GetMass1()
        {
            return mass1;
        }
        public void SetMass1(double mass1)
        {
            this.mass1 = mass1;
            Calc();
        }

        //Mass2
        private double mass2;
        public Double GetMass2()
        {
            return mass2;
        }
        public void SetMass2(double mass2)
        {
            this.mass2 = mass2;
            Calc();
        }

        //Distance
        private double distance;
        public Double GetDistance()
        {
            return distance;
        }
        public void SetDistance(double distance)
        {
            this.distance = distance;
            Calc();
        }

        //Gravitational Force
        private double gravForce;
        public Double GetGravForce()
        {
            return gravForce;
        }

        //Calculation Methods
        private void Calc()
        {
            double M1 = mass1;
            double M2 = mass2;
            double R = distance;
            double G = Math.Pow(6.67408, -11);

            //Calculates Gravitational Force between 2 objects
            double gravForce = (G * (M1 * M2)) / Math.Pow(R, 2);
        }
    }
}
