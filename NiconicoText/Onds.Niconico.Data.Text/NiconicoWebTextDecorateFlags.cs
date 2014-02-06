using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    [Flags]
    internal enum NiconicoWebTextDecorateFlags:byte
    {
        None = 0,
        HasSegmentsFlag = 1,
        HasNumberAnchorFlag = 2,
        DecoratedUnderLineFlag = 4,
        DecoratedBoldFlag = 8,
        DecoratedStrikeFlag = 16,
        DecoratedItalicFlag = 32,
        DecoratedColorFlag = 64,
    }
}
