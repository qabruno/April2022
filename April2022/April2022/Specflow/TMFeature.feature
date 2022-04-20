Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete time and material records
So that I can manage employees' time and materials successfully


Scenario: create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	When I create a new time and material record
	Then the record should be created successfully

Scenario Outline: edit time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	When I update '<Description>' on an existing time and material record
	Then the record should have the updated '<Description>'

	Examples: 
	| Description  |
	| Time         |
	| Material     |
	| EditedRecord |

