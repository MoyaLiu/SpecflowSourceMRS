Feature: Profile-Education

@TC006-02
Scenario: Add Education
	Given the User has log-In
	When the user fills the New Education details
	Then the User should see the new Education in his profile

@TC006-04
Scenario: Edit Education
	Given the User has log-In
	When the user fills the Edit Education details
	Then the User should see the edited Education in his profile

@TC006-06
Scenario: Erase Education
	Given the User has log-In
	When the user deletes the Education
	Then the User should not see the Education in his profile