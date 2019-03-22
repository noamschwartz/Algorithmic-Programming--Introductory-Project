using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Func(double val);
    /// <summary>
    /// this is the constructor of the class
    /// </summary>
    public class FunctionsContainer
    {
        //a dictionary holds the function name as a key and algorithm as a value.
        private Dictionary<string, Func> funcDic;
        public FunctionsContainer()
        {
            //create new dictionary.
            this.funcDic = new Dictionary<string, Func>();
        }
        /// <summary>
        /// delegate function family.
        /// </summary>
        /// <param name="functionName"></param> the name of the function
        /// <returns></returns>
        public Func this[string functionName]
        {
            get
            {
                //check if the function exists.
                if (!funcDic.ContainsKey(functionName))
                {
                    funcDic[functionName] = val => val;
                }
                return this.funcDic[functionName];
            }
            set
            {
                //give the function tis value.
                this.funcDic[functionName] = value;
         
            }
        }
        /// <summary>
        /// this will return all of the function names.
        /// </summary>
        /// <returns></returns> a list of the function names.

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
