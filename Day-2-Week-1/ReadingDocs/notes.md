# ***Reading Documentation***
Tips on how to practice reading documentation for any programming language issue you may have.
    - Follow along with [this](DocuLec.cs) lecture code!

1. Whenever you assign a decimal number to a floating point number, the compiler will automatically assumed it's a double because the smaller data type can't represent a bigger one.. 
    - ie. : `float cosine = 0.8;` 
    - error given → <span style="color:red"> "Literal of type double cannot be implicitly coverted to type 'float', use an 'F' suffic to create a literal of this type."</span>
    - so use an f suffix to help the code
2. In order to support doing certain kinds of math in your program you have to know the Math Class and its methods. 
    - By going to the Documentation link provided in the Help Tab of VSCommunity, search for "cosine"
    - scroll until you can find either "Math.Cos Method (Double)" (or "Math Class" and scroll until you can find "Cos(Double") in the methods section).
3. Now, remember to REALLY READ the parameters within the method that you need, because sometimes what measurement you are provided might not be the same that the parameter(s) calls for. In this instance, `Math.Cos()` requires an angle be measure in radians instead of degrees.
4. Another thing to remember is that this method also needs to be type casted as a float.

5. Last math note → in order to convert an angle in radians, you can multiply the angle by 
    - `(float)Math.Cos(yourAngle * (float)Math.PI / 180`)
<br/><br/>


## ***Exercise 6: Trigonometry with Floats***
Task: Declare an angle using a prompt and calculate what is the cosine of that angle.
    - [Here's my solution.](Exercise6.cs)


## ***Exercise 7: Calculations and Rounding***
Task:
    - [Here's my solution.](Exercise7.cs)