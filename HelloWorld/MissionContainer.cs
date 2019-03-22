using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Func(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, Func> funcDic;
        public FunctionsContainer()
        {
            this.funcDic = new Dictionary<string, Func>();
        }
        public Func this[string functionName]
        {
            get
            {
                if (!funcDic.ContainsKey(functionName))
                {
                    funcDic[functionName] = val => val;
                }
                return this.funcDic[functionName];
            }
            set
            {
                this.funcDic[functionName] = value;
         
            }
        }
        //this will return all of the function names.
        public List<string> getAllMissions()
        {
            List<String> missionNames = new List<string>();
            //add the keys of the function to a list.
            foreach(var item in funcDic.Keys)
            {
                missionNames.Add(item);
            }
            return missionNames;
        }

    }
}
