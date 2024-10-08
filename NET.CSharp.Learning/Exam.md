# Exam preparation

#### 1. What is a code block? 
Lines of code that should be treated as a single unit.

#### 2. What is a Boolean statement or expression? 
Code that returns either true or false.

#### 3. Given that int x = 5, which of the following Boolean expressions is valid and evaluates to true? 

a) x < 5

b) x > 5

c) **``` x == 5 ```**

#### 4. Which of the choices below is not a valid operator in C#? 

a) **```%%```**

b) &&

c) ||

#### 5. The following answer choices describe if statement syntax. Which of the descriptions is correct? 

a) The Boolean expression evaluated by an if statement is optional.

b) **``` An else statement can't be placed before an else if statement. ```**

c) The else statement is required when an if statement includes an else if.

#### 6. What is an array? 

a) A string variable.

b) **``` A sequence of individual data elements accessible through a single variable name. ```**

c) A .NET Class Library.

#### 7. Which of these is a correct example of creating an array and initializing it? 

a) string[] myarray = new string[3]; myarray = "test1"; myarray = "test2"; myarray = "test3";.

b) string[] myarray = string[3]; myarray[0] = test1; myarray[1] = test2; myarray[2] = test3;.

c) **``` int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3; ```**


#### 8. Which of the following can be used to access the third element in an array? 

a) myArray[3]

b) **``` myArray[2] ```**

c) myArray{3}

#### 9. Which of the following choices describes the correct way to create a new integer array with three elements? 

a) **```int[] myArray = new int[3]; ```**

b) int[] myArray = new int[2];.

c) int myArray = new int[3];.


#### 10. Which of the following foreach statements is syntactically correct? 

a) **``` foreach (int value in values) ```**

b) foreach (int value of values).

c) foreach (int value with values).


#### 11. Which of the following demonstrates recommended guidelines for naming a variable? 

a) my-string.

b) initialMessage$.

c) **``` initialMessage ```**


#### 12. Which of the following is a bad reason to use a code comment? 

a) To describe the high-level intent of the code.

b) **``` To explain how a new C# keyword works. ```**

c) To temporarily comment out a line of code while evaluating a feature in a different way.


#### 13. Which of the following statements about using whitespace in code is true? 

a) Reducing the amount of whitespace will improve code performance (execution speed).

b) Whitespace should be used every two or three lines to separate code lines.

c) **``` Whitespace should be used judiciously to improve the readability of your code. ```**


#### 14. A developer writes an application that uses a foreach loop to iterate through an array containing 20 elements. After the application is complete, the developer learns that the array must be updated to include 40 elements. The application needs to examine all 40 array elements. Which of the following items describes the required code update? 

a) Create a second foreach loop that iterates through the additional items.

b) **```No changes are required to the foreach loop.```**
_Correct! A foreach loop will iterate through all of the elements in an array._

c) Place the original foreach loop inside the code block of a second foreach loop that iterates twice.


#### 15. A developer is working on a nested foreach structure that iterates through all of an application's data arrays. The first array contains the names of locations where water samples were collected. The remaining arrays contain the test results for the samples collected from each named location. Which of the following statements about how the arrays should be processed is correct? 

a) Each of the arrays containing samples can be processed by the outer loop, the inner loop will be used to verify the location.

b) The order in which the arrays are processed doesn't matter since the application has to process all of the data.

c) **```The outer loop must process the array containing locations, the inner loop must process the arrays containing samples.```**

_Correct! The outer loop will iterate through the locations. The code block of the outer loop will be used to select the samples array for each location, and then process the sample in the inner foreach loop._


#### 16. A developer is working on a nested foreach structure that iterates through the application's array data. The first array contains the names of 10 geographic regions. The remaining arrays are based on the 10 regions. Each regional array contains the population of cities that have a population over one million. The population values in the regional arrays go from largest to smallest. The application sums the 25 most populated cities in each region. How should the developer ensure that only the 25 largest populations are added to the sum? 

a) The developer should insert a "marker value" into the population arrays. The "marker value" should be added at index position 25. When the marker value is detected, the application should stop adding values to the sum.

b) The developer should check the index number of the current array element inside the foreach code block. The application should stop adding values to the sum when the index number reaches 25.

c) **```The developer should increment a counter inside the foreach code block. The application should stop adding values to the sum when the counter reaches 25.```**

_Correct! The developer should use a counter that increments inside the foreach loop._

#### 17. A developer is working with two other developers to update a collection of applications. The developers will use code comments during the update process. Which of the following describes an appropriate use of code comments? 

a) When updates are made, the developers use line and block comments to identify each individual code update.
Code comments should not be used to describe individual code lines. In this case, it would be better to summarize changes in a single block comment at the top of the files that contain updates.

b) When updates are made, the developers leave all existing code comments intact. New comments are added to indicate when old comments no longer apply.

c) **```When updates are made, the developers summarize changes using block comments.```**
_Correct! Using a block comment to summarize the changes implemented during an update is a good use of code comments. A single block comment at the top of the files that contain updates is often sufficient._

#### 17. Which of the following is a list of valid comparison operators? 

a) ==, ~=, >, <, >=, and <=.

b) ==, <>, >, <, >=, and <=.

c) **```==, !=, >, <, >=, and <=```**

_That's correct. ==, !=, >, <, >=, and <= are all valid comparison operators._

#### 18. Which of the following code lines uses logical negation? 

a) Console.WriteLine(myValue!= true);.

b) **```Console.WriteLine(!myValue);```**
Correct! Adding the ! operator before a conditional expression is the correct way to implement logical negation.

c) Console.WriteLine(myValue == false);.

