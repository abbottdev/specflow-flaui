using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CalculatorAutomationTests.Steps
{
	[Binding]
	public class CalculatorSteps
	{
		private CalculatorApp calculator;

		[Given(@"I have entered (.*) into the calculator")]
		public void GivenIHaveEnteredIntoTheCalculator(int number)
		{
			switch (number)
			{
				case 1:
					this.calculator.PressNumberOne();
					break;
				default:
					break;
			}
		}

		[Given(@"I have also entered (.*) into the calculator")]
		public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
		{
			switch (number)
			{
				case 1:
					this.calculator.PressNumberOne();
					break;
				default:
					break;
			}
		}

		[When(@"I have launched the calculator")]
		public void WhenIHaveLaunchedTheCalculator()
		{
			this.calculator = new CalculatorApp();
			this.calculator.LaunchAndWaitForInputIdle();
		}

		[When(@"I press Equals")]
		public void WhenIPressEquals()
		{
			this.calculator.PressEquals();
		}

		[Then(@"the result should be (.*) on screen")]
		public void ThenTheResultShouldBeOnScreen(int number)
		{
			Assert.IsTrue(this.calculator.ReadCurrentResult() == number);
		}

		[Given(@"I have pressed Add")]
		public void GivenIHavePressedAdd()
		{
			this.calculator.PressAdd();
		}

	}
}
