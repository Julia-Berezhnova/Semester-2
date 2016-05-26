using System.Collections.Generic;
using System.Collections;
using System;

namespace task2
{
    /// <summary>
    /// Set template class.
    /// Set is understood mathematically with operations of
    /// adding, checking beloning, removing elements, 
    /// intersection and integration with another set
    /// and getting set's elements as a list of its elements
    /// </summary>
    public class Set<T> 
    {
        public Set()
        {
            set = new List<T>();
        }

        public List<T> GetAsList() => set;

        public bool Add(T element)
        {
            if (set.Contains(element))
            {
                return false;
            }
            set.Add(element);
            return true;
        }

        public bool Remove(T element) => set.Remove(element);

        public bool Contains(T element) => set.Contains(element);

        public Set<T> Intersection(Set<T> anotherSet)
        {
            var result = new Set<T>();
            foreach (T anotherElement in anotherSet.GetAsList())
            {
                if (set.Contains(anotherElement))
                {
                    result.Add(anotherElement);
                }
            }
            return result;
        }

        public Set<T> Integration(Set<T> anotherSet)
        {
            var result = new Set<T>();
            foreach (T anotherElement in anotherSet.GetAsList())
            {
                result.Add(anotherElement);
            }
            foreach (T element in set)
            {
                result.Add(element);
            }
            return result;
        }

        private List<T> set;
    }
}

