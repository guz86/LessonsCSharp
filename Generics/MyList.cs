using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private T[] _array = Array.Empty<T>();
        // Array.Empty<T>() - возвращает ссылку на статическое поле, как заглушка

        // индексатор в виде свойства
        // обращаемся к массиву и получаем по индексу значение элемента
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        // поле количество элементов
        public int Count { get { return _array.Length; } }
        // добавление элементов к массиву
        public void Add(T value)
        {
            // новый массив на большее количество элементов, добавляем значение
            // и присваиваем, т.к. Т, будет работать с любым типом данных
            var newArray = new T[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = value;
            _array = newArray;
        }
    }
}
