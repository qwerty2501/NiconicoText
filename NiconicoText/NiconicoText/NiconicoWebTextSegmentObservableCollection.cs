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
    internal class NiconicoWebTextSegmentObservableCollection : ObservableCollection<INiconicoWebTextSegment>,INiconicoWebTextSegmentCollection, INiconicoWebTextSegmentObservableCollection, IList<INiconicoWebTextSegment>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        internal NiconicoWebTextSegmentObservableCollection() : base() { }
        internal NiconicoWebTextSegmentObservableCollection(IEnumerable<INiconicoWebTextSegment> collection) : base(collection) { }

        internal INiconicoWebTextSegment Owner
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Concat(this.Select((item) => item.Text));
        }

        public string ToFriendlyString()
        {
            return string.Concat(this.Select((item) => item.FriendlyText));
        }

        protected override void InsertItem(int index, INiconicoWebTextSegment item)
        {
            if (!checkCanInsert(item))
                throw new InvalidOperationException("item can not insert to this collection.");

            var segment = (NiconicoWebTextSegmentBase)item;
            segment.Parent = this.Owner;

            base.InsertItem(index, item);
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

        public new IList<INiconicoWebTextSegment> Items
        {
            get { return base.Items; }
        }

        

        private void removeParentAt(int index)
        {
            var source = (NiconicoWebTextSegmentBase)this[index];
            source.Parent = null;
        }

        private bool checkCanInsert(INiconicoWebTextSegment item)
        {
            return ((!checkAlreadyExists(item)) && item.Parent == null && item is NiconicoWebTextSegmentBase );
        }

        private bool checkAlreadyExists(INiconicoWebTextSegment item)
        {
            return checkAlreadyExists(this.Owner, item);
        }

        private static bool checkAlreadyExists(INiconicoWebTextSegment owner, INiconicoWebTextSegment item)
        {
            if (owner == item)
                return true;

            if (owner != null)
            {
                return checkAlreadyExists(owner.Parent, item);
            }
            else
            {
                return false;
            }

        }


    }
}
