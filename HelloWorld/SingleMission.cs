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

        
        public SingleMission(Func func,string name)
        {
            this.Name = name;
            this.Function = func;
            Type = "Single";

        }
 

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
