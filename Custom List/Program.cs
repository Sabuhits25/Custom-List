using System.ComponentModel;
using Custom_List;

CustomList <int> lists = new CustomList<int>();
lists.Add(1);
lists.Add(2);
lists.Add(3);
foreach (int item in lists)
{
    Console.WriteLine(item);
}