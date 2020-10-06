Feature: Profile-Language

@TC004-02
Scenario: Add Language
	Given the User has log-In
	When the user fills the New Language details
	Then the User should see the new Language in his profile

@TC004-04
Scenario: Edit Language
	Given the User has log-In
	When the user fills the Edit Language details
	Then the User should see the edited Language in his profile

@TC004-06
Scenario: Erase Language
	Given the User has log-In
	When the user deletes the Language
	Then the User should not see the Language in his profile