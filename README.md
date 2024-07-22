Overview
This Unity project is a game featuring a player and five enemies, all represented as capsules with attached guns.
The enemies use NavMeshAgent for AI to move randomly, while the player also moves randomly. 
If the player comes within a 15-unit radius of any enemy, the enemy starts shooting at the player using raycasting. 
When the player gets hit five times, a game over panel appears with a restart button. Clicking the restart button restarts the game. 
The game also includes a 360-degree camera that can rotate to show the player and enemies.

Features
Player and Enemies: The game includes a player and five enemy characters, all represented as capsules.
NavMeshAgent AI: The enemies use NavMeshAgent for AI, allowing them to move randomly within the game environment.
Random Player Movement: The player character moves randomly within the game environment.
Shooting Mechanism: Enemies shoot at the player using raycasting if the player comes within a 15-unit radius.
Health System: The player has a health system where getting hit five times by enemies triggers a game over.
Game Over Panel: A game over panel appears when the player's health reaches zero. The panel includes a restart button.
Restart Functionality: Clicking the restart button on the game over panel restarts the game.
360-Degree Camera: The game features a 360-degree camera that can rotate to show the player and enemies from different angles.
