﻿Feature: SpecFlowFeature1
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