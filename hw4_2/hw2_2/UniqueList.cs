using System;

namespace List
{
    /// <summary>
    /// Class inherited from class List which cannot contain two equal values.
    /// </summary>
    class UniqueList: List
    {
        public override void AddElement(int element)
        {
            if (FindElement(element))
                    throw new RepeatedValueException();
            else
                base.AddElement(element);            
        }
    }
}
