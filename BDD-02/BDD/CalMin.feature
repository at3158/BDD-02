Feature: CalMin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Min two numbers
	Given I  entere 70 into the calculator
	And I  entered 50 into the calculator
	When I press min
	Then the result should be 20 
