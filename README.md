# Multiple environments on WinForms Application & ClickOnce publish

Sample app to build and publish a WinForms Application (but the same principle could be apply to Console/WPF...) with different settings based on Configuration.

This is just a workaround since seems impossible to have the same application installed with different application settings based on the DOTNET_ENVIRONMENT value since this is unique on a machine.

The tricks are the follows:
- Create as many Build Configuration as your needed environments
	- In this example we have: debug, test, prod, release
- Create `appsettings.xyz.json` configuration
	- xyz is the name of one environment
- Modify the .csproj to include/exclude the json configuration files as needed
	- Look at the `<Choice>` section
- The `*.pubxml` files are needed for the different settings on ClickOnce
	- A different ProductName property must be used for every environments
	- A different certificate must be used for every environments