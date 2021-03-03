Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Varify Report Sent
	Given The report is sent
	And The report was recieved
	When checkVarification is called
	Then the result should be true