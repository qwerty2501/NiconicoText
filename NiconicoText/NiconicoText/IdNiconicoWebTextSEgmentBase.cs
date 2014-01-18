using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class IdNiconicoWebTextSegmentBase:PlainNiconicoWebTextSegmentWithUrlBase
    {
        protected internal override Uri OnCreateUrl()
        {
            if (this.HasParent)
            {
                return this.Parent.Url;
            }
            else
            {
                return this.OnCreateUrlAssosiatedId();
            }
        }

        protected internal abstract Uri OnCreateUrlAssosiatedId();
    }
}
