/* 
Franco Cespi
CS-1415 Lab 6: StringArrayList
Started: 10/11/2021
Implementation of a StringList
*/

namespace StringArrayList
{
  public class StringArrayList : IStringList
    {
        public int Length { get {
            return this._list.Length;
        } }
        public int OccupiedIndex { get; set; }
        private string[] _list;

        public StringArrayList()
        {
            this._list = new string[] {};
            this.OccupiedIndex = -1;
        }

        /*
            Add a new item to the array
            Handles empty array case and full array case
        */
        public void Add(string newItem) {
            this.OccupiedIndex++;
            // Console.WriteLine($"Length = {_list.Length}");
            if (_list.Length == 0) {
                this._list = new string[1];
            }
            DobleSizeIfNeeded();
            this._list[OccupiedIndex] = newItem;
        }


        /*
            Removes the item at the end of the list
        */
        public void Remove() {
            this._list[this.OccupiedIndex] = null;
            this.OccupiedIndex--;
            return;
        }


        /*
            Get an item by index
        */
        public string GetAt(int index) {
            return _list[index];
        }


        /*
            Set a value on a specific index
        */
        public void SetAt(int index, string aString) {
            _list[index] = aString;
            return;
        }
        public void AddAt(int indexToInsert, string aString) {
            if(indexToInsert > this.OccupiedIndex || indexToInsert < 0)
            {
                throw new System.IndexOutOfRangeException("Bad Index");
            }

            DobleSizeIfNeeded();

            // make space for the new item
            for (int i = indexToInsert; i <= this.OccupiedIndex; i++)
            {
                this._list[i + 1] = this._list[i];
            }

            this.OccupiedIndex++;
            _list[indexToInsert] = aString;
            return;
        }

        /*
            Removes the item a specific index
        */
        public void RemoveAt(int indexToRemove) {
            for (int i = indexToRemove; i <= this.OccupiedIndex; i++)
            {
                this._list[i] = this._list[i + 1];
            }
            this.OccupiedIndex--;
            return;
        }

        /*
            Creates bigger arrays when needed (empty array or full array)
        */
        private void DobleSizeIfNeeded()
        {
            if (this._list[this._list.Length - 1] is not null)
            {
                string[] newList = new string[this._list.Length * 2];
                for (int i = 0; i < this._list.Length; i++)
                {
                    newList[i] = this._list[i];
                }
                this._list = newList;
            }
        }
    }
}
