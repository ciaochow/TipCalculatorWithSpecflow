using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TipCalculator
{
    [Binding]
    public class TipCalculatorSteps
    {
        private Calculator calculator = new Calculator();

        [Given(@"I have a bill of (.*)")]
        public void GivenIHaveABillOf(decimal number)
        {
            calculator.FirstNumber = number;
        }
        
        [Given(@"I want to leave a (.*)% tip")]
        public void GivenIWantToLeaveATip(int tippercentage)
        {
            calculator.TipPercent = tippercentage;
        }
        
        [When(@"I calculate my tip")]
        public void WhenICalculateMyTip()
        {
            calculator.CalculateTip();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal expectedresult)
        {
            Assert.AreEqual(expectedresult, calculator.Result);
        }
    }
}
