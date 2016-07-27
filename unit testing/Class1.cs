using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/*Group 1
 * Group No. 1Able Varghese
 * Jishnu Sundar
 * Vishavdeep Kaur
 * */
namespace unit_testing
{
    [TestFixture]
    public class Class1
    {

      //Test case that fails
        [Test]
       public  void compareTestCase()
        {
            int x = 10;
            int y = 10;
            Assert.AreEqual(x,y);
            Console.WriteLine("Passed test case");
        }

    // Test that fails
        [Test]
      public  void failingTestCase()
        
        {
            if(true)
             Assert.Fail("This is fail"); 
        }

    // If you are expecting an exception
        [Test, ExpectedException(typeof(NotSupportedException))]
        public void expectedExceptionTestCase()
        {
            throw new NotSupportedException();
            
        }

    // Ignoring an exception - a code block that is not fully implemented.
        [Test, Ignore]
        public void notImplementedExceptionTestCase()
        {
            throw new NotImplementedException();
            
        }
    }
}