#### 19. An application contains two string variables named myValue1 and myValue2. The user enters the following two values for these variables: "Y " and " y". Which of the following expressions return false? 

a) (myValue1!= myValue2).

b) **```(myValue1.Trim().ToLower() != myValue2.Trim().ToLower()).```**
_Correct! This expression returns false since the two values are equal and the inequality operator is being used._

c) (myValue1.Trim().ToLower() == myValue2.Trim().ToLower()).

#### 20. Which of the following lines of code is a valid use of the conditional operator? 

a) int bonus = amount >= 100? 10: 5;.
_Correct! This code line shows the correct syntax for a conditional operator ?:._

#### 21. Which line of code uses logical negation? 

a) **```Console.WriteLine(!value);```**
Correct! Adding the ! operator (the "not-operator") before a conditional expression forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true if the operand evaluates to false and false if the operand evaluates to true.

b) Console.WriteLine(value != false);

c) Console.WriteLine(a != b);

#### 22. Which of the following lines of code is a valid use of the conditional operator? 

a) **```int value = amount >= 10? 10: 20;```**
_Correct! The syntax for a conditional operator is "? (value 1) : (value 2)"._

b) int value = amount >= 10: 10? 20;.

c) int value = amount >= 10? 10| 20;.

d) int bonus = amount >= 100: 10? 5;.

e) int bonus = amount >= 100? 10, 5;.

#### 23. A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed? 

a) **```No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.```**
_Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block._

b) No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.

c) An error is generated because the first variable isn't in-scope after the code block.

#### 24. Which of the following statements is true about showing/removing the curly braces for code blocks associated with an if statement? 

a) The curly braces can't be removed from the code block for else if and else statements.

b) If the curly braces are removed from the code blocks of an if-elseif-else, the white space must also be removed.

c) **```Always choose a style that improves readability.```**

_Correct! Code readability should always be a consideration when deciding whether to remove the curly braces from the code blocks associated with an if statement._

#### 25. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 1 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 8. The second code line inside the code block is used to assign the sum of the two integer values to the first variable. The first code line after the code block is used to display the value of the first integer variable. What is the result when the code is executed? 

a)  **```No error is generated and the integer value 9 is displayed.```**
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.

b) No error is generated and the integer value 1 is displayed.

c) An error is generated because the first variable is not in-scope after the code block.

#### 26. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 5 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 6. The first code line after the code block is used to add the second integer value to the value of the first integer. The second code line after the code block is used to display the value of the first integer. What is the result when they run the code? 

a) No error is generated and the integer value 11 is displayed.

#### 27. A developer writes the code to implement a switch-case construct. What is the purpose of the break keyword? 

a) The break keyword tells the runtime to continue evaluating other cases in the switch construct.

b) **```The break keyword tells the runtime to stop evaluating case patterns and prevents execution of other cases in the switch construct.```**
Correct! The break keyword redirects code execution and prevents one switch section continuing into the next section.

c) The break keyword tells the runtime to exit the application.

#### 28. A developer writes the code to implement a switch-case construct that evaluates a variable against many possible matching values. They include the default keyword as part of their switch-case construct. What is the purpose of the default keyword? 

a) The default keyword supplies the default value for the variable if the variable hasn't been initialized.

b) **```The default keyword acts as the matching value when none of the supplied case values is a match.```**
_Correct. If there's no matching case value labels, the optional default label is used as the matching value._

c) The default keyword supplies a default actions code block that is always executed regardless of the matching case value


#### 29. Which of the following statements about the switch-case construct is true? 

a) **```A single switch section can have multiple case labels.```**
Correct!

b) A switch construct must include a default switch section.

c) The colon at the end of the case label is optional.


#### 30. What is the purpose of a default case in a switch statement? 

a) It's used to specify the condition for the switch statement.

b) It's used to end the switch statement.

c) **```It's used to execute a block of code if no case matches the expression.```**
_Correct! The default case executes when no other case matches the switch expression._

#### 31. What happens if a break statement (or alternative keyword that prevents "fall-through") is omitted in a switch case? 

a) The default case will execute.

b) The impacted case sections will be removed by the compiler.

c) **```The compiler will generate an error.```**
_Correct! Only one switch section is allowed to be executed. If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error._

#### 32. Which of the following for statements is correct? 

a) for (int x = 20: x < 80: x++)

b) for (int j = 0; j < 80; j + 1)

c) **```for (int counter = 20; counter < 80; counter++)```**
_Correct!_

#### 33. Which of the following statements should be used to exit out of a for loop before the iteration has completed? 

a) exit;

b) **```break;```**
_Correct! The break keyword can be used to jump out of a for loop when a desired condition is met._

c) return;


#### 34. Which of the following correctly describes a behavior of either a do-while or while iterative statement? 

a) A do-while statement executes a code block zero or more times.

b) A while statement executes a code block at least once.

c) **```A do-while statement executes a code block at least once.```**
_Correct! The do-while iterates through a code block at least one time. Code execution exits the iteration loop once the while expression at the end of the code block evaluates to true._

#### 35. A developer needs to capture user input inside a loop. The user enters the keyboard combination ctrl + Esc to exit the iteration when they're done entering information. Which is the best iteration statement for this purpose? 

a) while

b) for

c) **```do-while```**
_Correct! The do-while allows the developer to check each entry by the user until they enter the special keyboard combination to exit._



#### 36. A developer needs to iterate through an array of items. The number of items in the array is unknown. The code inside the iteration code block examines each item sequentially to select an item that matches specified criteria. The index number of the selected array element isn't important. The selected item is referenced multiple times within the code block. Which type of iteration statement is best suited for this scenario? 

