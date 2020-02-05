using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var p = new CellPhone();

            List<IBlendable> blendables = new List<IBlendable>() { b, s, m, c, p };
            foreach(IBlendable blendy in blendables)
            {
                Console.WriteLine(blendy.Blend());
            }
        }
    }
}
