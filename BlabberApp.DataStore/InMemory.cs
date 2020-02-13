using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.Domain
{
    public class InMemory : IDataStore
    {
        private ArrayList _items = new ArrayList();
        public bool Create(IDatum datum)
        {
            int idx = this._items.Add(datum);
            if (idx < 0)
            {
                throw new IndexOutOfRangeException("oh shit");
            }
            return true;
        }

        public IDatum Read(int index)
        {
            return (BlabberApp.Domain.IDatum)this._items[index];
        }

        public bool Update(IDatum datum)
        {
            return true;
        }

        public bool Delete(ISpecimen specimen)
        {
            try
            {
                this._items.Remove(specimen);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            return true;
        }
    }
}