a) **```foreach```**
_Correct! It's possible to use any of these iteration types for the conditions described, but a foreach is best suited for this scenario. The foreach is easy to implement when the number of array elements is unknown. The foreach is a good choice when the index number of the selected array element isn't important. The foreach might run faster when the selected item is used multiple times within the code block._

b) for

c) while

#### 37. A developer needs to capture a list of items from the user. The user will enter the keyboard combination ctrl + Esc to exit. Which is the best iteration statement for this purpose? 

a) foreach

b) **```do-while```**
_Correct! The do-while will allow the code to check each entry by the user until they enter the special keyboard combination to exit._

c) while


#### 38. When is it appropriate to use a switch-case construct rather than a if-elseif-else construct? 

a) **```A switch-case construct is appropriate when more than 2-3 else if code blocks are required.```**
_Correct! When more than 2-3 else if code blocks are required, the code can become difficult to read, and the switch-case construct is preferable_

b) A switch-case construct is appropriate when the number of case patterns is small.

c) A switch-case construct is appropriate when the selection statement is inside a loop.

#### 39. Why should a developer choose a for statement rather than a foreach statement when processing the contents of a multidimensional array? 

a) for statements do a better job of examining each array item separately.

b) foreach statements do a better job of examining each array item separately.

c) **```for statements enable a developer to treat array dimensions separately.```**
_Correct! When their code is processing the contents of a multidimensional array, a developer often wants to iterate through the array dimensions separately. The for statement provides better support for processing array dimensions separately._

#### 40. Why is it important to scope a variable at its lowest necessary level? 

a) It ensures that a variable that's declared outside of a code block, can be accessed inside the code block before it's been assigned a value.

b) **```It ensures that application resources and the security footprint are kept small.```**
_Correct. Keeping variables scoped at the lowest necessary level enables better resource management and helps to minimize the attack profile of the application._

It ensures that a variable can be accessed within the lowest level code branches of an application.

#### 41. A developer is writing an application in Visual Studio Code. They save changes to their Program.cs file, and then run the dotnet build command in the Terminal panel. What information can they find in reported Error and Warning messages? 

a) One or more suggestions for how to fix any syntax issues detected.

b) **```The line number and information about what caused the error.```**
_Correct. Error and Warning messages include a description of the issue and the line number where it occurs._

c) Links to help documentation.

#### 42. A developer needs to create an iteration statement. Under what condition is a while statement a better choice than a do statement? 

a) When the expression values evaluated by the iteration statement are unknown prior to the iteration code block.

b) **```When the expression values evaluated by the iteration statement are known prior to the iteration code block.```**
_Correct. When the code is able to evaluate the loop expression prior to the loop, a while statement allows the code to implement zero iterations.
_
c) When the developer creates nested do or while loops.

#### 43. Which choice best represents how bits represent on and off? 

a) Bits are represented using "x" or "o" character.

b) Bits are represented using "+bit" or "-bit" notation.

c) **```Bits are binary and represented using "1" or "0" digit.```**
_Correct. Bits are represented using the "1" or "0" digit._

#### 44. Which data type has a range of whole numbers between 0 and 65535 in C# code? 

a) Sbyte

b) **```Ushort```**
_Correct, ushort represents values 0 to 65535._

c) byte

#### 45. Which is the best data type to use to process banking deposits? 

