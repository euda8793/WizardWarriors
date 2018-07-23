using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public abstract class RuleBase : IRule
    {
        private IList<Type> entities;

        public IList<Type> Entities => this.entities;

        public RuleBase(IAction action)
        {
            this.entities = entities;
        }

        public abstract bool IsValid(IAction action);
    }
}
