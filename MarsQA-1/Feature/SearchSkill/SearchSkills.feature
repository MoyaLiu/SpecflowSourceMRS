Feature: SearchSkills
	
@TC015-02
Scenario: Search Skill by Input text

	Given the User is at Login Page
	When User Input text in search skill Textbox
	Then User is able to see Result


@TC015-05
Scenario: Search Skill Sub-Categories

	Given the User is at Login Page
	When I Click on Search icon
	And Select Category then Sub-Categories
	Then I should see all record of sub-categories


@TC015-07
Scenario: Search Skill by UserName

	Given the User is at Login Page
	When I Click on Search icon
	And I Enter Username 
	Then I should see all skill of that user


@TC016-02
Scenario: Search skill : Filter by Online

	Given the User is at Login Page
	When I Click on Search icon
	And I click on Online button
	Then I should see all online skills


@TC016-03
Scenario: Search skill : Filter by Onsite

	Given the User is at Login Page
	When I Click on Search icon
	And I click on Onsite button
	Then I should see all onsite skills


@TC016-07
Scenario: Search skill : validate On last page

	Given the User is at Login Page
	When I Click on Search icon
	And I click on Show All button
	Then I should see all skills
