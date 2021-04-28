# ***Colliders & Physics Materials***
What is collision detecton and resolution, and how are colliders and physics materials utilized in Unity?

<details>
<summary> Some definitions to start off with... </summary>

1. ***Collision Detection*** →  detecting a collision(s) between two game objects in a scene.
    - Easy to work in Unity!
        - Just attach 2D colliders to the game objects and then 2D physics.

2. ***Collision Resolution*** → giving an action, response, or doing something based on the fact that a collision has been detected.
    - As long as we add materials to our colliders, we can have the physics engine determine how that collision gets resolved (how the objects bounce off of each other, or not, for example, based on friction and bounciness for the colliders).
    - We can also implement our own collision resolution in case we want to do something else (reduce health as a result of the collisions and such).

3. ***Vector*** → an object that has both a magnitude and direction:
    - vector = (m*x)

4. ***Magnitude*** → how far the vector goes 
    - Equation: |ab| = sqrt { (a2-a1)^2 + (b2-b1)^2 }  

5. ***Direction*** → is the measure of the angle the vector makes with horizontal line

</details>
<br></br>

## ***Collision Detection in Use:***
- Before we can get to the colliders, we first need to make some changes to our mover script.
- Suppose you want the game object to move in a random direction with a random speed...

``` C#
void Start()
{
    // get the game object moving
    const float MinImpulseForce = 3f;
    const float MaxImpulseForce = 5f;
    float angle = Random.Range(0, 2 * Mathf.PI);
    Vector2 direction = new Vector2(
        Mathf.Cos(angle), Mathf.Sin(angle));
    float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
    GetComponent<Rigidbody2D>().AddForce(
        direction * magnitude,
        ForceMode2D.Impulse);
    )
}

```
1. What you will first need to do is declare a maximum and minimum Impulse force that is constant and is represented as a float (since we are working with absolute value/vectors).
    - This is so that you can give a wide range of impulse forces to apply.
2. Next, you will need a random angle.
    - To do this you declare an angle (still as a float) between 0, and a large number (for this example 2 Pi).
3. In order to determine the direction,
    - Generate a direction vector using cosine and sine of that angle. 
    - A fairly reassuring note, the Unity engine provides the right tools for math such as calculus, the only math knowledge that will need to come from the programmer is trigonometry and basic physics.
4. Next, determine the magnitude
    - set another random range that is between the two Impulse force previously called.
5. Get the Rigidbody 2D component and add the force 

<br></br>

## Time to make colliders
1. Colliders can be found in the components are.
    - For this lecture, we used the ***box collider*** for the game object and an ***edge collider*** for the main camera
