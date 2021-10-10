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