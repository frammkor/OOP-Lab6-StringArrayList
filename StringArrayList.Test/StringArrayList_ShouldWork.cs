/* 
Franco Cespi
CS-1415 Lab 6: StringArrayList
Started: 10/11/2021
Testing the StringArrayList
*/

using System;
using NUnit.Framework;

namespace StringArrayList.Test
{
    public class Tests
    {
        private IStringList _stringArray;
        [SetUp]
        public void Setup()
        {
            this._stringArray = new StringArrayList();
        }

        [Test]
        public void Test()
        {
            // test Length
            Assert.AreEqual(0, this._stringArray.Length);
            // test Add()
            this._stringArray.Add("test0");
            Assert.AreEqual(1, this._stringArray.Length);
            // test GetAt()
            Assert.AreEqual(this._stringArray.GetAt(0), "test0");
            // test adding more items
            this._stringArray.Add("test1");
            Assert.AreEqual(this._stringArray.GetAt(1), "test1");
            Assert.AreEqual(2, this._stringArray.Length);
            this._stringArray.Add("test2");
            this._stringArray.Add("test3");
            Assert.AreEqual(4, this._stringArray.Length);
            this._stringArray.Add("test4");
            // test OccupiedIndex
            Assert.AreEqual(4, this._stringArray.OccupiedIndex);
            Assert.AreEqual("test4", this._stringArray.GetAt(this._stringArray.OccupiedIndex));
            Assert.AreEqual(8, this._stringArray.Length);

            // test Remove()
            this._stringArray.Remove();
            Assert.AreEqual(3, this._stringArray.OccupiedIndex);
            Assert.AreEqual("test3", this._stringArray.GetAt(this._stringArray.OccupiedIndex));

            // teste RemoveAt()
            this._stringArray.RemoveAt(0);
            Assert.AreEqual("test1", this._stringArray.GetAt(0));
            Assert.AreEqual(2, this._stringArray.OccupiedIndex);
            Assert.AreEqual("test3", this._stringArray.GetAt(this._stringArray.OccupiedIndex));

            // test SetAt()
            this._stringArray.SetAt(1, "setAt1");
            Assert.AreEqual("setAt1", this._stringArray.GetAt(1));

            // test AddAt()
            this._stringArray.SetAt(0, "test0");
            Assert.AreEqual(this._stringArray.GetAt(0), "test0");
            Assert.AreEqual(2, this._stringArray.OccupiedIndex);

            // test AddAt() 2
            this._stringArray.SetAt(2, "setAt2");
            Assert.AreEqual(this._stringArray.GetAt(2), "setAt2");
            Assert.AreEqual(2, this._stringArray.OccupiedIndex);

            // AddAt() bad argument and concistency
            Assert.Throws<IndexOutOfRangeException>(() => this._stringArray.SetAt(-1, "setAt2"));
            Assert.AreEqual(this._stringArray.GetAt(2), "setAt2");
            Assert.AreEqual(2, this._stringArray.OccupiedIndex);
        }
    }
}
