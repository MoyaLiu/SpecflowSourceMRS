Feature: Notification-Dashboard
	The features in the Dashboard page

@TC_018_01
Scenario: Check if user is able to click on "Load more"
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	When Click on the Load More button
	Then The Show Less button should be displayed	

@TC_018_02
Scenario: Check if user is able to click on "Show Less"
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Click on the Load More button
	When Click on the Show Less button
	Then The Show Less button should be not displayed

@TC_019_01
Scenario: Check if user is able to Delete for single notification
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Tick a notification item
	When Click on the Delete Selection icon
	Then The notification item should be deleted

@TC_019_02
Scenario: Check if user is able to Delete for multiple notifications
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Tick more than one notification items
	When Click on the Delete Selection icon
	Then The notification items should be deleted

@TC_019_03
Scenario: Check if user is able to delete all notifications
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And  Click on Select All icon
	When Click on the Delete Selection icon
	Then All of the notification items should be deleted

@TC_020_02
Scenario: Check if user is able to mark a single notification as read
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Tick a notification item
	When Click on Mark Selection as Read
	Then The notification item should be marked as read

@TC_020_03
Scenario: Check if user is able to mark multiple notifications as read
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Click on Select all
	When Click on Mark Selection as Read
	Then All notifications selected should be marked as read

@TC_021_01
Scenario: Check if user is able to click on Select All
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	When Click on Select all
	Then All notifications should be selected

@TC_021_03
Scenario: Check if user is able to click on Unselect all when all notifications are selected
	Given the user has logged in
	And Click on the Notification button
	And Click on the See all button
	And Click on Select all
	When Click on Unselect all
	Then All notifications should be unselected
