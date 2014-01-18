using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    /// <summary>
    /// 
    /// </summary>
    public struct NiconicoWebTextNumberAnchorRange
    {
        internal NiconicoWebTextNumberAnchorRange(uint startNumber)
        {
            this.StartNumber = startNumber;
            this.EndNumber = 0;
        }

        public uint StartNumber;

        public uint EndNumber;

    }
}
