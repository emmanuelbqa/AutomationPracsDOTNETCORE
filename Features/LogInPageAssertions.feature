Feature: LogInPageAssertions
	As a user, I want to be prompted with the right error message when the right procedures are not followed


Scenario Outline:Log In Page Assertions - Failures
	Given I navigate to Automation Practice Homepage
	And I click on Sign In on the main menu
	When enter "<Email>" as email address
	And I enter "<Password>" as password
	And I click on Sign In button
	Then the error message reads "<Error message>"

Examples: 
		|Email					|Password |Error message				|
		|emanuel@testnative.com |Welcome02|Authentication failed.		|
		|emmanuel@testnative.com|		  |Password is required.		|
		|					    |Welcome01|An email address required.	|
		|					    |		  |An email address required.	|