a) **```Decimal
_Correct. Decimal, with ~28-29 digits of precision, has the precision required for many financial applications._

b) Float

c) Double

#### 46. In C#, when the new keyword is used to create an instance of a class, where is the memory allocated? 

a) Stack

b) **```Heap```**
_Correct. Instances of classes are allocated on the heap when created with the new keyword._

c) Variable

#### 47. A piece of code must store whole numeric values between negative and positive 1,000,000. Which is the best data type to be used? 

a) float

b) double

c) **```int```**
_Correct. While float or double would work, their extra precision after the decimal doesn't fit the exact requirement of this scenario._

#### 48. The code for a game needs to store lots of fractional values representing x, y, and z positions in a large 3D space. It will likely need to perform physics calculations for trajectories and so on. Absolute precision isn't required, but it's important that the program runs as efficiently as possible. Which data type is best? 

a) **```float```**
_Correct. Unlike int, float can store fractional numbers, and unlike decimal, float doesn't require extra memory to store extra precision that isn't needed in this scenario._

b) decimal

c) int

#### 49. Which of the following statements is true? 

a) Reference types are stored in the stack.

b) Value types can only store numbers.

c) **```Use the new operator to create a new instance of a reference type and return its address to the variable.```**
_Correct. Use the new operator to create a new instance of a reference type and return its address to the variable._

#### 50. Which is the best technique to convert a decimal type to an int type in C#? 

a) **```Cast```**
_Correct. decimal to int is a narrowing conversion so cast is the best answer._

b) Narrowing

c) Implicit conversion

#### 51. Which of the following conversion rounds the value (versus truncate)? 

a) int cost = (int)3.75m;

b) **```int cost = Convert.ToInt32(3.75m);```**
_Correct. Convert.ToInt32() rounds values with fractional precision._

c) uint cost = (uint)3.75m;

#### 52. Which technique should be used to change myInput, a string value "2.71828", into a decimal variable myInputDecimal? 

a) decimal myInputDecimal = (decimal)(myInput);

b) decimal myInputDecimal = myInput + 0;

c) **```decimal.TryParse(myInput, out myInputDecimal);```**
_Correct. Using TryParse (or Parse()) is a valid technique._

#### 53. Consider the C# code bool success = decimal.TryParse(input, out decimal number);. Which best describes the return type of decimal.TryParse()? 

a) decimal

b) **```bool```**
_Correct. TryParse() returns a bool._

c) out

#### 54. Which technique results in an error when used to convert a string value 4.123456789 into a decimal? 

a) Convert.ToDecimal()

b) decimal.TryParse()

c) **```(decimal)```**
_Correct. It isn't possible to directly cast a string into a decimal and results in an error._

#### 55. What type of action is being performed when changing a float into an int? 

a) **```A narrowing conversion.```**
_Correct. Changing a float into an int is a narrowing conversion, because float can store more precision data compared to int._

b) A widening conversion.

c) An illegal conversion.

#### 56. Which best describes the code Array.Sort(pallets); where pallets is a string array? 

a) Sort represents a cast operation

b) **```Sort is an Array method.```**
_Correct. Sort is an Array method._

c) Sort is used to sort array amount of precision.

#### 57. What best describes the code Array.Clear(pallets, 0, 2); where pallets is a string array? 

a) **```Array.Clear(pallets, 0, 2); removes the data from 2 array elements starting from item 0.```**
_Correct. Clear is a method of arrays that removes (replaces with Null) specific elements in an array._

b) Array.Clear(pallets, 0, 2); removes the data from array element locations pallets[0] and pallets[2].

c) Array.Clear(pallets, 0, 2); removes array elements that are equal to 0 or 2.

#### 58. String.Join("-", myArray); is an example of a Join. Which explanation best fits this example? 

a) Constructs a character array from items in myArray connected with , (commas).

b) **```Constructs a string from items in myArray connected with - (dashes).```**
_Correct. String.Join constructs strings from the elements of myArray)._

c) Constructs a string named myArray connected with - (dashes).

#### 59. Which method changes the order of items in an string array? 

a) myArray.Resize()

b) myArray.Clear()

c) **```Array.Sort()```**
_Correct. Array.Sort() places string array items in ascending order._

#### 60. What is null? 

a) The same as an empty string.

b) The same as the value zero.

c) **```A value that indicates a variable points to nothing in memory.```**
_Correct. Null isn't the same as an empty string or the value zero._

#### 61. Which is the output of Console.WriteLine($"Tax rate: {tax:P1}");, where tax is defined by decimal tax =.12051 m;? 

a) Tax rate: 12.05%

b) Tax rate: 12.10%

c) **```Tax rate: 12.1%```**
_Correct. tax: P1 rounds the percentage to a single decimal place._

#### 62. Given string myWords = "Learning C#", what is the best output description for Console.WriteLine(myWords.PadLeft(12));? 

a) **```One space is added to the start of the string.```**
_Correct. myWords is 11 characters long, adding on space completes the padding to 12._

b) Four spaces are added to the start of the string.

c) 12 spaces are added to the start of the string.

#### 63. For the C# code Console.WriteLine("C110".PadLeft(6, '0'));, which is the expected output? 

a) C11000

b) C110000000

c) **```00C110```**
_Correct. .PadLeft(6, '0') appends zeros to the left side of a string until the string is six characters long._

#### 64. Which format specifier presents a decimal value with the following format to an en-US audience: 12,345.67 

a) 0:C

b) 0:H

c) **```0:N2```**
_Correct. N2 is the correct format specifier._

#### 65. Which character must be used as a directive to perform string interpolation? 

a) **```$
_Correct. The $ directive is used to perform string interpolation._

b) @

c) %

#### 66. What is the return value of myString.IndexOf('C'); where string myString = "C# Time";? 

a) **```0```**
_Correct. "C" is the first item in myString and matches at position 0._

b) 1

c) -1

#### 67. What method should be used to search for the first occurrence of a search term in a long string? 

a) **```IndexOfAny()```**
_Correct. IndexOfAny() returns the first position of an array of char that occurs inside of another string._


#### 68. If the code message = message.Replace("B", "D"); is run, where string message = "Big Dog";, what is the new value of message? 

a) "Big Dog"

b) "Big Bog"

c) **```"Dig Dog"```**
_Correct. "B" is replaced with "D"._

#### 69. Which method finds the next index of either the - char, the = char, or the _ char? 

a) **```IndexOfAny()```**
_Correct. Use IndexOfAny() to retrieve the next index for any of several chars in a string._

b) Remove()

c) IndexOf()

#### 70. What is a constant variable? 

a) A magic string or number.

b) A variable whose name must match its value.

c) **```A value that once initialized can never be changed.```**
_Correct. A constant variable can never be changed, once initialized._

#### 71. Which choice best describes the purpose of TryParse()? 

a) To split sentences into words stored in an array.

b) **```To safely test a cast operation.```**

c) To find a substring in a larger string.

#### 72. For the code decimal.TryParse(numberString, out myConvert)) when the type of numberString is a String. Which best describes the value type for myConvert when the TryParse() is successful? 

a) A string representing numeric digits.

b) A Boolean value.

c) **```A decimal```**

#### 73. Suppose there's a method named ConvertCurrency. Which of the following lines of code is a valid method signature? 

a) ConvertCurrency();

b) ConvertCurrency() { }

c) **```void ConvertCurrency(){};```**
_This line is correct. A method signature is created by declaring the return type, followed by the method name, and parentheses containing any input parameters._

#### 74. Suppose there's a method named Update. Which of the following correctly calls the method? 

a) var update;

b) **```Update();```**
_This answer is correct! A method is called using its name followed by parentheses._

c) void Update();

#### 75. Which of the following correctly declares a method? 

a) DisplayNumbers();

b) void DisplayNumbers{};

c) **```void DisplayNumbers() { }```**
_Correct. A method is declared using the return type, followed by parentheses () containing any parameters, and brackets {} to contain the method body._

