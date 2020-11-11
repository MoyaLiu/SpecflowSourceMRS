Feature: Chat
	Validate Chat and Chat History

@TC_022_01
Scenario: Check if user is able to click on Chat
	Given The user has logged in
	When Clicks on Chat button
	Then User should be able to see Chat Dashboard

@TC_022_02
Scenario: Check if user is able send message to other user
	Given The user has logged in
	And Clicks on Chat button
	And Types in a message
	When Clicks on send button
	Then User should be able to see the message sent in the chat room

@TC_022_04
Scenario: Check if user is able to see number of new messages
	Given The user has logged in
	Then User should be able to see the number of new messages
	

@TC_023_01
Scenario: Check if user is able to click on other username
	Given The user has logged in
	When Clicks on Chat button
	Then User should be able to see other users
