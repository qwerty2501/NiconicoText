using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class IdNiconicoWebTextSegmentBase:PlainNiconicoWebTextSegmentWithUrlBase
    {
        internal IdNiconicoWebTextSegmentBase(string id): base(id) { }

        public new Uri Url
        {
            get
            {
                if (this.HasParent)
                {
                    return this.Parent.Url;
                }
                else
                {
                    return this.OnCreateUrl();
                }
            }

        }



    }
}
