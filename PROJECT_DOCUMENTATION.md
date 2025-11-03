# Factory Game: Project Documentation

## Identifying and Defining
### Need:
To fulfill the need of entertainment through a game that has fun and repeatable gameplay that makes people come back to play every time.

### Problem Statement:
Many games focus too much on graphics and end up presenting subpar and predictable storyline.

### Skill Development
To gain the skill required to create this kind of game I will need to use the Unity game engine and learn how to use it through Mr Scott's Unity Course.

## Requirements Outline
### Inputs
Users will use WASD/arrows for movement, spacebar/W keys to jump and Q or E keys to dash

### Processing
The system processes the key presses by sending a message to the CPU, which then reads the message using the keyboard driver which the Unity Input System Package understands and does what the key was binded to. Then the character or scene will be updated accordingly.

### Outputs
The screen will update to show what changed, for example rendering movement or the tiles.

### Transmission
The game is not an online game and does not need internet to run.

### Storage
Automatically save the player levels completed to the game files

## Functional Requirements
### Input
The game should use the WASD input system for movement which the left hand naturally sits on as well as most people are used to using them already for gaming, it should also allow people to use the arrow keys to accomodate for people who have better right hand control. 

### Gameplay
The game will be styled like a parkour/heavily movement focused game, as to allow the gameplay to be repeatable. We can also keep the gameplay more rewarding to make people to continue playing by making a fluid/skillful movement system.

### Progression
The gameplay progression should teach the players on each mechanic while ramping up the difficulty progressively to keep it not boring or too easy. Further levels can be accessed in the menu screen after completing the previous levels, to ensure that the player does not make it too hard for themself.

### UI
User interface should allow someone to select and exit levels, and quit the game when they want. It should also inform users with hints on what to do to beat the level.

### Game Saves
Allows someone to save their levels completed, so that they don't lose progress when they quit and come back. The save should not be sent and saved online to a server but instead locally.

## Non-functional:

### Performance
The game should run at 60 fps for a smooth experience without crashing or having stutters. 

### Support
It should also support many popular operating systems except for Linux and Android/iOS.

### Scaleability
The game should be scaleable (for now) allowing the plot or gameplay to continue expanding without a ultimate final.

### Security
The game will never collect data to send on the network and it will not collect any data outside the game itself locally. While the game itself may be easier to hack into (Unity still tells me that version 6000.40f1 is unsecure because of a vulnerability and that I should update) it should be fine as the game is completely offline and nothing useful will be tied towards it (outside of the game saves).

## Social and Ethical Issues

### Definitions
Equity definition: The quality of being fair and just, especially in a way that takes account of and seeks to address existing inequalities.

Accessibility definition: The quality of being able to be reached or entered.


### Accessibility
The game should be accessible to most except those who don't know or can't use a keyboard and/or can't see the gameplay. Solution: Neuralink support possibly. The WASD layout is intended for people who are already used to the left hand keyboard experience but the arrow keys are stil available for people who have better right hand control, along with the spacebar to jump as an alternative to W/Up Arrow if you are already used to it like in many other games.

### Privacy and Data Protection
The game collects no data apart from game saves and will never send anything to any server. The game save specifically will be stored locally and while it may not be encrypted or secured in a way there is not much downside apart from losing the save by someone accessing your computer.

## Fairness and Representation
The characters have no actual story or confirmed features, except for the main character having no limbs, and that this is character never speaks and the design is intended to be not offensive at all, and that everything else in the game is like just obstacles so while there is not much diversity it doesn't contain any stereotypes about race or gender.

## Mental/Emotion Wellbeing
Excessive gaming can lead to addiction and social isolation, our game will be not THAT fun and addicting to that point, but rather rage inducing so that they don't play for too long (which may come with other issues)

## Cultural Awareness
No hateful religous or cultural references are in this game (should).