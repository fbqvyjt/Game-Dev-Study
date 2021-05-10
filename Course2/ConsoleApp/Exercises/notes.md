# Practice in the Console App
Exercises and review of material in the Console App Chapter

<details>
<summary> A Classy Apple </summary>

* Develop an abstraction for a console app apple that the `Main()` method wants to eat. The `Main()` method likes all kind of apples, but it doesn’t like to ingest pesticides. Of course, once the apple is gone the `Main()` method doesn’t want to keep trying to eat it!

* Start by figuring out the details that matter for this abstraction. After you’ve done that, figure out the fields, properties, and methods your `Apple()` class should implement. If you want to, you could even draw a UML class diagram of your `Apple()` class.

* Note: The next few exercises will implement the design from this exercise.

* See Solution [Here](AClassyApple.md).
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
<br></br>


<details>
<summary> Building an Apple </summary>

* Implement the constructor for the Apple class we’ve been working on in the previous two exercises.

* Remember, the constructor parameters should be whether or not the apple is organic and how large the apple is (which will be my initial value for how much is left to eat).

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleExercise
{
    /// <summary>
    /// An apple
    /// </summary>
    class Apple
    {
        #region Fields

        bool organic;
        float amountLeft;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="organic">If set to <c>true</c>, the apple is organic</param>
        /// <param name="size">size of the apple</param>
        public Apple(bool organic, float size)
        {
            this.organic = organic;
            amountLeft = size;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets whether or not the apple is organic
        /// </summary>
        public bool Organic
        {
            get { return organic; }
        }

        /// <summary>
        /// Gets how much apple is left to eat
        /// </summary>
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        #endregion
    }
}

```

* Add code to your `Main()` method to instantiate an Apple object and access the properties to ensure the constructor and properties are working correctly.

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleExercise
{
    /// <summary>
    /// Exercise 9, 10, and 11 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the apple class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // test constructor and properties
            Apple apple = new Apple(true, 1.5f);
            Console.WriteLine("Organic? " + apple.Organic);
            Console.WriteLine("Amount Left: " + apple.AmountLeft);

            Console.WriteLine();
        }
    }
}

```

</details>
<br></br>


<details>
<summary> Eating an Apple </summary>


</details>
