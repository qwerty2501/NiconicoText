using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    interface INiconicoWord
    {
        NiconicoWordType TextType { get; }

        string Text { get; }

        string FriendlyText { get; }


    }
}
