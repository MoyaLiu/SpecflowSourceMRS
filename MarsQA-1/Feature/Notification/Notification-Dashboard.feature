Feature: Notification-Dashboard
	The features in the Dashboard page

@TC_018_01
Scenario: Check if user is able to click on "Load more"
	Given the User has log-In
	And Click on the Notification button
	And Click on the See all button
	When Click on the Load More button
	Then The Show Less button should be displayed	

@TC_018_02
Scenario: Check if user is able to click on "Show Less"
	Given the User has log-In
	And Click on the Notification button
	And Click on the See all button
	And Click on the Load More button
	When Click on the Show Less button
	Then The Show Less button should be not displayed

@TC_019_01
Scenario: Check if user is able to Delete for single notification
	Given the User has log-In
	And Click on the Notification button
	And Click on the See all button
	And Tick a notification item
	When Click on the Delete Selection icon
	Then The notification item should be deleted

@TC_019_02
Scenario: Check if user is able to Delete for multiple notifications
	Given the User has log-In
	And Click on the Notification button
	And Click on the See all button
	And Tick more than one notification items
	When Click on the Delete Selection icon
	Then The notification items should be deleted

@TC_019_03
Scenario: Check if user is able to delete all notifications
	Given the User has log-In
	And Click on the Notification button
	And Click on the See all button
	And  Click on Select All icon
	When Click on the Delete Selection icon
	Then All of the notification items should be deleted