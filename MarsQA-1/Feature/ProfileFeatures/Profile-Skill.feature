Feature: Profile-Skill

@TC005-02
Scenario: Add Skill
	Given the User has log-In
	When the user fills the New Skill details
	Then the User should see the new Skill in his profile

@TC005-04
Scenario: Edit Skill
	Given the User has log-In
	When the user fills the Edit Skill details
	Then the User should see the edited Skill in his profile

@TC005-06
Scenario: Erase Skill
	Given the User has log-In
	When the user deletes the Skill
	Then the User should not see the Skill in his profile