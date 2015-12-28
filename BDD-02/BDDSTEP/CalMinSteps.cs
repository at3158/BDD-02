using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDD_02.BDDSTEP
{
    [Binding]
    public class CalMinSteps
    {
        [Given(@"I  entere (.*) into the calculator")]
        public void GivenIEntereIntoTheCalculator(int firstNumber)
        {
            ScenarioContext.Current.Set<int>(firstNumber, "firstNumber");
        }
        
        [Given(@"I  entered (.*) into the calculator")]
        public void GivenIEnteredIntoTheCalculator(int secondNumber)
        {
            ScenarioContext.Current.Set<int>(secondNumber, "secondNumber");
        }
        
        [When(@"I press min")]
        public void WhenIPressMin()
        {
            var firstNumber = ScenarioContext.Current.Get<int>("firstNumber");
            var secondNumber = ScenarioContext.Current.Get<int>("secondNumber");
            //new BDD_02.WEBDATA.Calculation
            var actual = new BDD_02.WEBDATA.Calculation().Min(firstNumber, secondNumber);
            ScenarioContext.Current.Set<int>(actual, "actual");
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            var actual = ScenarioContext.Current.Get<int>("actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
