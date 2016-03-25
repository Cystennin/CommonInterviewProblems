using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Collections
{
    public class RavenHashTable<T>
    {
        private static readonly int INITIAL_SIZE = 10;
        private LinkedList<T>[] buckets;
        private int size;

        public RavenHashTable()
        {
            this.buckets = new LinkedList<T>[INITIAL_SIZE];
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public int Capacity
        {
            get
            {
                return this.buckets.Length;
            }
        }

        public RavenHashTable<T> Add(T element)
        {
            validate(element);
            if (resizeNeeded())
            {
                resize();
            }
            int hash = element.GetHashCode();
            int bucketIndex = Math.Abs(hash % buckets.Length);
            LinkedList<T> bucket = buckets[bucketIndex];
            if (null == bucket)
            {
                bucket = new LinkedList<T>();
                buckets[bucketIndex] = bucket;
            }
            bucket.AddLast(element);
            this.size++;
            return this;
        }

        public bool Exists(T element)
        {
            int hash = element.GetHashCode();
            int bucketIndex = hash % buckets.Length;
            LinkedList<T> bucket = buckets[bucketIndex];
            if (null == bucket)
            {
                return false;
            }
            if (bucket.Find(element) != null)
            {
                return true;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.size];
            foreach (LinkedList<T> bucket in buckets)
            {
                if (null == bucket)
                {
                    continue;
                }
                int arrayIndex = 0;
                foreach (T element in bucket)
                {
                    array[arrayIndex++] = element;
                }
            }
            return array;
        }

        private void resize()
        {
            LinkedList<T>[] newBucketList = new LinkedList<T>[this.size * 2];
            foreach (LinkedList<T> bucket in buckets)
            {
                if (null == bucket)
                {
                    continue;
                }
                foreach(T element in bucket)
                {
                    int hash = element.GetHashCode();
                    int bucketIndex = Math.Abs(hash % newBucketList.Length);
                    LinkedList<T> newBucket = newBucketList[bucketIndex];
                    if (null == newBucket)
                    {
                        newBucket = new LinkedList<T>();
                        newBucketList[bucketIndex] = newBucket;
                    }
                    newBucket.AddLast(element);
                }
            }
            this.buckets = newBucketList;
        }

        private bool resizeNeeded()
        {
            float loadFactor = ((float)this.size / (float)buckets.Length);
            if (loadFactor >.75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void validate(T element)
        {
            if (null == element)
            {
                throw new ArgumentNullException(nameof(element), "Element canot be null!");
            }
        }
    }
}
