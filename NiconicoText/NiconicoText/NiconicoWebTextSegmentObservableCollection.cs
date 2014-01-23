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
    internal class NiconicoWebTextSegmentObservableCollection : NiconicoWebTextSegmentCollection, INiconicoWebTextSegmentCollection, INiconicoWebTextSegmentObservableCollection, IList<INiconicoWebTextSegment>, INotifyCollectionChanged
    {
        internal NiconicoWebTextSegmentObservableCollection() : base() { }
        internal NiconicoWebTextSegmentObservableCollection(IEnumerable<INiconicoWebTextSegment> collection) : base(collection) { }

        

        public new IList<INiconicoWebTextSegment> Items
        {
            get { return base.Items; }
        }

        protected override void InsertItem(int index, INiconicoWebTextSegment item)
        {
            base.InsertItem(index, item);

            onCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add,item,index));
        }

        protected override void RemoveItem(int index)
        {
            var changingItem = this[index];
            base.RemoveItem(index);

            onCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changingItem, index));
        }

        protected override void SetItem(int index, INiconicoWebTextSegment item)
        {
            var changingItem = this[index];
            base.SetItem(index, item);
            onCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, changingItem, index));
        }


        private void onCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            if (this.CollectionChanged != null) this.CollectionChanged(this, args);
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
