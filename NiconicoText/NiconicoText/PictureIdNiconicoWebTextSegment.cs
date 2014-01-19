using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class PictureIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal PictureIdNiconicoWebTextSegment(string pictureId) : base(pictureId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }
    }
}
