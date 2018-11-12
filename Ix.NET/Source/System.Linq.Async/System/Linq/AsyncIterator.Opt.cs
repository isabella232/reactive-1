﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq
{
    partial class AsyncIterator<TSource>
    {
        public virtual IAsyncEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
        {
            return new AsyncEnumerable.SelectEnumerableAsyncIterator<TSource, TResult>(this, selector);
        }

        public virtual IAsyncEnumerable<TResult> Select<TResult>(Func<TSource, Task<TResult>> selector)
        {
            return new AsyncEnumerable.SelectEnumerableAsyncIteratorWithTask<TSource, TResult>(this, selector);
        }

        public virtual IAsyncEnumerable<TSource> Where(Func<TSource, bool> predicate)
        {
            return new AsyncEnumerable.WhereEnumerableAsyncIterator<TSource>(this, predicate);
        }

        public virtual IAsyncEnumerable<TSource> Where(Func<TSource, Task<bool>> predicate)
        {
            return new AsyncEnumerable.WhereEnumerableAsyncIteratorWithTask<TSource>(this, predicate);
        }
    }
}
