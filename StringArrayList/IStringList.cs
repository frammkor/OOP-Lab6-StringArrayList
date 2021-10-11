/* 
Franco Cespi
CS-1415 Lab 6: StringArrayList
Started: 10/11/2021
Interface for StringList
*/

namespace StringArrayList
{
    public interface IStringList
    {
        int OccupiedIndex
        {
            get;
        }
        int Length
        {
            get;
        }
        void Add(string aString);

        void Remove();

        string GetAt(int index);

        void SetAt(int index, string aString);

        void AddAt(int index, string aString);

        void RemoveAt(int index);
    }
}