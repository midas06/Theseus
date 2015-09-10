20th Aug:

Fixed: 
	- updated structs to Point (which is also a struct? dunno at this point)
	- fixed constructor & inheritance for Thing & subclasses
	- built map 1
	- isBlocked()

To do:
	- get shit moving


21st Aug:

Fixed:
	- Theseus moves all directions
	Implemented an inverse relationship btw each Thing & the Game, so each Character
	knows about the tile it is on.

	- Coded minotaur movement

	- Implemented U/D/L/R movement, map 1 fully works
	(although button input sucks)


To do:
	- MVC
	- Model the map, get stuff moving forreals


28th Aug:

Fixed: 
	- button input

Broke:
	- a lot of stuff.

8th Sep:

Fixed:
	- a lot of stuff that I broke

Implemented:
	- changed the way IsBlocked worked
	- changed the way movement is calculated
	- implemented struct for direction of movement
	
	NB: this fixed the inherent problems T & M had with movement, & M 'stealing' a turn when T was blocked and didn't move.


	- ASCII map implemented, partly stolen from Mesa, thanks

9th Sep:

Implemented:
	- fixed visibility of classes
	- MVC (kind of - still relying on console.writeline for some stuff)
	- restart & change levels
	- working levels up to level 5