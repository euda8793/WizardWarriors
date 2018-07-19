using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public sealed class Rules
    {
        private static Rules instance = null;

        

        private Rules()
        {

        }
        
        public static Rules Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rules();
                }

                return instance;
            }
        }
    }
}
