Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: mpg - easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8

Scenario: MPG-EASY
	Given Miles driven is 85
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8.5


Scenario: Gas Hog
	Given gallons used more than 10 
	Given miles driven is less than 100 
	When gasUse is called
	Then they should be gas hogs true

Scenario: Gallons 
	Given Miles driven is 100
	And mpg is 10
	When calc_gallons is called
	Then the gas used should be 10

Scenario: Miles
	Given Gallons used is 5
	And mpg is 30
	When calc_miles is called
	Then the miles traveled should be 150

Scenario: payment validation
	Given Gallons used is 5
	And Gallon price is 2
	And card amount is 20
	When calc_pay is called
	Then the validation for payment should be true

Scenario: Fuel up
	Given Gallons used is 25
	And Tank is 5
	When calc_fuelUse
	Then the times stoped should be 5

