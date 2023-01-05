# TagDeath
TagDeath is a mod showcasing one of [BananaHook](https://github.com/Graicc/BananaHook)'s several events, being OnLocalPlayerTag. This event is fired whenever any tagging is done based around our player.  

## How does it work?
``BananaHook.Events.OnLocalPlayerTag += OnLocalTag`` is what causes the method to be called from the event. From there it checks the arguments to see if the player who got tagged is our player, and if it is our game crashes.  

## Disclaimer
This product is not affiliated with Gorilla Tag or Another Axiom LLC and is not endorsed or otherwise sponsored by Another Axiom LLC. Portions of the materials contained herein are property of Another Axiom LLC. © 2021 Another Axiom LLC.
