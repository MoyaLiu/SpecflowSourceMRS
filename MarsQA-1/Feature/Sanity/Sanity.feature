Feature: Sanity

@TC-024-01
Scenario: Validate Happy Path as a Learner
	Given the User find an interesting skill
	When the User request to trade the skill
	And the User clicks on the sent request menu option
	Then the User should see the "Pending" status on the sent request status

@TC-024-02
Scenario: Validate Happy Path as a Seller
	Given the User creates a new Skill to trade
	And the Skill has been requested by a Learner
	When the User checks the notification
	And the User accepts the skill trade
	Then the User should see the "Accepted" status on the request status