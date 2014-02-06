using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal class NiconicoWebTextSegmentCollection : Collection<INiconicoWebTextSegment>, INiconicoWebTextSegmentCollection, IList<INiconicoWebTextSegment>, IReadOnlyList<INiconicoWebTextSegment>, IReadOnlyList<IReadOnlyNiconicoWebTextSegment>
    {
        internal NiconicoWebTextSegmentCollection(INiconicoWebTextSegment owner) : base() 
        {
            this.Owner = owner;
        }

        internal NiconicoWebTextSegmentCollection(INiconicoWebTextSegment owner, IList<INiconicoWebTextSegment> segments)
            : base(segments)
        {
            this.Owner = owner;
        }

        internal INiconicoWebTextSegment Owner
        {
            get;
            set;
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


        protected override void InsertItem(int index, INiconicoWebTextSegment item)
        {
            
            base.InsertItem(index, item);
            this.Owner.Root.RaiseTextUpdate();
        }

        protected override void SetItem(int index, INiconicoWebTextSegment item)
        {
            base.SetItem(index, item);
            this.Owner.Root.RaiseTextUpdate();
        }

        public IReadOnlyList<INiconicoWebTextSegment> ImportText(string text)
        {
            var items = parseText(text);
            foreach (var item in items)
            {
                this.Items.Add(item);
            }

            this.Owner.Root.RaiseTextUpdate();

            return items;
        }

        public IReadOnlyList<INiconicoWebTextSegment> InsertTextBefore(string text, INiconicoWebTextSegment referenceSegment)
        {
            throw new NotImplementedException();
        }

        public INiconicoWebTextSegment ImportSegment(IReadOnlyNiconicoWebTextSegment newSegment)
        {
            throw new NotImplementedException();
        }

        public INiconicoWebTextSegment InsertSegmentBefore(IReadOnlyNiconicoWebTextSegment newSemgment, INiconicoWebTextSegment referenceSegment)
        {
            throw new NotImplementedException();
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            this.Owner.Root.RaiseTextUpdate();
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            this.Owner.Root.RaiseTextUpdate();
        }
        public INiconicoWebTextSegment RemoveSegment(INiconicoWebTextSegment semgent)
        {
            throw new NotImplementedException();
        }


        private IReadOnlyList<INiconicoWebTextSegment> parseText(string text)
        {
            switch (this.Owner.Root.TextType)
            {
                case NiconicoTextType.Web:
                    return NiconicoWebTextSegmenter.DivideToWritableSegments(text, this.Owner);

                default:
                    throw new NotImplementedException();
            }
        }

    }
}
