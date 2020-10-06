Feature: Profile-Certificates

@TC007-02
Scenario: Add Certificate
	Given the User has log-In
	When the user fills the New Certificate details
	Then the User should see the new Certificate in his profile

@TC007-04
Scenario: Edit Certificate
	Given the User has log-In
	When the user fills the Edit Certificate details
	Then the User should see the edited Certificate in his profile

@TC007-06
Scenario: Erase Certificate
	Given the User has log-In
	When the user deletes the Certificate
	Then the User should not see the Certificate in his profile