#### 76. Which of the following correctly calls a method? 

a) **```GenerateID();```**
_Correct! Methods are called using the name, followed by parentheses () and a semicolon._

b) void GenerateID() {}

c) GenerateID;

#### 77. Which of the following is true about the return keyword? 

a) It's identical to the break keyword.

b) **```It terminates the execution of a method.```**
_Correct! The return statement terminates execution of its method and returns control to the caller._

c) It must always be used with a value or expression.

#### 78. Which of the following method signatures correctly defines 3 integer parameters? 

a) void Multiply(int a, b, c)

b) **```void Multiply(int a, int b, int c)```**
_Correct! The data type for each parameter is included and parameters are comma separated._

c) void Multiply(int a; int b; int c)

#### 79. Given the method signature, void Print(string name, string number = "", bool member = false), which of the following options correctly uses named and optional arguments? 

a) **```Print("Tony", member: true);```**
_Correct! The optional argument is included using the parameter name followed by a :_

b) Print(number: "555", member: false)

c) Print("Tony", false)

#### 80. Given the following method signature, void SetHealth(string health), why don't operations inside the method affect the original input string health? 

a) The string data type is pass by value.

b) The method code must be incorrect.

c) **```Strings can't be altered once assigned. They can only be overwritten with a new value.```**
_Correct! Strings are pass by reference, but they're immutable and can't be altered once assigned._

#### 81. What data type is returned from the following statement: return 100 * 0.5; 

a) An int type

b) A decimal type

c) **```A double type```**
_double is correct. Since an integer literal is being multiplied by a double, this line of code returns a double._

#### 82. Which type of method doesn't need to include a return statement? 

a) string methods

b) **```void methods```**
_void is correct! void methods don't need to use a return statement._

c) array methods

#### 83. Which of the following options correctly returns a string value? 

a) **```return "";```**
_Correct! An empty string is a valid string result._

b) return 'a';

c) return 5;

#### 84. Which of the following statements is true about the return keyword? 

a) It starts a new iteration of a method.

b) **```It terminates the execution of a method.```**
_Correct! The return statement terminates execution of its method and returns control to the caller._

c) It must always be used with a value or expression.

#### 85. Which of the following options is a valid return statement? 

a) return void;

b) **```return 5 % 2;```**
_Correct! This statement would return the value of the expression 5 % 2_

c) return Console.WriteLine();

#### 86. What is the purpose of defining an optional parameter in a method? 

a) To cause a method to perform a different task.

b) To overload a method.

c) **```To simplify the required parameters when a parameter isn't significant to the result.```**
_Correct! Optional parameters enable you to pass fewer arguments and accomplish the method task._

#### 87. What is the purpose of pseudo-code? 

a) **```To provide a design template for the intended code.```**
_Correct! Pseudo-code helps to bridge the gap between concept and code._

b) To safely cast operations performed in methods.

c) To develop syntactically correct code.


#### 88. A developer wants to create a method that compares two values. Which of the following options is the best data type for the method to return? 

a) A double value.

b) Nothing, the method should be void.

c) **```A bool value.```**
_Correct! A comparison expression should return true or false._

#### 89. A developer wants to create a method that returns a value in an array. Which of the following options would be a good choice for a method signature? 

a) **```string GetValueAtIndex(string[] array, int index)```**
_Correct! This method accepts a string array and an index value and returns a string value._

b) bool GetValueAtIndex(string[] array, int index)

c) int GetValueAtIndex(int index)

#### 90. What is code debugging? 

a) A process to identify code syntax errors during the build process.

b)**``` A process to isolate and fix issues in code logic.```**
_Correct. Code debugging involves isolating and fixing logic issues in code._

c) A process to verify that code builds and runs without errors.

#### 91. Who is responsible for software testing? 

a) Software developers.

b) Software testers.

c) **```Both developers and testers.```**
_Correct. Software developers and testers share the responsibility for code testing._

#### 92. What happens if an exception isn't managed in code? 

a) The code continues to run without any issue.

b) **```The application generates an error message and closes.```**
_Correct. If an exception isn't managed in code, the runtime will display an error message and the application may be terminated._

c) The code syntax errors are displayed to the user.

#### 93. What is a debugger? 

a) **```A software tool used to observe and control the execution flow of a program.```**
_Correct. A debugger is a software tool uses an analytical approach to observe and control the execution flow of a program._

b) A program that generates code automatically based on user input.

c) A tool that helps developers write their code faster.

#### 94. What is the primary benefit of using a debugger? 

a) A debugger helps developers to write code faster.

b) **```A debugger enables developers to watch their application running and follow program execution one line of code at a time.```**
_Correct. The primary benefit of using a debugger is watching application code run and following program execution one line of code at a time._

c) A debugger helps developers to add new features to their application.

#### 95. What is one of the most important features of a debugger? 

a) Code generation.

b) **```Observation of your program's state.```**
_Correct. Observation of your program's state is one of the most important features that come with almost all debuggers._

c) Automatic bug fixing.

#### 96. What is the best way to find the root cause of a bug? 

a) Running your app with different data.

b) Breadcrumbing a few Console.WriteLine("here") messages in your code.

c) **```Using a debugger.```**
_Correct. Using a debugger is the best way to find the root cause of a bug._

#### 97. What is the purpose of catching an exception in C#? 

a) To ignore errors that occur in a program.

b) **```To take corrective action when an error occurs in a program.```**
_Correct. The purpose of catching an exception is to take corrective action when an error occurs._

c) To generate additional errors in a program.

#### 98. Can a developer access the contents of an exception at runtime? 

a) No, exceptions can never be accessed.

