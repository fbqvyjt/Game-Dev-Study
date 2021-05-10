# ***Method Headers***
How to implement method headers for four different kinds of methods and we'll also see how to call those four different kinds of methods. 

## What exactly does a Method Header tell us?
1. Who can call the method.
2. Whether the method is called on an object or a class.
3. What data type the method returns.
4. The name of the method.
5. What information to pass into the method.

## Syntax for a Method Header

1. The `[access modifier]` tells us who can call the method. So, if we make this method public, then anyone can call it, and if we make it `private`, then only other methods within this object can call it. The square brackets mean that the access modifier is optional and if we don't provide it, the default is `private`.

2. The next piece of the method header tells whether we call the method on an object or on a class. And if we do not provide the keyword `[static]`, then we call the method on an object. But if we do include that `[static]` keyword, then it's on a class, not an object.


<details>
<summary> What the code looks like... </summary>

```C#
[access modifier] [static] returnType MethodName(
    dataType parameterName,
    dataType parameterName,
    ...)
```

</details>

## There Are 4 Kinds of Methods:
1. No return value, no parameters.
    - `public void Shuffle()`
2. Return value, no parameters.
    - `public Card TakeTopCard()`
        - The typical way that we call the method that returns something is that we call the method as we're used to calling methods over here on the right, and then we put it into an object or a variable of some sort to hold the value that gets returned. 
3. No return value, with parameters.
    - `public void Cut(intLocation)`
        - When somebody calls this kind of method, we expect that somebody to provide an integer for the location. It's certainly possible to have multiple parameters (they are just separated by commas).
4. Return value, with parameters.
    - `public Card TakeCard(intLocation)`
        - We call the method by putting the object name dot method name and whatever we want our location to be between the parentheses as an argument that we're passing into the method