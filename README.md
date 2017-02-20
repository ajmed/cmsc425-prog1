# Alexander Medeiros
# UMD CMSC425: Programming Assignment 1, Part 2

## Implementation

* Use the arrow keys or "WASD" to tilt the board
* Collect 2 of the pick up items to unlock the winner's circle!
* Hit 'Q' to quit
* Hit 'R' to restart
* The board can tilt a maximum of 20°

## Additional implementation details

* The board will reset to it's original position if no tilts are applied
    * The board "resists" user inputs by applying an interpolater which is fast when the change in direction is large, but slow when the change in direction is constant.
	
## Known issues

* When moving to a corner and then tilting hard in the opposite direction, the ball will fall through the floor. I think the motion updates faster than the collision and the ball will sink before realizing it was collided with.
* When loading up Unity, make sure to give it time to load the wooden planks (texture for board). They were loading very slowly on start-up for me.

## External resources

* The board's wood texture is from the asset store item 'Worn Wooden Planks' by user 'EBUTLER3D'.