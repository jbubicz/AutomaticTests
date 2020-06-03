Feature: Registration
	In order to use giftrete.com
	I need to register


Scenario: Registration
	Given I navigate to the website
	And I click on the Register button
	When I enter the First name
	And I enter the Last name
	And I enter the password 
	And I enter the confirm password 
	And I click the Sign Up button
	Then I should be logged in