b) **```Yes, exceptions can be accessed and used to take corrective action.```**
_Correct. Exceptions are objects that can be accessed. The properties of an exception can be used to help determine corrective action._

c) Exceptions can be accessed, but not during the application runtime.

#### 99. What happens when execution of a C# application results in a system error? 

a) The program crashes and closes.

b) **```An exception is created and thrown by the .NET runtime.```**
_Correct. The .NET runtime throws an exception when a C# application generates a system error._

c) The error is silently ignored and the program continues to run.

#### 100. What is the relationship between the type of exception and the information it contains? 

a) The type of exception and the information it contains are unrelated.

b) **```The type of exception determines the information it contains.```**
_Correct. The type of exception determines the information it contains._

c) The information contained in an exception determines the type of exception.

#### 101. What is code debugging? 

a) A process to identify code syntax errors during the build process.

b) **```A process to isolate and fix issues in code logic.```**
_Correct. Code debugging involves isolating and fixing logic issues in code._

c) A process to verify that code builds and runs without errors.

#### 102. What is a debugger? 

a) **```A software tool used to observe and control the execution flow of a program.```**
_Correct. A debugger is a software tool uses an analytical approach to observe and control the execution flow of a program._

b) A program that generates code automatically based on user input.

c) A tool that helps developers write their code faster.

#### 103. What happens when execution of a C# application results in a system error? 

a) The program crashes and closes.

b) **```The .NET runtime creates and throws an exception.```**
_Correct. The .NET runtime throws an exception when a C# application generates a system error._

c) The error is silently ignored and the program continues to run.

#### 104. What is the purpose of catching an exception in C#? 

a) To ignore the errors that occur in a program.

b) To generate other exceptions in a program.

c) **```To take corrective action when an error occurs in a program.```**
_Correct. The purpose of catching an exception is to take corrective action when an error occurs._

#### 105. What is the relationship between the type of exception and the information it contains? 

a) **```The type of exception determines the information it contains.```**
_Correct. The type of exception determines the information it contains._

b) The type of exception and the information it contains are unrelated.

c) The information contained in an exception determines the type of exception.

#### 106. Which section of the Run menu enables a developer to edit or add launch configurations? 

a) The start and stop applications section.

b) **```The launch configurations section.```**
_Correct. The configurations section of the Run menu provides access to edit or add launch configurations in Visual Studio Code._

c) The install debuggers section.

#### 107. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

a) VARIABLES section.

b) **```CALL STACK section.```**
_Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application._

c) WATCH section.

#### 108. Which button on the Debug toolbar can be used resume normal code execution? 

a) **```The Pause/Continue button.```**
_Correct. The Pause/Continue button on the Debug toolbar can be used to pause execution when the code is running and continue when code execution has been paused._

b) The Step Over button.

c) The Restart button.

#### 109. Which section of the Run menu enables the developer to set breakpoints on code lines? 

a) The Manage Breakpoints section.

b) The Start and stop applications section.

c) **```The Set Breakpoints section.```**
_Correct. The Set Breakpoints section of the Run menu enables the developer to set breakpoints on code lines._

#### 110. What capability does the "More" dropdown on the right side of the Debug toolbar provide? 

a) **```An option to disconnect the debugger.```**
_Correct. The "More" dropdown on the right side of the Debug toolbar enables a developer to disconnect the debugger from the current process_

b) An option to edit launch configurations.

c) An option to manage breakpoints.

#### 111. Which of the following can be used to configure and start a debug session? 

a) The Debug toolbar.

b) The VARIABLES section of the RUN AND DEBUG view.

c) **```The Run and Debug controls panel.```**
_Correct. The Run and Debug controls panel is used to configure and start a debug session from the RUN AND DEBUG view in Visual Studio Code._

#### 112. Which of the following options can be used set a breakpoint in Visual Studio Code? 

a) **```Left-click in the column to the left of a line number in the code editor.```**
_Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking._

b) Select Toggle Breakpoint on the Edit menu.

c) Right-click in the middle of a line of code, and then select Toggle Breakpoint.

#### 113. How can a developer disable a breakpoint in Visual Studio Code? 

a) Click Remove Breakpoint on the Run menu.

b) **```Right-click the red dot to the left of the line number and select Disable Breakpoint.```**
_Correct. A breakpoint can be disabled by right-clicking the red dot that represents a breakpoint and then selecting Disable Breakpoint._

c) Left-click the red dot to the left of the line number.

#### 114. What happens when a developer disables a breakpoint in Visual Studio Code? 

a) The breakpoint is removed from the code entirely.

b) **```The breakpoint is skipped over during debugging.```**
_Correct. When a breakpoint is disabled, it is skipped over during debugging. In the user interface, the red dot representing the breakpoint is changed to a grey dot._

c) The breakpoint will only be triggered if dot to the left of the line number is changed to a grey dot.

#### 115. What is a conditional breakpoint in Visual Studio Code? 

a) **```A breakpoint that only triggers when a specified condition is met.```**
_Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met._

b) A breakpoint that is triggered every time the code is run.

c) A breakpoint that is only visible in the editor and doesn't affect debugging.

#### 116. How can a developer create a conditional breakpoint in Visual Studio Code? 

a) Left-click in the column to the left of a line number in the code editor.

b) Select Toggle Conditional Breakpoint on the Run menu.

c) **```Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.```**
_Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint._

#### 117. A developer updates a launch configuration. What is the name attribute used for? 

a) To specify the type of debugger used in a launch configuration.

b) To specify the request type of a launch configuration.

c) **```To specify the display name for a configuration.```**
_Correct. The name attribute specifies the display name for the configuration. The value assigned to name appears in the controls panel at the top of the RUN AND DEBUG view._

