﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing a bananna
    /// </summary>
    public class Banana : Fruit 
    {
        /// Blends the banana
        /// </summary>
        /// <returns>The result of blending the banana</returns>
        public sealed override string Blend()
        {
            return "yellow mush";
        }
    }
}
