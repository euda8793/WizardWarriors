using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    /// <summary>
    /// A rule is an object that tests if an action inolving 1 to 1 or 1 to many is valid.
    /// </summary>
    public interface IRule
    {
        /// <summary>
        /// Gets the entities involved in this rule.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        IList<Type> Entities { get; }

        /// <summary>
        /// Returns true if this action is valid.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>
        ///   <c>true</c> if the specified action is valid; otherwise, <c>false</c>.
        /// </returns>
        bool IsValid(IAction action);
    }
}