#### 118. A developer is working on a launch configuration. What is the preLaunchTask attribute used for? 

a) To specify the path of the application dll or .NET Core host executable to launch.

_b) **```To specify a task to run before debugging your program.```**
Correct. The preLaunchTask attribute specifies a task to run before debugging the program. The task itself can be found in the tasks.json file, which is in the .vscode folder along with the launch.json file. Specifying a prelaunch task of build runs a dotnet build command before launching the application._

c) To specify the type of console that's used when the application is launched.

#### 119. What is the console attribute of a launch configuration used for? 

a) Specifies the working directory of the target process.

b) Specifies the type of debugger to use for this launch configuration.

c) **```Specifies the type of console that's used when the application is launched.```**
_Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole._

#### 120. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

a) The VARIABLES section.

b) **```The CALL STACK section.```**
_Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application._

c) The WATCH section.

#### 121. Which of the following options can be used to set a breakpoint in Visual Studio Code? 

a) **```Left-click in the column to the left of a line number in the code editor.```**
_Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking._

b) Select Toggle Breakpoint on the Edit menu.

c) Right-click in the middle of a line of code, and then select Toggle Breakpoint.

#### 122. How can a developer disable a breakpoint in Visual Studio Code? 

a) Click Remove Breakpoint on the Run menu.

b) **```Right-click the red dot to the left of the line number and select Disable Breakpoint.```**
_Correct. A breakpoint can be disabled by right-clicking the red dot that represents a breakpoint and then selecting Disable Breakpoint._

c) Left-click the red dot to the left of the line number.

#### 123. What is a conditional breakpoint in Visual Studio Code? 

a) **```A breakpoint that only triggers when a specified condition is met.```**
_Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met._

b) A breakpoint that is triggered every time the code is run.

c) A breakpoint that is only visible in the editor and does not affect debugging.

#### 124. How can a developer create a conditional breakpoint in Visual Studio Code? 

a) Left-click in the column to the left of a line number in the code editor.

b) Select Toggle Conditional Breakpoint on the Run menu.

c) **```Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.```**
_Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint._

#### 125. In a launch configuration file, what is the console attribute used for? 

a) Specifies the working directory of the target process.

b) Specifies the type of debugger to use for this launch configuration.

c) **```Specifies the type of console that's used when the application is launched.```**
_Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole._

#### 126. Which of the following answer choices lists the C# keywords used for exception handling? 

a) try, catch, and finally.

b) **```try, catch, finally, and throw.```**
_Correct. The try, catch, finally, and throw keywords are used for exception handling in C#._

c) try, catch, and throw.

#### 127. What does the try code block contain? 

a) The code that cleans up resources and is executed whether an exception occurs or not.

b) The code that throws an exception object.

c) **```The code that may cause an exception.```**
_Correct. The try code block contains the guarded code that may cause an exception._

#### 128. What is the purpose of the catch code block? 

a) To clean up any resources that are allocated in a try block.

b) **```To handle the exception, log it, or ignore it.```**
_Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it._

c) To execute code that may cause an exception.

#### 129. What is the purpose of the finally block? 

a) To execute code that may cause an exception.

b) To handle the exception, log it, or ignore it.

c) **```To clean up any resources that are allocated in a try block.```**
_Correct. The finally block is often used to clean up any resources that are allocated in a try block. The finally code block contains code that executes whether an exception occurs or not._

#### 130. When is an ArrayTypeMismatchException exception thrown? 

a) An ArrayTypeMismatchException exception is thrown when an attempt is made to divide an integral value by zero.

b) An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.

c) **```An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.```**
_Correct. The ArrayTypeMismatchException exception is thrown when an attempt is made to store an element of the wrong type within an array._

#### 131. When is a DivideByZeroException exception thrown? 

a) **```A DivideByZeroException exception is thrown when an attempt is made to divide an integral value by zero.```**
_Correct. A DivideByZeroException is thrown when trying to divide an integer or Decimal number by zero._

b) A DivideByZeroException exception is thrown when an attempt is made to index an array outside the bounds of the array.

c) A DivideByZeroException exception is thrown when an attempt is made to store a value of one type in an array of another type.

#### 132. When is an IndexOutOfRangeException exception thrown? 

a) An IndexOutOfRangeException exception is thrown when an attempt is made to divide an integral value by zero.

b)**```An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.```**
_Correct. An IndexOutOfRangeException exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds._

c)An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

#### 133. When is an InvalidCastException exception thrown? 

a) An InvalidCastException exception is thrown when an attempt is made to divide an integral value by zero.

b) An InvalidCastException exception is thrown when an attempt is made to store a value of one type in an array of another type.

c) **```An InvalidCastException exception is thrown when attempting an invalid casting or explicit conversion.```**
_Correct. An InvalidCastException exception is thrown when attempting an invalid casting or explicit conversion._

#### 134. When is a NullReferenceException exception thrown? 

a) A NullReferenceException exception is thrown when attempting an invalid casting or explicit conversion.

b) A NullReferenceException exception is thrown when an attempt is made to store a value of one type in an array of another type.

c) **```A NullReferenceException exception is thrown when attempting to access a member on a type whose value is null.```**
_Correct. A NullReferenceException exception is thrown when attempting to access a member on a type whose value is null._

#### 135. What does the try code block contain? 

a) The code that cleans up resources and is executed whether an exception occurs or not.

b) The code that throws an exception object.

c) **```The code that may cause an exception.```**
_Correct. The try code block contains the guarded code that may cause an exception._

#### 136. What is the purpose of the catch code block? 

a) To clean up any resources that are allocated in a try block.

