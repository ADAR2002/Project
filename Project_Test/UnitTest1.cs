
using Project;

namespace Project_Test
{
    [TestClass]
    public class UnitTest1
    {
        // start index from zero
        [TestMethod]
        public void TestMethod1()
        {
            int n = 6;//size of List
            List<int> arr = new List<int>() {5,10,6,7,9,8};
            Segment_tree segmentTree = new Segment_tree(arr,n);
            Assert.AreEqual(segmentTree.get_max(1, 3), 10);
            Assert.AreEqual(segmentTree.get_max(2, 4), 9);
            Assert.AreEqual(segmentTree.get_max(0, 0),5);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 5;
            List<int> arr = new List<int>() { 5, 1, 0, 2, 7 };
            Segment_tree segmentTree = new Segment_tree(arr,n);

            Assert.AreEqual(segmentTree.get_max(0, 4), 7);
            Assert.AreEqual(segmentTree.get_max(2, 2), 0);
            Assert.AreEqual(segmentTree.get_max(0, 1), 5);
        }
    }
}