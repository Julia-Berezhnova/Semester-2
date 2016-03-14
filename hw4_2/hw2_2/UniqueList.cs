using System;

namespace List
{
    /// <summary>
    /// Class inherited from class List which cannot contain two equal values.
    /// </summary>
    class UniqueList: List
    {
        protected ListElement FindElement(int element)
        {
            if (!this.IsEmpty())
            {
                ListElement temp = this.head;
                while (temp != null)
                {
                    if (temp.Value == element)
                    {
                        return temp;
                    }
                    temp = temp.Next;
                }
            }
            throw new ValueNotFoundException();
        }

        public override void AddElement(int element)
        {
            try
            {
                ListElement temp = FindElement(element);
                throw new RepeatedValueException();
            }
            catch (ValueNotFoundException)
            {
                base.AddElement(element);
            }
        }
    }
}
