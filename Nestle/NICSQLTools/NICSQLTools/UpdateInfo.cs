using System;
using System.Collections.Generic;
using System.Linq;

namespace NICSQLTools
{
    public class UpdateInfo
    {
        List<object> _items;
        public event EventHandlerOnItemChanged OnItemChanged;
        public delegate void EventHandlerOnItemChanged(int index, object value);

        public UpdateInfo()
        {
            _items = new List<object>();
        }
        public void AddItem(object obj)
        {
            lock (_items)
            {
                _items.Add(obj);
            }
        }
        public void RemoveItem(object obj)
        {
            lock (_items)
            {
                _items.Remove(obj);
            }
            
        }
        public object GetValue(int index)
        {
            return _items[index];
        }
        public void SetValue(int index, object obj)
        {
            _items[index] = obj;
            if (OnItemChanged != null)
            {
                OnItemChanged(index, obj);
            }
        }

    }
}
