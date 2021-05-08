# Abstraction in Code
How abstraction helps the programmer as they write code.

## Abstraction: Important Takeaways
1. When we write code, every detail we include costs us time, money, and usually memory and CPU cycles at run time.

2. Abstraction helps us reduce all those costs by letting us ignore unimportant details

***The Implementation Mechanism***
- The model of the details that is decided to be important in
object oriented languages (including C#) → the class or classes that you implement.

- Example 1:
    - Storing location or velocity in a `Vector2` object
    - Important details: x and y components of the vector 
    - Discussion:
        - Good abstraction for 2D work
        - Bad abstraction for 3D work because we lack a z component.

- Example 2:
    - Storing student data in a `Student` object
    - Important details: student number, percentage, letter grade
    - Discussion:
        - Good abstraction for student grade
        - Bad abstraction for student demographics (age, gender, etc.)

- Example 3:
    - Storing GPS coordinate in a `GPSCoordinates` object
    - Important details: lattitude and longitude
    - Discussion:
        - Good abstraction for current location/ dynamic directions
        - Bad abstraction for calculating altitude gain for a hike

3. Abstraction can help us reduce development in run time costs by focusing us on the details that matter in our implementation.

4. Abstractions allows for our software easy to understand because we haven't included details that don't matter for the problem we're trying to solve,

5. In C#, our abstractions are the classes that we implement, and abstraction (the thing) can also be called the model of the thing that we're trying to represent. 