b) **```To handle the exception, log it, or ignore it.```**
_Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it._

c) To execute code that may cause an exception.

#### 137. When is an IndexOutOfRangeException exception thrown? 

a) An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

b) An IndexOutOfRangeException exception is thrown when attempting an invalid casting or explicit conversion.

c) **```An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.```**
_Correct. An IndexOutOfRangeException exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds._

#### 138. When is an ArrayTypeMismatchException exception thrown? 

a) **```An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.```**
_Correct. The ArrayTypeMismatchException exception is thrown when an attempt is made to store an element of the wrong type within an array._

b) An ArrayTypeMismatchException exception is thrown when attempting to access a member on a type whose value is null.

c) An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.

#### 139. What is the name of the base class that all derived exception types inherit from? 

a) Object.

b) System.

c) **```Exception.```**
_Correct. In C#, System.Exception is the base class that all derived exception types inherit from._

#### 140. Which property of an exception object can be used to determine where an error occurred? 

a) InnerException.

b) **```StackTrace.```**
_Correct. The StackTrace property contains a stack trace that can be used to determine where an error occurred._

c) TargetSite.

#### 141. What is the recommended approach for catching exceptions in C#? 

a) Catch any type of exception without specifying an object argument.

b) **```Catch only the exceptions that your code knows how to recover from.```**
_Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from._

c) Catch only the exceptions that are not derived from System.Exception.

#### 142. What is the name of the specific exception type that occurs when attempting to divide by zero in C#? 

a) ArithmeticException.

b) InvalidCastException.

c) **```DivideByZeroException.```**
_Correct. In C#, the specific exception type that occurs when attempting to divide by zero is DivideByZeroException._

#### 143. What is the purpose of the StackTrace property of an exception object? 

a) **```To track the origin of the exception.```**
_Correct. The StackTrace property is often used to track the origin of the exception._

b) To configure the properties of the exception.

c) To throw the exception object.

#### 144. Which of the following code lines provides an example of customizing an exception with contextual information? 

a) Code: throw new FormatException();.

b) **```Code: ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");.```**
_Correct. This code sample demonstrates how to create an exception object with a custom Message property._

c) Code: ArgumentNullException argumentNullException = new ArgumentNullException();.

#### 145. A developer needs to create and throw an exception in a C# application. Which of the following descriptions is correct? 

a) The exception type shouldn't match the intended purpose of the exception.

b) **```The exception type that they create depends on the coding issue.```**
_Correct. The exception type created depends on the coding issue and should match the intended purpose of the exception as closely as possible._

c) The process for throwing an exception object involves using the catch keyword.

#### 146. When should a method throw an exception? 

a) A method should throw an exception when the method can complete its intended purpose.

b) **```A method should throw an exception when the method can't complete its intended purpose.```**
_Correct. Methods should throw an exception whenever they can't complete their intended purpose._

c) A method should throw an exception when an exception type matches the intended purpose of the method.

#### 147. A developer needs to create an exception object that includes a specific Message property. Which of the following statements is correct? 

a) The Message property of an exception is writable.

b) The Message property shouldn't explain the reason for the exception.

c) **```The Message property should explain the reason for the exception.```**
_Correct. The Message property of an exception should explain the reason for the exception. Since Message is a read-only property, it must be assigned when instantiating the exception object._

#### 148. What is the purpose of catching an exception in C#? 

a) To ignore the errors that occur in a program.

b) To generate other exceptions in a program.

c) **```To take corrective action when an error occurs in a program.```**
_Correct. The purpose of catching an exception is to take corrective action when an error occurs._

#### 149. What is the relationship between the type of exception and the information it contains? 

a) The type of exception and the information it contains are unrelated.

b) **```The type of exception determines the information it contains.```**
_Correct. The type of exception determines the information it contains._

c) The information contained in an exception determines the type of exception.

#### 150. What is a conditional breakpoint in Visual Studio Code? 

a) **```A breakpoint that only triggers when a specified condition is met.```**
_Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met._

b) A breakpoint that is triggered every time the code is run.

c) A breakpoint that is only visible in the editor and doesn't affect debugging.

#### 151. When is an ArgumentOutOfRangeException exception thrown? 

a) An ArgumentOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.

b) **```An ArgumentOutOfRangeException exception is thrown when the value of an argument is outside the allowable range of values as defined by the method.```**
_Correct. An ArgumentOutOfRangeException exception should only be thrown when the value of an argument is outside the allowable range of values as defined by the invoked method._

c) An ArgumentOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

#### 152. What is the recommended approach for catching exceptions in C#? 

a) Catch any type of exception without specifying an object argument.

b) **```Catch only the exceptions that your code knows how to recover from.```**
_Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from._

c) Catch only the exceptions that aren't derived from System.Exception.

#### 153. How can a developer create a conditional breakpoint in Visual Studio Code? 

a) Left-click in the column to the left of a line number in the code editor.

b) Select Toggle Conditional Breakpoint on the Run menu.

c) **```Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.```**
_Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint._

#### 154. In a launch configuration file, what is the console attribute used for? 

a) Specifies the working directory of the target process.

b) Specifies the type of debugger to use for this launch configuration.

c) **```Specifies the type of console that's used when the application is launched.```**
_Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole._

#### 155. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

a) The VARIABLES section.

b) **```The CALL STACK section.```**
_Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application._

c) The WATCH section.

#### 156. Which of the following options can be used set a breakpoint in Visual Studio Code? 

a) **```Left-click in the column to the left of a line number in the code editor.```**
_Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking._

b) Select Toggle Breakpoint on the Edit menu.

c) Right-click in the middle of a line of code, and then select Toggle Breakpoint.
