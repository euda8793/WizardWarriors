using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    /// <summary>
    /// Action object.
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// Acts the specified soldier.
        /// </summary>
        /// <param name="soldier">The soldier.</param>
        /// <returns>If the action is completed or not.</returns>
        bool Act(ISoldier soldier, params object[] others);
    }
}
