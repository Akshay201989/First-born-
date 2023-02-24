Feature: TMFeature

As a Turnup portal user
i would like to create edit time and materiral records
so that i can manage employees time and material sucessfully

Scenario: Create time and material record with valid details 
	Given I logged into turn up portal successfully
	When I navigate to time and material page
	And I create a new time and material record 
	Then The record should be created successfully
