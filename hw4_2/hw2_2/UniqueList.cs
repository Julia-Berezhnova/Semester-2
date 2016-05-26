using System;

namespace List
{
    /// <summary>
    /// Class inherited from class List which cannot contain equal values.
    /// </summary>
    class UniqueList: List
    {
        public override void AddElement(int element)
        {
            if (Contains(element))
                    throw new RepeatedValueException();
            else
                base.AddElement(element);            
        }
    }
}
