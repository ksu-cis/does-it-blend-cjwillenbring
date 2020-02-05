using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        /// <summary>
        /// The blending of the fruit.
        /// </summary>
        /// <returns>What happens when a fruit is blended.</returns>
        public virtual string Blend()
        {
            return "Goop";
        }
    }
}
