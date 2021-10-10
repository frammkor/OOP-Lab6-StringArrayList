using System;

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
        }

        public void Add(string newItem) {
            Console.WriteLine($"Length = {_list.Length}");
            if (_list.Length == 0) {
                string[] newList = new string[] {newItem};
                this.OccupiedIndex = 0;
                this._list = newList;
                return;
            }
            if (this._list[this._list.Length - 1] is null)
            {
                string[] newList = new string[this._list.Length * 2];
                for (int i = 0; i < this._list.Length; i++)
                {
                    newList[i] = this._list[i];
                }
                this._list = newList;
                this._list[OccupiedIndex] = newItem;
                this.OccupiedIndex++;
            } else {
                this._list[OccupiedIndex] = newItem;
                this.OccupiedIndex++;
            }
        }

        public void Remove() {
            this.RemoveAt(this.OccupiedIndex - 1);
            return;
        }

        public string GetAt(int index) {
            return _list[index];
        }

        public void SetAt(int index, string aString) {
            _list[index] = aString;
            return;
        }
        public void AddAt(int index, string aString) {
            _list[index] = aString;
            return;
        }
        public void RemoveAt(int indexToRemove) {
            for (int i = indexToRemove; i < this.Length; i++)
            {
                this._list[i] = this._list[i + 1];
            }
            return;
        }
    }
}
