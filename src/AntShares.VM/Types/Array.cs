﻿using System;
using System.Linq;
using System.Numerics;

namespace AntShares.VM.Types
{
    internal class Array : StackItem
    {
        private StackItem[] _array;

        public override bool IsArray => true;

        public Array(StackItem[] value)
        {
            this._array = value;
        }

        public override bool Equals(StackItem other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(null, other)) return false;
            Array a = other as Array;
            if (a == null)
                return false;
            else
                return _array.SequenceEqual(a._array);
        }

        public override StackItem[] GetArray()
        {
            return _array;
        }

        public override BigInteger GetBigInteger()
        {
            throw new NotSupportedException();
        }

        public override bool GetBoolean()
        {
            return _array.Length > 0;
        }

        public override byte[] GetByteArray()
        {
            throw new NotSupportedException();
        }
    }
}
