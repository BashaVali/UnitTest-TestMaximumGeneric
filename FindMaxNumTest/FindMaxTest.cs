using FindMaximumNumber;
namespace FindMaxNumTest
{
    public class FindMaxNumberTest
    {
        
            //FindMaximumNum maxNum = new FindMaximumNum();
            //[Test]
            //public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    int result = maxNum.FindMaxInteger(15, 5, 10);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    int result = maxNum.FindMaxInteger(5, 15, 10);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    int result = maxNum.FindMaxInteger(10, 5, 15);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    float result = maxNum.FindMaxFloat(5.7F, 5.5F, 5.4F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    float result = maxNum.FindMaxFloat(5.5F, 5.7F, 5.4F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    float result = maxNum.FindMaxFloat(5.5F, 5.4F, 5.7F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxFirstNumString_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    string result = maxNum.FindMaxString("Peache", "Apple", "Banana");
            //    Assert.AreEqual("Peache", result);
            //}
            //[Test]
            //public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    string result = maxNum.FindMaxString("Apple", "Peache", "Banana");
            //    Assert.AreEqual("Peache", result);
            //}
            //[Test]
            //public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    string result = maxNum.FindMaxString("Apple", "Banana", "Peache");
            //    Assert.AreEqual("Peache", result);
            //}
            //FindMaxGeneric generic = new FindMaxGeneric();
            //[Test]
            //public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    int result = generic.FindMax(15, 5, 10);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    int result = generic.FindMax(5, 15, 10);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    int result = generic.FindMax(10, 5, 15);
            //    Assert.AreEqual(15, result);
            //}
            //[Test]
            //public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    float result = generic.FindMax(5.7F, 5.5F, 5.4F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    float result = generic.FindMax(5.5F, 5.7F, 5.4F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    float result = generic.FindMax(5.5F, 5.4F, 5.7F);
            //    Assert.AreEqual(5.7F, result);
            //}
            //[Test]
            //public void GivenMaxFirstNumString_WhenAnalysed_ShouldReturnFirstMax()
            //{
            //    //AAA(Act,Arrange,Assert)
            //    string result = generic.FindMax("Peache", "Apple", "Banana");
            //    Assert.AreEqual("Peache", result);
            //}
            //[Test]
            //public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
            //{
            //    string result = generic.FindMax("Apple", "Peache", "Banana");
            //    Assert.AreEqual("Peache", result);
            //}
            //[Test]
            //public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
            //{
            //    string result = generic.FindMax("Apple", "Banana", "Peache");
            //    Assert.AreEqual("Peache", result);

           FindMaximumNum maxNum = new FindMaximumNum();
        FindMaxGeneric<int> generic1 = new FindMaxGeneric<int>();
        FindMaxGeneric<float> generic2 = new FindMaxGeneric<float>();
        FindMaxGeneric<string> generic3 = new FindMaxGeneric<string>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA(Act,Arrange,Assert)
            int result = generic1.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic1.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic1.FindMax(10, 5, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA(Act,Arrange,Assert)
            float result = generic2.FindMax(5.7F, 5.5F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = generic2.FindMax(5.5F, 5.7F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = generic2.FindMax(5.5F, 5.4F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxFirstNumString_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA(Act,Arrange,Assert)
            string result = generic3.FindMax("Peache", "Apple", "Banana");
            Assert.AreEqual("Peache", result);
        }
        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = generic3.FindMax("Apple", "Peache", "Banana");
            Assert.AreEqual("Peache", result);
        }
        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = generic3.FindMax("Apple", "Banana", "Peache");
            Assert.AreEqual("Peache", result);
        }
    }
}


