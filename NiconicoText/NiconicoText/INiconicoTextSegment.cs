﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public interface INiconicoTextSegment
    {
        string Text { get; }

        string FriendlyText { get; }

        
    }
}
