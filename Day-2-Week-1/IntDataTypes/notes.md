# ***Integer Data Types***
Lesson on how to utilize commonly used integer (whole numbers) data types in C#

<details>
<summary> What are the Four Common Data Types for Integers? </summary>

* **Byte** → 8 bits
* **Short** → 16 bits
* **Int** → 32 bits Most game development projects uses Int
* **Long** → 64 bits

</details>

1. Via VSCommunity, learned how to use `int` in the context of setting it as a constant or variable.
    - Made a program on how to determine the number of minutes based on seconds given, and vice versa.

2. Learned that `const int` is used to denote a constant being written. 
    - C# protocol dictates that a name given to a constant must start with a capital letter:
        - i.e. : `const int SecondsPerMinute = 60;`
            - vs. : `int totalSecondsPlayed = 100;`  

3.  

4. It is really important to note that 2,147,483,647 is the maximum possible integer in C#. So when 1 is added to it, we actually end up with the minimum possible negative number in C# as a direct consquence of our equation n = 2^b
    - THIS was an actual problem that arose in Grand Theft Auto V with the money system!

<details>
<summary> Lastly, it's important to note that there's two distinctions between data types: <summary>

* ***Value Types*** are the bytes, short, int or long at a memory location interpreted as an integer.

* ***Reference Types*** are interpreted as a memory address. 







