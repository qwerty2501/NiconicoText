using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    public delegate void NiconicoTextUpdateHandler();

    public interface INiconicoWebText:INiconicoText,IReadOnlyNiconicoWebText,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment,INiconicoWebTextSegment
    {
        event NiconicoTextUpdateHandler TextUpdated;

        void RaiseTextUpdate();
    }
}
