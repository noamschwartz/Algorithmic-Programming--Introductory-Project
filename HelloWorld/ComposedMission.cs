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
        /// <summary>
        /// this is the class constructor.
        /// </summary>
        /// <param name="name"></param> the name of a mission to add to the composed mission created
        public ComposedMission(string name)
        {
            this.Name = name;
            this.ListOfMissions = new List<Func>();
            Type = "Composed";
        }
       /// <summary>
       /// this function adds a func to a mission being built
       /// </summary>
       /// <param name="func"></param> the function name to be added to the mission
       /// <returns></returns>
        public ComposedMission Add(Func func)
        {
            ListOfMissions.Add(func);
            return this;
        }
        /// <summary>
        /// this function calculated the mission using all of the functions the the mission consists.
        /// </summary>
        /// <param name="value"></param> the value to run the mission functions on.
        /// <returns></returns>
        public double Calculate(double value)
        {
            //apply the value on all of the functions in the mission.
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
