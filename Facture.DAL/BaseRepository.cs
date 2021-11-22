using Serializations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.DAL
{
    public class BaseRepository<T>
    {
        protected List<T> datas;
        private Serializer<T> _serializer;

        public BaseRepository()
        {
            datas = new List<T>() { };
            _serializer = new Serializer<T>();
            Restore();
        }

        public int Check(T Obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
            {
                if (Obj.Equals(datas[i]))
                    index = i;
            }
            return index;
        }

        public void Add(T obj)
        {
            int index = Check(obj);
            if (index != -1)
                throw new DuplicateWaitObjectException($"{typeof(T).Name} already exists !");

            datas.Add(obj);
            Save();
        }

        public void SaveMany(List<T> items, bool refresh = false)
        {
            // Creer une nouvelle liste
            if (refresh)
            {
                datas = new List<T>() { };
            }

            int itemsCount = items.Count;
            for (int i = 0; i < itemsCount; i++)
            {
                datas.Add(items[i]);
            }
            Save();
        }

        public void Set(T oldObj, T newObj)
        {
            int oldIndex = Check(oldObj);
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found !");

            var newIndex = Check(newObj);

            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} already exists !");

            datas[oldIndex] = newObj;
        }

        public void Delete(T obj)
        {
            var index = Check(obj);
            if (index < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found !");

            if (index >= 0)
                datas.RemoveAt(index);
            Save();
        }

        public void Save()
        {
            _serializer.Serialize(datas);
        }

        public void Restore()
        {
            datas = _serializer.Deserialize();
        }

        public List<T> GetAll()
        {
            Restore();
            T[] items = new T[datas.Count];
            datas.CopyTo(items);
            return items.ToList<T>();
        }

        public T FindByIndex(int index)
        {
            if (index < 0 || index >= datas.Count)
                throw new KeyNotFoundException($"{typeof(T).Name} with index not found !");

            return datas[index];
        }

        public T Find(Predicate<T> predicate)
        {
            return datas.Find(predicate);
        }

        public List<T> FindAll(Predicate<T> predicate)
        {
            return datas.FindAll(predicate);
        }
    }
}
