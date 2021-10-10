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
            Assert.AreEqual(this._stringArray.Length, 0);
            // test add first item
            this._stringArray.Add("test1");
            Assert.AreEqual(this._stringArray.Length, 1);
            Assert.AreEqual(this._stringArray.GetAt(0), "test1");
            // test adding more items
            this._stringArray.Add("test2");
            Assert.AreEqual(this._stringArray.GetAt(2), "test2");
            this._stringArray.Add("test3");
            this._stringArray.Add("test4");
            this._stringArray.Add("test5");
            Assert.AreEqual(4, this._stringArray.OccupiedIndex);
            Assert.AreEqual("test5", this._stringArray.GetAt(this._stringArray.OccupiedIndex));

        }
    }
}
