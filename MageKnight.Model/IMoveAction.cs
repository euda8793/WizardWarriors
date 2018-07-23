using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    /// <summary>
    /// Action that involves moving somewhere.
    /// </summary>
    /// <seealso cref="MageKnight.Model.IAction" />
    public interface IMoveAction : IAction
    {
        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        Point Location { get; }
    }
}
