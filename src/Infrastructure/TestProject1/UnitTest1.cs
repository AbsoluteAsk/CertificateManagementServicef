using NUnit.Framework;
using Odyssey.DiagnosticCertificateService.Application.Queries.Unit_test.test;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    public class Tests
    {
        private NunitTestClass _testClass { get; set; } = null!;
       
        [SetUp]
        public void Setup()
        {
            _testClass = new NunitTestClass();
           
          
        }

        [TestCase(91)]
        [TestCase(81)]
        [TestCase(93)]
        [TestCase(9)]
        public void getGradeTest(int percent)
        {
            //assign
           // var percent = 90;
            var grade = _testClass.getGrade(percent);

            Assert.AreEqual("A", grade);
            
        }
    }
}