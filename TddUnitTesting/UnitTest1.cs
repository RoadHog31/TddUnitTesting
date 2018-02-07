using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestClassLibrary; 
namespace TddUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNumberTest()
        {
            double ActualOutput;
            Class1 NewInstance = new Class1();

            ActualOutput = NewInstance.AddNumbers(3.68, 6.88);
            Assert.IsTrue(ActualOutput <= 10); 
        }

        [TestMethod]
        public void StringTest()
        {
            string sActualOutput;
            string sName = "Bob";
            string sExpected = "Hello, Welcome " + sName + "!";

            Class1 NewInstance = new Class1();
            sActualOutput = NewInstance.Greeting(sName);

            Assert.IsTrue(sActualOutput.StartsWith("Hello, Welcome"));
            Assert.IsTrue(sActualOutput.Contains(sName));
            Assert.IsTrue(sActualOutput.EndsWith("!"));
            Assert.AreEqual(sExpected, sActualOutput); 

            
        }

        [TestMethod]
        public void HolidayTest()
        {
            {
                bool ActualOutput;
                //DateTime inputDate;
                
               // string sExpected = "01-Jan-2014";                 
             
                Class1 NewInstance = new Class1();
                ActualOutput = NewInstance.checkBankHoliday(inputDate);
                // New Years Day
                if (inputDate == Convert.ToDateTime("01-Jan-2014"))
                {
                    ActualOutput = true; 
                }
               
               /* Assert.IsTrue(ActualOutput.StartsWith("01"));
                Assert.IsTrue(ActualOutput.Contains("01"));
                Assert.IsTrue(ActualOutput.EndsWith("2014"));
                Assert.AreEqual(Convert.ToDateTime(sExpected), Convert.ToDateTime(ActualOutput));*/ 
            }




        }



        public DateTime inputDate { get; set; }
    }
}
