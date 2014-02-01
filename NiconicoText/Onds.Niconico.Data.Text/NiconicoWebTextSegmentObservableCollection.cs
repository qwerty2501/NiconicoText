using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal class NiconicoWebTextSegmentObservableCollection : Collection<INiconicoWebTextSegment>, INiconicoWebTextSegmentCollection, IList<INiconicoWebTextSegment>, IReadOnlyList<INiconicoWebTextSegment>, IReadOnlyList<IReadOnlyNiconicoWebTextSegment>
    {
        internal NiconicoWebTextSegmentObservableCollection() : base() { }
        internal NiconicoWebTextSegmentObservableCollection(IList<INiconicoWebTextSegment> list) : base(list) { }

        internal IReadOnlyNiconicoWebTextSegment Owner
        {
            get;
            set;
        }

        public new IList<INiconicoWebTextSegment> Items
        {
            get { return base.Items; }
        }



        

        public override string ToString()
        {
            return this.ToText();
        }

        public string ToFriendlyString()
        {
            return this.ToFriendlyText();
        }



        IReadOnlyNiconicoWebTextSegment IReadOnlyList<IReadOnlyNiconicoWebTextSegment>.this[int index]
        {
            get { return this[index]; }
        }

        int IReadOnlyCollection<IReadOnlyNiconicoWebTextSegment>.Count
        {
            get { return this.Count; }
        }

        IEnumerator<IReadOnlyNiconicoWebTextSegment> IEnumerable<IReadOnlyNiconicoWebTextSegment>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
