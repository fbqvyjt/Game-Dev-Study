# Practice in the Console App
Exercises and review of material in the Console App Chapter

<details>
<summary> A Classy Apple </summary>

1. Develop an abstraction for a console app apple that the `Main()` method wants to eat. The `Main()` method likes all kind of apples, but it doesn’t like to ingest pesticides. Of course, once the apple is gone the `Main()` method doesn’t want to keep trying to eat it!

2. Start by figuring out the details that matter for this abstraction. After you’ve done that, figure out the fields, properties, and methods your `Apple()` class should implement. If you want to, you could even draw a UML class diagram of your `Apple()` class.

- Note: The next few exercises will implement the design from this exercise.

- See Solution [Here](AClassyApple.md).

</details>
<br></br>


<details>
<summary> Apple Fields and Properties</summary>

1. Implement the fields and properties for the Apple class from the previous exercise. 

```C#
using System;

namespace AClassyApple
{
    public class Apple
    {
        #region Fields

        float ammountLeft;
        bool organic;

        #endregion

        #region Properties
        
        public float AmmountLeft
        {
            get { return ammountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }
    }
}


```

</details>