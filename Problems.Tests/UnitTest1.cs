using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program j= new Program();
            string output1= j.Prefix("Where are you????");
            Assert.AreEqual("17,3:Where are you????",output1);
        }
         [Test]
        public void Test2()
        {
            Program p= new Program();
            string output2= p.Prefix(null);
            Assert.AreEqual(null,output2);
        }
         [Test]
        public void Test3()
        {
            Program b= new Program();
            string output3= b.Prefix("");
            Assert.AreEqual("0,0",output3);
        }
          [Test]
        public void Test4()
        {
            Program i= new Program();
            string output4= i.Prefix("Hi");
            Assert.AreEqual("2,1:Hi", output4);
        }

       
    }
}