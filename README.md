# Initialization System

* Unity Initialization Codes
* Unity minimum version: **2022.3**
* Current version: **1.0.0**
* License: **MIT**

## Summary

Initialization Codes for Unity Projects

## Dependency Instantiater

Instantiates the a "Dependencies" Prefab (via Addressables or Resources) into the *DontDestroyOnLoad Scene* when the game enters in Play mode. This make sure to always have an specific prefab instance no matter what scene you play.

>**Note 1**: it's important to name the Prefab as `Dependencies` and set it as an addressable using the same name. 

>**Note 2**: if you are not using the Addressables package, place the prefab into a Resources folder.

### User Session Generator

Generates and logs a Unique User Session number just when the game initializes. Only works in a Builds, not in Editor.
It helps to tack bugs using user ids.

Both Dependency Instantiater and User Session Generator generate logs only in Builds.

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-Initialization System** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/InitializationSystem.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.initialization-system":"https://github.com/HyagoOliveira/InitializationSystem.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>