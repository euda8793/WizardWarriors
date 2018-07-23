using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public sealed class RuleBook
    {
        private static RuleBook instance = null;    


        private RuleBook()
        {

        }

        public static bool IsValid(IAction action)
        {

        }
        
        public static RuleBook Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RuleBook();
                }

                return instance;
            }
        }
    }
}
