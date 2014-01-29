using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal struct FontElementSize
    {
        internal FontElementSize(byte size)
        {
            this.size_ = size;
        }

        public static implicit operator FontElementSize(byte size)
        {
            if (size < 0 || size > 7)
                throw new InvalidOperationException("Font element size must be less than 7 and 1 or more.");

            return new FontElementSize(size);
        }

        public static implicit operator byte(FontElementSize size)
        {
            return size.size_;
        }

        private byte size_;

        internal const byte defaultSize = 3;
    }
}
