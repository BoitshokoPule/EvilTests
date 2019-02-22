using NUnit.Framework;
using Problems;
using System.Collections;


namespace Tests
{
    [TestFixture]
    public class MyTests
    {
        [TestCaseSource(typeof(MyDataClass), "TestCases")]
        public string PrefixTest(string input)//My single test method
        {
            Program s = new Program();
            string result = s.Prefix(input);
            return result;
        }

    }

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
               
                yield return new TestCaseData("Where are you ????").Returns("18,4:Where are you????");
                yield return new TestCaseData(null).Returns(null);
                yield return new TestCaseData("").Returns("0,0");
                yield return new TestCaseData("Hi").Returns("2,1:Hi");
                yield return new TestCaseData("Why is the sun hot,those are the questions").Returns("42,8:Why is the sun hot,those are the questions");
                yield return new TestCaseData("Awe").Returns("3,1:Awe");
                yield return new TestCaseData("H I V").Returns("5,3:H I V");
            }
        }
    }
}
    

      

       
  