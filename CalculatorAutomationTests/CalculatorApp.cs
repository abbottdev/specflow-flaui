using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace CalculatorAutomationTests
{
	public class CalculatorApp : IDisposable
	{
		private Application app;
		private UIA3Automation automation;
		private Window window;

		public CalculatorApp()
		{ }

		public void LaunchAndWaitForInputIdle()
		{
			this.app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

			this.app.WaitWhileMainHandleIsMissing();

			this.automation = new UIA3Automation();
			this.window = app.GetMainWindow(automation);
		}

		public void Dispose()
		{

			if (this.app != null)
			{
				if (this.app.HasExited == false)
					this.app.Kill();

				this.app.Dispose();
			}

			if (automation != null)
				automation.Dispose();
		}

		public CalculatorApp PressAdd()
		{
			var button = window.FindFirstDescendant(cf => cf.ByAutomationId("plusButton"))?.AsButton();

			button.Click(true);

			return this;
		}

		public CalculatorApp PressNumberOne()
		{
			var button = window.FindFirstDescendant(cf => cf.ByAutomationId("num1Button"))?.AsButton();

			button.Click(true);

			return this;
		}

		public CalculatorApp PressEquals()
		{
			var button = window.FindFirstDescendant(cf => cf.ByAutomationId("equalButton"))?.AsButton();

			button.Click(true);

			return this;
		}

		public decimal ReadCurrentResult()
		{
			throw new NotImplementedException();
			//todo: get the UI element for the result textbox and return the value of it here...
		}
	}
}
