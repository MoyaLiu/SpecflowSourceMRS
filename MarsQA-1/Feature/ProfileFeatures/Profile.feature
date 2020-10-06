Feature: Profile
	

@TC003
Scenario: Update my fluidcard details
	Given the User has log-In
	When the User edits the fluidcard details
	Then the User is able to see the changes in the fluid card
