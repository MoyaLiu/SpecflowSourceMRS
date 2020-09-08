Feature: Profile
	

@mytag
Scenario: As a Seller I want to add my profile Details
	Given the User is in the Profile page
	And the User has log-In
	When the User fills the profile details
	Then the User is able to see the profile details in the profile page