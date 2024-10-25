using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_2_kursporv_del_2
{
    internal class Parts : Car
    {
        private double _breakPads = 100;
        private double _breakPadUses;
        private double _wheels = 100;
        private double _wheelUses;
        private double _engine = 100;
        private double _engineUses;
        private double _wheelsAfterUse;
        private double _breaksAfterUse;
        private double _engineAfterUse;


        public Parts(double inputBreakPadUses, double inputWheelUses, double inputEngineUses, double inputCarWeight, double inputCarMileage) : base(inputCarWeight, inputCarMileage)
        {
            _breakPadUses = inputBreakPadUses;
            _wheelUses = inputWheelUses;
            _engineUses = inputEngineUses;
        }

        public double BreakPadReducement()
        {
            double breakPadReducement = _breakPadUses * _carWeightReducement * _carMileageReducement;
            _breaksAfterUse = _breakPads - breakPadReducement;
            return _breakPads;
        }
        public double EngineReducement()
        {
            double engineReducement = _engineUses * _carWeightReducement * _carMileageReducement;
            _engineAfterUse = _engine - engineReducement;
            return _breakPads;
        }

        public double WheelsReducement()
        {
            double Wheels;
            double wheelsreducement = _engineAfterUse * _carWeightReducement * _carMileageReducement;
            _wheelsAfterUse = _wheels - wheelsreducement;
            return _wheels;
        }

        public double CarPerformance()
        {
            double carPartsTogether = _wheelsAfterUse + _engineAfterUse + _breaksAfterUse;
            double VehiclePerformance = carPartsTogether / 3;
            Console.WriteLine("Bilens prestanda ligger på: " + VehiclePerformance);
            return 0;
        }
    }
}
