using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public interface INiconicoWebTextSegmentCollection : IList<INiconicoWebTextSegment>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Create a Friendly String.
        /// </summary>
        /// <returns></returns>
        string ToFriendlyString();


        /// <summary>
        /// Gets a IList<INiconicoWebTextSegment> wrapper around the Collection<INiconicoWebTextSegment>.
        /// </summary>
        IList<INiconicoWebTextSegment> Items { get; }
    }


}
