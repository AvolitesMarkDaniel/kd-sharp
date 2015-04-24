using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTree
{
    /// <summary>
    /// Interface for a data object that can indicate its position in
    /// a notioanl n-dimensional space
    /// </summary>
    public interface IPositionalData
    {
        /// <summary>
        /// Gets the n-dimension position.
        /// Must be the same for all items in the tree.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        double[] Position { get; }
    }
}
