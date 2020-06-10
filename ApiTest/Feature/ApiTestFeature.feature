Feature: ApiTest
	In order to get a valid response
	As a user
	I want to do a restful post api call

@smoke
Scenario: API request gives valid response
	Given I set the base url "https://postman-echo.com/"
	When I call the endpoint "get?test=123" with get method
	Then I get the response in json format
