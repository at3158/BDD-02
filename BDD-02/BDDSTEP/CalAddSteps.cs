﻿using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDD_02.BDDSTEP
{
    [Binding]
    public class CalAddSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNumber)
        {
            ScenarioContext.Current.Set<int>(firstNumber, "firstNumber");
        }
        
        [Given(@"I had entered (.*) into the calculator")]
        public void GivenIHadEnteredIntoTheCalculator(int secondNumber)
        {
            ScenarioContext.Current.Set<int>(secondNumber, "secondNumber");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var firstNumber = ScenarioContext.Current.Get<int>("firstNumber");
            var secondNumber = ScenarioContext.Current.Get<int>("secondNumber");
            //new BDD_02.WEBDATA.Calculation
            var actual = new BDD_02.WEBDATA.Calculation().Add(firstNumber, secondNumber);
            ScenarioContext.Current.Set<int>(actual, "actual");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            var actual = ScenarioContext.Current.Get<int>("actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
