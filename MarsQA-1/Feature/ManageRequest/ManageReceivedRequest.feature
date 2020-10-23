Feature: ManageReceivedRequest

@TC-013-02
Scenario: Check received request on Manage Request page
	Given the User has log-In
	When the User clicks on the received request menu option
	Then the User should see the received request

@TC-013-07
Scenario: Check Accept button on Manage Request page
	Given the User has received a new request
	And the User has log-In
	When the User clicks on the received request menu option
	And the User Accepts the new request
	Then the User should see the "Accepted" status on the request status

@TC-013-08
Scenario: Check Complete button on Manage Request page
	Given the User has received a new request
	And the User has log-In
	When the User clicks on the received request menu option
	And the User Accepts the new request
	And the User clicks on the Complete button
	Then the User should see the "Completed" status on the request status

@TC-013-09
Scenario: Check Decline request on Manage Request page
	Given the User has received a new request
	And the User has log-In
	When the User clicks on the received request menu option
	And the User Declines the new request
	Then the User should see the "Declined" status on the request status

