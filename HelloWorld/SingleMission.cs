using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        private Func Function;
        public string Name { get; }

        public string Type { get; }

        /// <Constructor>
        /// thisis the class constructor.
        /// </summary>
        /// <param name="func"></param> the function algorithm given as a single mission.
        /// <param name="name"></param> the name of the function
        public SingleMission(Func func,string name)
        {
            this.Name = name;
            this.Function = func;
            Type = "Single";

        }
 
        /// <summary>
        /// This calculates the functions result and returns it
        /// </summary>
        /// <param name="value"></patram> the value given as a parameter that sould be calculated.
        /// <returns></returns> the result of the functions calculation.
        public double Calculate(double value)
        {
            double newVal = Function(value);
            if (OnCalculate != null)
            {
                OnCalculate(this, newVal);
            }
            return newVal;
        }
    }
}
