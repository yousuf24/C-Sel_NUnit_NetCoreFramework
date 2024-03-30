Feature: Login

Demo for Application under Test

@shakeout
Scenario: login to demo webApplication
	Given User Login to application
	| UserName | Password |
	| admin    | password |
	When user click on login
	Then user should be able to view homePage and logOff button

@smoke
Scenario: Login to demo2
Given User login to demo2
When user submit id nad password
Then user should login successfully