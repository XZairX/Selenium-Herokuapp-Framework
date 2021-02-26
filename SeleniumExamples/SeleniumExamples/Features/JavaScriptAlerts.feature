﻿Feature: JavaScriptAlerts Page
	As a user,
	I want to be to handle information from within JavaScript alerts,
	so that I interact with JavaScript alerts on the website.

Background:
	Given the user is on the JavaScriptAlerts page

@javascript-alert
Scenario: Interacting with a basic JavaScript alert
	When the user clicks the JSAlert button
    And the user clicks the OK button
	Then the page should display the result text "You successfully clicked an alert" for the interaction

@javascript-confirm
Scenario: Interacting with JavaScript confirm alert using the cancel button
    When the user clicks the JSConfirm button
    And the user clicks the cancel button
    Then the page should display the result text "You clicked: Cancel" for the interaction

@javascript-confirm
Scenario: Interacting with JavaScript confirm alert using the OK button
    When the user clicks the JSConfirm button
    And the user clicks the OK button
    Then the page should display the result text "You clicked: Ok" for the interaction