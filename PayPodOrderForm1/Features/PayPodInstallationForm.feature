Feature: PayPodInstallationForm
	In order for Pay Pod to able to install their car charger in my house i need to register my interest

@mytag
Scenario: Pay Pod Installation
	Given I Navigate to the website "https://checkout.pod-point.com"
	And Click on select make
	And User select Model
	And I Click on New Button
	When User select Universal Charger
	And Click on 22KW
	And I select Extended warranty
	And I click on Next Button
	And Enter my first Name "OLU"
	And I Enter Last Name "MAT"
	And Enter Phone Number "07509737585"
	And User Enter Email "Depraiser@yahoo.com"
	And Click on don't contact me by Phone
	And Don't contact me by Email
	And User click I'd prefer not to receive updates
	When I click on Submit button
	#Then I should be able to Submit my details for installation