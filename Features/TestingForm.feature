@blueskyform
Feature: TestingForm
test 

@regression
Scenario: Valid Form Submission
	Given I navigate to the Blue Sky Testing Form
	When I ener the Single Line Text
	And I select One in the Select box
	And I enter Email
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom at Country
	And I select 12th of the current month
	And I click on the Submit button
	Then the message "Your form has been successfully submitted."