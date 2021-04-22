# ***Classes & Objects in Unity***
Applying learned concepts from Visual Studio Community Examples to the Unity Engine.

## ***Some General Rules:***
1. When we attach a script as a component to a game object in a Unity scene, we get an instance of the class: an object attached to a game object.
    - Distinction:
        - ***Game Objects*** → items in a Unity Scene.
        - ***Objects*** → instance of the class. In turn is attached to that game object.
            - if you select the "Main Camera" with an already attached script, look into the Inspector Window at the bottem to find "PrintMessage (Script)" which is the instance (object) created by the class (script)

2. As it turns out, when one uses Unity we tend not to use constructors to build instances of classes.
    - ***Scripts*** → Simply put: classes in Unity.
        - if you look inside the script, you will notice the script contains a class called `public class PrintMessage : MonoBehavior`
    