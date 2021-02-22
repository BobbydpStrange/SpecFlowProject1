Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: MPG-easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the result should be 8

Scenario: MPG-easy
	Given Miles driven is 85
	And Gallons used is 10
	When calc_mpg is called
	Then the result should be 8.5