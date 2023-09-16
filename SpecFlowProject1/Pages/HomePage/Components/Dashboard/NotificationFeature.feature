Feature: NotificationFeature

A short summary of the feature

@tag1
Scenario: Notification to be deleted Successfully
	Given I logged on to Portal Successfully
	When User Clicks on Dashboard Componenet Button
	And User Clicks on delete (x) icon
	Then Notification is deleted succfully
