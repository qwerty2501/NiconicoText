using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal class NiconicoWebTextSegmentCollection : ObservableCollection<INiconicoWebTextSegment>, INiconicoWebTextSegmentCollection, IList<INiconicoWebTextSegment>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        internal NiconicoWebTextSegmentCollection() : base() { }
        internal NiconicoWebTextSegmentCollection(IEnumerable<INiconicoWebTextSegment> collection) : base(collection) { }

        internal INiconicoWebTextSegment Owner
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string ToFriendlyString()
        {
            return string.Empty;
        }


        public new IList<INiconicoWebTextSegment> Items
        {
            get { return this.Items; }
        }
    }
}
