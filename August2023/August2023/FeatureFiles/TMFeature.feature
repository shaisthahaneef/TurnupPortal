Feature: TMFeature

As a Turnup portal admin
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

@regression
Scenario: Create time record with valid details
	Given I logged into Turnup portal successfully
	And I navigate to Time and material page
	When I create a new time record
	Then the record should be created successfully
