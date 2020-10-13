Feature: Profile
	

@TC003
Scenario: Update my fluidcard details
	Given the User has log-In
	When the User edits the fluidcard details
	Then the User is able to see the changes in the fluid card

@TC008-02
Scenario: Edit my profile Description
	Given the User has log-In
	When the User clicks the edit icon in the Profile description
	And the User fills the Profile description
	Then the User is able to see the description in the profile page

@TC009-06
Scenario: Change password with invalid password
	Given the User has log-In
	When the User clicks the change password option in the Profile menu
	And the User fills the change password form with invalid password
	Then the User is able to see an alert in the change password page

@TC009-07
Scenario: Change password with valid password
	Given the User has log-In
	When the User clicks the change password option in the Profile menu
	And the User fills the change password form with valid password
	Then the User is able to log with the new data
