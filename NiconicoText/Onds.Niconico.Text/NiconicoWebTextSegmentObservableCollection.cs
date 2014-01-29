using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal class NiconicoWebTextSegmentObservableCollection : ObservableCollection<INiconicoWebTextSegment>, INiconicoWebTextSegmentObservableCollection, IList<INiconicoWebTextSegment>,IReadOnlyList<INiconicoWebTextSegment>, INotifyCollectionChanged
    {
        internal NiconicoWebTextSegmentObservableCollection() : base() { }
        internal NiconicoWebTextSegmentObservableCollection(IReadOnlyList<INiconicoWebTextSegment> collection) : base(collection) { }

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


        protected override void ClearItems()
        {
            for (var index = 0; index < this.Count; index++)
            {
                removeParentAt(index);
            }
            base.ClearItems();
        }

        protected override void RemoveItem(int index)
        {
            removeParentAt(index);
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, INiconicoWebTextSegment item)
        {
            if (!checkCanInsert(item))
                throw new InvalidOperationException("item can not set to this collection.");
            var segment = (NiconicoWebTextSegmentBase)item;
            segment.Parent = this.Owner;
            removeParentAt(index);
            base.SetItem(index, item);
        }





        private void removeParentAt(int index)
        {
            var source = (NiconicoWebTextSegmentBase)this[index];
            source.Parent = null;
        }

        private bool checkCanInsert(IReadOnlyNiconicoWebTextSegment item)
        {
            return (item.Parent == null && item is NiconicoWebTextSegmentBase);
        }
    }
}
