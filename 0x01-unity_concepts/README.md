# Concepts

**Question #0**  
What is a GameObject?

❌ A 3D model.  
✔️ A container for Components.  
❌ Built-in game assets that come with Unity.  

**Question #1**  
A GameObject must not be empty.

❌ True.  
✔️ False.  

**Question #2**  
What Component is required for all GameObjects?

✔️ Transform.  
❌ Box Collider.  
❌ Size.  

**Question #3**  
How can you add your own code as a Component of a GameObject?

❌ Right-click on the GameObject in the Hierarchy window and choose “Add Script".  
✔️ Add a new Script Component to the GameObject in the Inspector window.  
✔️ Drag a script from the Project window to the GameObject’s Inspector window.  

**Question #4**  
What is a Prefab?

❌ A built-in game asset that comes with Unity.  
✔️ A template created from an existing GameObject and its components and properties.  
❌ A Component of a GameObject.  

**Question #5**  
What are the benefits of using Prefabs?

✔️ Prefabs can be used to make copies easily of a GameObject and make changes to all of them efficiently.  
✔️ Prefabs can be used in multiple scenes.  
❌ Prefabs don't need Components to edit their properties.  

**Question #6**  
How could you use Tags in a Unity project?

✔️ To sort GameObjects in the Project window.  
❌ To organize Components in a GameObject.  
✔️ To identify and organize GameObjects for scripting purposes.  

**Question #7**  
A GameObject can have multiple Tags assigned to it.

❌ True.  
✔️ False.  

**Question #8**  
What is the purpose of Layers?

✔️ To render only part of a scene.  
✔️ To restrict raycasting to only specific parts of a scene.  
❌ To keep track of scene drafts.  

**Question #9**  
What is gameplay?

❌ The game controller / keyboard controls used in interacting with a game.  
✔️ How a player interacts with a game.  
❌ A rule designed for a player's interaction with the game.  

**Question #10**  
What are game mechanics?

❌ The inner workings of a game's engine.  
❌ How a player interacts with a game.  
✔️ A set of rules designed for the player's interaction with the game.  


## Tasks

**0. Floor plans**  
Create a new Cube GameObject named Floor with the following Transform properties:

- **Position:** X: 0, Y: 0, Z: 0  
- **Rotation:** X: 0, Y: 0, Z: 0  
- **Scale:** X: 16, Y: 0.5, Z: 16  
  
**1. On the ball**  
Duplicate 0-floor and Create a new Sphere GameObject named Ball with the following Transform properties:

- **Position:** X: 0, Y: 8, Z: 0  
- **Rotation:** X: 0, Y: 0, Z: 0  
- **Scale:** X: 1.5, Y: 1.5, Z: 1.5  
  
**2. Colors!**  
Create a Materials folder, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject.

Create a second new material named ball. Change the material color and assign the new material to the Ball GameObject.
  
**3. Gravity is a harsh mistress**  
Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?

Create a new folder named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play. For this task, your final bounce material settings should be:

- **Bounciness:** 0.8  
- **Bounce Combine:** Maximum  
  
**4. Prefabricated**  
Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.
  
**5. Even more colors!**  
Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task.

- **ball-red :** FF0000FF  
- **ball-blue :** 0000FFFF  
- **ball-green :** 00FF00FF  
- **ball-white :** FFFFFFFF  
- **ball-black :** 000000FF  

Take a look at the Hierarchy window. Having a bunch of GameObjects with the same name is hard to navigate, right? It’s important to clearly name your GameObjects and assets, especially when working with others in the same project. Rename each Ball GameObject in your scene with their color name.

- Red Ball  
- Blue Ball  
- Green Ball  
- White Ball  
- Black Ball  
  
**6. Tag yourself**  
Add a tag to all Ball objects called Obstacles.
  
**7. Textures**  
Create a new instance of Ball named Textured Ball and add a texture to it. Your texture asset should be in a folder named Textures and your new material should be called ball-texture.

**Free Texture Sources**:  
[textures.com](https://www.textures.com/library "textures.com")  
[texturex.com](https://www.texturex.com/ "texturex.com")  
[Unity Asset Store](https://assetstore.unity.com/?orderBy=1 "Unity Asset Store")  
