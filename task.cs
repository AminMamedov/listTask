namespace ConsoleApp6.models;

public class Myclass<T>
{
    private T[] _arr;
    public Myclass()
    {
        _arr = new T[0];
    }
    public void Add(T obj)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[_arr.Length - 1] = obj;
    }
    public void ShowAll()
    {
        foreach (T obj in _arr)
        {
            Console.WriteLine(obj);
        }
    }
    public int FirstIndex(T obj)
    {

        for (int i = 0; i < _arr.Length; i++)
        {
            if (Equals(obj, _arr[i])) return i;
        }
        return -1;
    }




    public void CustomReamove(T obj)
    {
        for (int i = 0; i <= _arr.Length-1; i++)
        {
            if (Equals(_arr[i], obj))
            {
                _arr[i] = default;
                for (int j = i; j < _arr.Length-1; j++)
                {
                    _arr[j] = _arr[j +1];
                }
                Array.Resize(ref _arr, _arr.Length - 1);
            }
        }
    }
}







