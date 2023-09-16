Feature: Login
Testing different sets of valid and invalid credentials for Login

Scenario: Unsuccessful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in InValid Credentials
	Then Unsuccessful Login

@tag1
Scenario Outline: Test Case 1 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case '<CaseNumber>'
	Then User is logged in Successfully
	Examples: 
	| CaseNumber |
	| 0 |
	| 1 |
	| 2 |

