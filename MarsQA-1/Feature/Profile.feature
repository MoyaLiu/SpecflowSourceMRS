Feature: Profile
	

@Add Function
Scenario: As a Seller I want to add my profile Details
	Given the User has log-In
	And the User is in the Profile page
	When the User fills the profile details
	Then the User is able to see the profile details in the profile page

@Edit Function
Scenario: As a Seller I want to edit my profile Details
	Given the User has log-In
	And the User is in the Profile page
	When the User edits the profile details
	Then the User is able to see the changed details in the profile page

@Delete Function
Scenario: As a Seller I want to erase my profile Details
	Given the User has log-In
	And the User is in the Profile page
	When the User deletes the profile details
	Then the User is not able to see the profile details in the profile page