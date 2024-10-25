using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_2_kursporv_del_2
{
    internal class Car
    {
        protected double _carWeight;
        protected double _carWeightReducement;
        protected double _carMilage;
        protected double _carMileageReducement;

        public double WeightReducment()
        {
            double weightReducement = _carWeight / 1000;
            _carWeightReducement = weightReducement;
            return _carWeightReducement;
        }
        public double CarMileageReducement()
        {
            double carMileageReducement = _carMilage / 1000;
            _carMileageReducement = carMileageReducement;
            return _carMileageReducement;
        }

        public Car(double inputCarWeight, double inputCarMileage)
        {
            _carMilage = inputCarMileage;
            _carWeight = inputCarWeight;
        }
    }
}
