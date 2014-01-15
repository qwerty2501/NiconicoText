using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public interface INiconicoTextSegment
    {
        INiconicoTextSegment PalentSegment { get; }


        string Text { get; }

        string FriendlyText { get; }


    }
}
