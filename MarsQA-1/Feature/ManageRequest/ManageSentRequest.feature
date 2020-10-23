Feature: ManageSentRequest

@TC-014-01
Scenario: Check sent request on Manage Request page
	Given the User has log-In
	When the User clicks on the sent request menu option
	Then the User should see the sent requests

@TC-014-05
Scenario: Check Complete button on Manage Sent Request page
	Given the User has log-In
	And the User sends a new request
	And the request has been Accepted
	When the User clicks on the sent request menu option
	And the User clicks on the Completed button
	Then the User should see the "Completed" status on the sent request status

@TC-014-08
Scenario: Check Withdraw button on Manage Request page
	Given the User has log-In
	And the User sends a new request
	When the User clicks on the sent request menu option
	And the User Withdraws the new request
	Then the User should see the "Withdrawn" status on the sent request status

