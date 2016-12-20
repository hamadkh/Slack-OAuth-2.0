# Slack-OAuth-2.0
C#/WPF Demo for Slack-OAuth-2.0

Create a slack application 

Add clientid and secret to SlackControl/SlackControl/Configuration/Config.cs

Uses client scope. Other scopes are available at :

https://api.slack.com/docs/oauth-scopes

Make sure to point your application to Redirect URI in the settings.

Test application included 

#Using OAuth 2.0

OAuth 2.0 is a protocol that lets your app request authorization 

to private details in a user's Slack account without getting their password.

You'll need to register your app before getting started. 

A registered app is assigned a unique Client ID and Client Secret which will be used in the OAuth flow. 

The Client Secret should not be shared.

For more Information visit
https://api.slack.com/docs/oauth

#SlackConnector

Also checkout Slackconnector Library included in this project Github or Nuget Packages. 

Github
https://github.com/noobot/SlackConnector

Nuget
https://www.nuget.org/packages/SlackConnector
