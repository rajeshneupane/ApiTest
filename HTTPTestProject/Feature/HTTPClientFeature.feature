Feature: HTTPClientFeature
	In order to get a valid response
	As a user
	I want to do a restful get api call

@smoke
Scenario: API request gives valid response
	Given I set the base url "https://postman-echo.com/"
	When I call the endpoint "get?test=123" with get method
	Then I get the endpoint url "https://postman-echo.com/get?test=123" in the response
		And I get the response status code as 200
