# Fields n' Properties
Covering how one adds fields and properties to the created Die Class in the previous section.

## Some Tips around Visual Studio
1. Right click on the project name (the bold name in the folders), and add a class. (in this instance we added a Die.cs class)
2. To have any other class have access to a field being created, you use the `public` access modifier
    - ***Access Modifier*** → The keyword used in front of variables to control access to the variables.
3. Remember, properties are the way that we let external classes access information about the state of this particular object.
    - If we're going to let them do that, then we'll make our property public.
    - This isn't the same as making our field public because we have control through our properties what they can do and what they can't do. 
4. So in reading the properties, we implement something called a `get{}` accessor and to write the property, we implement something called a `set{}` accessor.
    - For the get accessor, we know that if someone's asking how many sides this Die has that that number is stored in the `NumSides` field.
    - So, we're going to want to do something with the value of the NumSides field and by putting the name of the variable, we are accessing the value, just as we've seen if we do math with these things, and so on.
        - That doesn't actually finish the get accessor though because we also need to not just retrieve this value from the variable but we need to `return` it to whoever is accessing the get accessor. 
    - The set accessor lets somebody set the property and so, typically here, we would set numSides equal to something and the something that we would set it equal to is a special keyword called value.
5. Letting someone find out how many sides the Die has is perfectly reasonable. After the Die has been created, letting someone change the number of sides on the Die is not reasonable.
    - That would be like if you were playing a dice game and you let somebody pick up a die and shave it down with a file to add an additional face and then mark it up with a magic marker, or something, that would be what this would support. That's cheating.
    - So, we won't let that happen; we will get rid of the set accessor for this property and we'll only let consumers of the class access the get accessor to find out how many sides the Die has without changing them. 

<details>
<summary> See Code Here </summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieClassLecture
{
    /// <summary>
    /// A die
    /// </summary>
    public class Die
    {
        // We first must declare variables for our fields
        #region Fields

        int numSides;
        int topSide;

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets the number of sides
        /// </summary>
        /// <value>number of sides</value>
        public int NumSides
        {
            get { return numSides; }
            // no set cuz we dont want the number of sides to change
        }

        /// <summary>
        /// Gets the Top Side
        /// </summary>
        /// <value>top side</value>
        public int TopSide
        { 
            get { return topSide; }
        }


        #endregion
    }
}

```
</details>