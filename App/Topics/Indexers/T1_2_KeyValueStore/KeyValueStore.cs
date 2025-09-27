//namespace App.Topics.Indexers.T1_2_KeyValueStore;

//public class KeyValueStore
//{
//    private readonly Dictionary<int, string> _byId = new();
//    private readonly Dictionary<string, string> _byKey = new();

//    public string this[int id]
//    {
//        get
//        {
//            if (!_byId.TryGetValue(id, out var value))
//                throw new KeyNotFoundException();
//            return value;
//        }
//        set
//        {
//            _byId[id] = value;
//        }
//    }

//    public string this[string key]
//    {
//        get
//        {
//            if (key == null)
//                throw new ArgumentNullException(nameof(key));

//            if (!_byKey.TryGetValue(key, out var value))
//                throw new KeyNotFoundException();
//            return value;
//        }
//        set
//        {
//            if (key == null)
//                throw new ArgumentNullException(nameof(key));

//            _byKey[key] = value;
//        }
//    }
//}