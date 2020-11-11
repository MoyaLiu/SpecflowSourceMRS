Feature: Notification-Menu
	The features of notification tab

@TC_017_01
Scenario: Check if user is able to click on "Notification"
	Given the User has logged In
	When Click on the Notification button
	Then The Notification should be displayed

@TC_017_02
Scenario: Check if user is able to click on "Notification"->"Mark all as read"
	Given the User has logged In
	And Click on the Notification button
	When Click on the Mark all as read button
	Then The numbers of notification should be cleared	

@TC_017_03
Scenario: Check if user is able to click on "Notification"->"See all"
	Given the User has logged In
	And Click on the Notification button
	When Click on the See all button
	Then The user should be able to navigate to the dashboard page
