using System;
using System.Collections;
using System.Collections.Generic;

namespace Enigmatic.Main.Common
{
    public class BiDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _forward;
        private Dictionary<TValue, TKey> _backward;

        public BiDictionary()
        {
            _forward = new Dictionary<TKey, TValue>();
            _backward = new Dictionary<TValue, TKey>();
        }

        public void Add(TKey key, TValue value)
        {
            _forward.Add(key, value);
            _backward.Add(value, key);
        }
        
        public void Clear()
        {
            _forward.Clear();
            _backward.Clear();
        }
        
        public bool ContainsKey(TKey key)
        {
            return _forward.ContainsKey(key);
        }

        public bool ContainsValue(TValue value)
        {
            return _backward.ContainsKey(value);
        }

        public TValue GetByKey(TKey key)
        {
            return _forward[key];
        }

        public TKey GetByValue(TValue value)
        {
            return _backward[value];
        }

        public void RemoveByKey(TKey key)
        {
            var value = _forward[key];

            _forward.Remove(key);
            _backward.Remove(value);
        }
        public void RemoveByValue(TValue value)
        {
            var key = _backward[value];

            _forward.Remove(key);
            _backward.Remove(value);
        }
    }
}
