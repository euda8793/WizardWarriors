using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    /// <summary>
    /// Action involving the affect to another person.
    /// </summary>
    /// <seealso cref="MageKnight.Model.IAction" />
    public interface IAffectAction : IAction
    {
        /// <summary>
        /// Gets the poi.
        /// </summary>
        /// <value>
        /// The poi.
        /// </value>
        ISoldier POI { get; }
    }
}
