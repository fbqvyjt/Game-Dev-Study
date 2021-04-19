# ***Data Types, Variables, and Constants***
Lecture on what are Data Types, Variables, and Constants.


## ***Overview***
***Data Types*** → tell us how to interpret the bit at a particualr memory location and the valid operations for those bits.

***Variables*** → are declared to allocate memory for a particular data type, so that we can refer to that memory location by name instead of by memory address.

***Constants*** → act similarly to variables, however those are values that we cannot change as we run the program.



## In-Depth Information
1. How do we interpret a line of binary? It can represent:
    - Letters according to ASCII
    - An added number
    - Well... many other things!

2. The ***Data Type*** of a variable or constant tells us how to interpret bits in binary code.
    - it also can determine the valid operations of a value
        - Adding an integer to a *True* or *False* value doesn't make sense for this.

3.  ***Memory addresses*** (a location of memory of bits) cannot be empty as they are switches and have to be either on or off.

4. In order to make these addresses more convenient, we declare ***Variables*** so that the compiler knows how to interpret the ones and zeros and how much memory memory should be used.

5. The difference between ***Constants*** and variables is that the value of a variable can change while we run the program and the variable of a constant can't.
    - Also the compiler has to know the value of a constant at compile time as we have to give a constant its value when we declare it.
