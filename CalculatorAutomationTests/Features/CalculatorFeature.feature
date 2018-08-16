Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@addingTag
Scenario: Add two numbers
	When I have launched the calculator
	Given I have entered 1 into the calculator
	And I have pressed Add
	And I have also entered 1 into the calculator
	When I press Equals
	Then the result should be 2 on screen