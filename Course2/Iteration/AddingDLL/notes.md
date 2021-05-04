# ***Adding a DLL***
What is a DLL and how is it implemented in code?

<details>
<summary> Some Definitions First... </summary>
 
 - ***DLL*** → "Dynamic Link Library" → a library that contains code and data that can be used by more than one program at the same time.
 
 - ***Control Structures*** → control statements that are used to control program flow (i.e.: if, else, for, foreach, while), performing conditional logic in the application. Is the general term for three different catgeories of structures:
    - **Decisive** → `if`, `else`, `else if`.
    - **Iteration** → `while`, `do`, `for`, `for each`, `in`, `continue`, `break`.
    - **Miscellaneous** → `goto`.
 
 - ***Selective structures*** → AKA Conditional structures, it is a programming feature that performs different processes based on whether a boolean condition is true or false. These structures use relational operators to test conditions.

 - 

</details>

## Steps on How to Add a DLL to our Project
1. To check which DLL's are being used, refer to your references folder in the project.

2. If you would like to make edits to the file, in the solution exploror, right-click the reference and click "Add reference". You now can add a .NET assembly or downloaded file that you want to utilize. (I added the ConsoleCard.dll)

3. All DLL's should come with its own documentation 

4. Now that you have have that DLL added to your project, you must now add a `using` directive for it at the top.
    -  Odds are you will get an error that it cannot be found, it means usually that the DLL that you added was built to a higher version of .NET that what you have set that up.

5. To fix this aforementioned issue, double-click Properties below the project name in the solution exploror window.

6. Select Application in the list on the left of the popup

7. Use the dropdown for the Target framework to select the version that matches the dll version.

8. SMASH that "Yes button to smitherins. 💣🎆🎇

<br></br>

Written Code for this Section

```C#
using System;
// create a using directive for your new DLL here.
using ConsoleCard;

namespace ForLoops
{
    // insert code here.
}


```
