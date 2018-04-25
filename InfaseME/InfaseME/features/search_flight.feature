Feature: search_flight

Background: 
	Given open "https://www.cleartrip.com" url
	And I select "Round trip"
	When I select From "Cairo, EG - Cairo (CAI)" airpot
	And I select To "Dubai, AE - Dubai International Airport (DXB)" airpot
	Given I select 1 from "Adults" dropdown menu
	And I select 1 from "Children" dropdown menu
	And I select 1 from "Infants" dropdown menu
	And I choose Depart date "Sat, 1 Dec, 2018"
	And I choose Return date "Mon, 31 Dec, 2018"
	When I click on "Search flights" button
	And I wait 70 seconds
	
Scenario: Search Cheapest Flight
	When I book cheapes flight
	And I wait 60 seconds
	Then I should see "Book in four simple steps"

Scenario: Search Shortest Flights
	Given I order flights by "Depart"
	When I book cheapes flight
	And I wait 60 seconds
	Then I should see "Book in four simple steps"