# Floating Point Integers
How Data Types can represent real numbers in C#.
<br/><br/>

## ***Definitions***

<details>
<summary> In Programming: </summary>

* ***Real Numbers*** → numbers with a decimal; ones that are in what is called the continuous domain 

* ***Continuous Domain*** → the infinite number between 0 and 1.

* ***Discrete Domain*** → A place to represent most real numbers since we cannot represent all of the real numbers.

* ***Floating Point Numbers*** → the way real numbers are represented in the computer, so that the number stays in the discrete domain. `float` & `double`. 

</details>

## ***Domains and Floating Point Numbers***
1. The Data Types that C# Uses for real numbers are called `float` and `double`
    - `float` is used most of the time.
    - `double` is twice as many bits that floats.

2. ***Type Casts*** → a way to temporaily treat a variable as a float or anything else.
    - ie. : `float pointsPerSecond = (float)score / totalSecondsPlayed;`
        - The `(float)` is the type cast.
        - **IMPORTANT**: Make sure not to type cast the stuff after the type cast.
            - DON'T DO THIS `(float)(score / totalSecondsPlayed;)` 
<br/><br/>

***Exercise 5: Declaring & Using Variables & Constants***
Task: Print in a 2D Unity Script the percentage of a score given based off of a max score.

- [Here's my solution](Exercise5.cs)