﻿using System;
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
        HasUrlFlag = 2,
        HasNumberAnchorFlag = 4,
        DecoratedUnderLineFlag = 8,
        DecoratedBoldFlag = 16,
        DecoratedStrikeFlag = 32,
        DecoratedItalicFlag = 64,
        DecoratedColorFlag = 128,
    }
}
