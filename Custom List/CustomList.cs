using System.Collections;

namespace Custom_List;

public class CustomList<T> : IEnumerable<T>
{
    public T[] Lists;
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Remove(T item)
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].Equals(item))
            {

                for (int j = i; j < Lists.Length - 1; j++)
                {
                    Lists[j] = Lists[j + 1];
                }


                Array.Resize(ref Lists, Lists.Length - 1);


            }
        }
    }
    public void RemoveAll()
    {
        Array.Resize<T>(ref Lists,0);
    }

    public void Add(T item)
    {
        Array.Resize(ref Lists, Lists.Length + 1);
        Lists[Lists.Length - 1] = item;
    }
    

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        foreach (var item in Lists)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var item in Lists)
        {
            yield return item;
        }
    }

        public T this[int index]
        {
            get { return Lists[index]; }
            set { Lists[index] = value; }
        }

        public CustomList()
        {
            Lists = new T[0];
        }
    

  
    
       

}
