# ***Instantiating Objects With a Constructor***
What is a constructor and what does it mean to instantiate?

## ***What is a Constructor?***
***Constructor*** → a class that creates (or ***instantiates***) an object
- A constructor generally has the format → `Constructor()` 
- It is called most of the time without being given any parameters. 
- Well! Let's try one out!
<br></br>

## ***How to Add a Class and/or Constructor to a Solution***
[See Code](CreateConstructor.cs)
- IMPORTANT: Before anything, if you haven't already, import or create a new class (in this instance, we are importing the UsingDeckClass). 

### How to Instantiate an Object with a Constructor:

* First, you have to physically add the Constructor .cs file to the folder your program.cs is in.
* Once you have done that, in the Solution Explorer, right-click the folder Program.cs and select the "Add → " tab.
* After that, select "Existing item..." and open the class file(s) you want to use. 
* Lastly, make sure to rebuild the solution and start using the class at the top. → "`using UsingDeckClass;`"

1. Using the class, declare the Constructor and create a `new object();`
    - It's given "value" will be creating the constructor → `Deck deck = new Deck();`
2. To put it to use and see what are the object's contents:
    - Make a print statement the object you just created
        - `deck.Print();`