//namespace App.Topics.Indexers.T1_1_IntList;

//public class IntList
//{
//    private int[] _items;
//    private int _count;

//    public IntList()
//    {
//        _items = new int[4];
//        _count = 0;
//    }

//    public int Count => _count;

//    public int this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= _count)
//                throw new ArgumentOutOfRangeException(nameof(index));

//            return _items[index];
//        }
//        set
//        {
//            if (index < 0 || index > _count)
//                throw new ArgumentOutOfRangeException(nameof(index));

//            if (index == _count)
//            {
//                EnsureCapacity();
//                _items[_count] = value;
//                _count++;
//            }
//            else
//            {
//                _items[index] = value;
//            }
//        }
//    }

//    private void EnsureCapacity()
//    {
//        if (_count >= _items.Length)
//        {
//            int newCapacity = _items.Length * 2;
//            int[] newArray = new int[newCapacity];
//            Array.Copy(_items, newArray, _count);
//            _items = newArray;
//        }
//    }
//}