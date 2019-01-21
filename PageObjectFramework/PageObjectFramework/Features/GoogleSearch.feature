Feature: Google Search
	As an internet user
	I want to be able to easily find information
	So I can learn more about the world


Scenario Outline: Text Search
	Given The user visits google
	When The user searches for <term>
	Then They see at least one <term> in the results

Examples: 
| term     |
| crawling |
| walking  |
| running  |