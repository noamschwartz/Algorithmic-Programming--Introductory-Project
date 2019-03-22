using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get;  }
        private List<Func> ListOfMissions;
        public string Type { get; }
        public ComposedMission(string name)
        {
            this.Name = name;
            this.ListOfMissions = new List<Func>();
            Type = "Composed";
        }
       
        public ComposedMission Add(Func func)
        {
            ListOfMissions.Add(func);
            return this;
        }

        public double Calculate(double value)
        {
            foreach(Func mission in ListOfMissions)
            {
                value = mission(value);
            }
         
            if (OnCalculate != null)
            {
                OnCalculate(this, value);
            }
            return value;
        }
    }
}
