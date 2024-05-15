# Dreadhalls Game
<!-- ## Video Demo:  [Watch Demo](https://youtu.be/4XLXpPgF0PQ?si=JpGuBXB7r9Y8M1Wu) -->

This is an implementation of Dreadhalls game. The game is part of CS50 Game Development and I have added the specified features in the Problem Set.

## Table of Contents

- [Spawn Holes in the Floor](#spawn-holes-in-the-floor)
- [Game Over Transition](#game-over-transition)
- [Maze Progress Tracking](#maze-progress-tracking)

## Features Added:

### Spawn Holes in the Floor
- Implemented functionality to randomly spawn holes in the floor of the maze.
- Limited the number of holes spawned per maze to ensure gameplay balance.
- Utilized the LevelGenerator script to determine where holes should be instantiated.
- Ensured that the number of holes spawned is appropriate for the maze size.

### Game Over Transition
- Implemented a "Game Over" screen as a separate scene.
- Transitioned to the "Game Over" screen when the player falls through any holes.
- Allowed the player to return to the title screen by pressing "Enter" in the "Game Over" scene.
- Created a MonoBehaviour script (e.g., DespawnOnHeight) to handle checking for a game over condition based on player position.
- Managed audio source objects (e.g., WhisperSource) to prevent overlapping music between scenes.

### Maze Progress Tracking
- Added a Text label to the Play scene to track the current maze number.
- Incremented the maze number each time the player progresses to the next maze.
- Reset the maze number to 0 if the player gets a Game Over.
- Implemented maze progress tracking using static variables to persist between scene reloads.

These features enhance the gameplay experience of Dreadhalls by introducing dynamic elements such as randomly generated hazards, seamless transitions between scenes, and a tracking system for player progression.
