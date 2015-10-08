Feature: TipCalculator
	
@mytag
Scenario Outline: Calculate tip
	Given I have a bill of <bill_total>
	And I want to leave a <tip_percent> tip
	When I calculate my tip
	Then the result should be <tip_result>

Examples: 
		| bill_total | tip_percent | tip_result |
		| 20         | 10%          | 2.00       |
		| 20         | 25%          | 5.00       |
		| 20         | 5%           | 1.00       |
			

Scenario: Calculate tip - hard coded
	Given I have a bill of 20.00
	And I want to leave a 10% tip
	When I calculate my tip
	Then the result should be 2.00
