# NoKeepersPassTransition
A mod for The Long Dark

A simple demonstration mod made for Silkroad123 to disable the transition from PV to Keeper's Pass. This is NOT a mod that I intend to maintain.  

## Requirements: 
[MelonLoader](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe) 

## Installation:
1. Download ```NoKeepersPassTransition.dll``` from [releases](https://github.com/GruffCassquatch/NoKeepersPassTransition/releases) 
2. Drop ```NoKeepersPassTransition.dll``` into your Mods folder

## Uninstallation:
Delete ```NoKeepersPassTransition.dll``` from your Mods folder

## Basic tutorial on making e a mod that disables/enables game objects like this:
1. Install [Unity Explorer](https://github.com/sinai-dev/UnityExplorer). This is not complicated, it is just like a mod.
2. OPTIONAL, but recommended: install [Developer Console](https://github.com/FINDarkside/TLD-Developer-Console).
3. Lanch the game, press F7 to close Unity Exploerer when it pops up. Go to the specific scene the item is in. You can do this quickly using mods, such as [Developer Console](https://github.com/FINDarkside/TLD-Developer-Console) or my [ChooseStartingLocation](https://github.com/GruffCassquatch/ChooseStartingLocation) mod.
4. OPTIONAL, but recommended: make a save where you can see the object you want to disable/enable (or nearby if it's invisible like the transition zone in this mod), I use Developer Console (press F1 to bring up the console, type save, hit enter, F1 to close console)
5. Pause the game. Press F7 to open Unity Explorer, you may want to move the windows around to see them all properly. In the Object Explorer window, there's a search field under "Scene", near the top of the window. Use this to search for whatever you're looking for. For this mod, I searched "transition", then looked at the list and selected CanyonRoad. You may need to experiment to find the right object. You can enable/disable objects in Unity Explorer by clicking the little box next to the name, this can help you find the right object.
6. Once you find what you're looking for, click on it to open the Inspector window. This has lots of details about the object. You can use the information you find here to do all sorts of things, like see how to move the object, change properties, add items to containers etc. For this tutorial, we are just going to disable the object.
7. To disable a specific object like a transition, you need to be able to target it. Near the top of the Inspector window, there is a button View Parent; next to this is the object path. For the Keeper's Pass transition, it says: Design/Transitions/
8. Copy this path and the name of the object (Design/Transitions/CanyonRoad). You will use this in your mod to target the object. 
9. Use this mod (you can download the whole source code and open in Visual Studio, or just read the code here) as a guide for how to make the actual mod. In short, the mod should (a) find the specific game object (note that you can easily make a mod that targets many game objects, or a category of game objects) and then (b) disable/enable/modify it under whatever conditions you like.

## Some other mods that might be helpful to reference:
[Shelter Temperature Tweaks](https://github.com/GruffCassquatch/ShelterTemperatureTweaks), in this mod I target and modify temperature triggers.
[ContainerTweaks](https://github.com/GruffCassquatch/ContainerTweaks), in this mod I mass target various container types and modify them.
[Reroll Burnt Buildings](https://github.com/GruffCassquatch/RerollBurntBuildings), in this mod I target random objects (burnt buildings and fishing huts with randomised doors) and implement console commands to "re-roll" them in-game (this is really just enabling/disabling the various object sets).

## Feedback, Questions & Troubleshooting
* I am active on [The Long Dark Modding](https://discord.gg/QvFE7VV4WZ) Discord server
	* **General questions and feedback:** post in my channel #cass
	* **Troubleshooting:** 
		* Post in my channel #cass or in #troubleshooting 
		* Or create an issue here on GitHub if you're not on Discord
