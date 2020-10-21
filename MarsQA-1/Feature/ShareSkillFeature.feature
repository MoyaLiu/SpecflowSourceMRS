Feature: ShareSkillFeature

@TC-010-02
Scenario: Add Share Skill
	Given the User has log-In
	When the User clicks on the ShareSkill button
	And the user fills the ShareSkill form
	Then the User should be able to see the skill on the Manage Listing page

@TC-011-04
Scenario: Edit Shared Skill on Manage Listing Page
	Given the User has log-In
	And the User navigates to the Manage Listing Page
	When the User clicks the Edit button of a Shared Skill
	Then the User should be able to see the edited Skill on the Manage Listing page

@TC-012-01
Scenario: Erase Shared Skill on Manage Listing Page
	Given the User has log-In
	And the User navigates to the Manage Listing Page
	When the User clicks the Delete button of a Shared Skill
	Then the User shouldn't be able to see the deleted Skill on the Manage Listing page