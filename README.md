# Learning C# from scratch
By Rafael Xolio

## Introduction
This repository contains examples for learning how to coding in C# from scratch.

## Prerequisites
- To have installed Visual Studio 2019 at least or Visual Studio Code.


## Visual Studio Code

### Install Visual Studio Code

1. Download from [code.visualstudio.com](https://code.visualstudio.com/)
2. To install follow instructions from any of next links
   - https://code.visualstudio.com/docs/setup/windows
   - https://learn.microsoft.com/en-us/training/modules/install-configure-visual-studio-code/2-exercise-download-install-visual-studio-code

### Visual Studio Interface
![image](https://github.com/user-attachments/assets/01ebd1e4-c625-44e4-bb6b-da377fc4b17d)

### The .NET SDK and .NET Runtime
.NET is a cross-platform, open-source developer platform that's used to develop different types of applications. 

**.NET Runtime**
- The .NET runtime is the code library that's required to run your C# applications.
- .NET runtime referred to as the Common Language Runtime, or CLR.
- The .NET runtime isn't required to write your C# code, but it's required to actually run your C# applications.

**.NET SDK**
- Visual Studio Code uses the .NET SDK and C# extensions to provide a development environment for writing, running, and debugging C# applications.

### Extensions
- Extensions are add-ons that provide additional functionality to Visual Studio Code.
- There are language extensions, theme extensions, and extensions that add new features to Visual Studio Code.
- Visual Studio Code supports the development of C# applications using C# language extensions and the .NET Software Development Kit (SDK).

#### Install C# Extension
To install the C# Dev Kit extension for Visual Studio Code, complete the following steps:

1. On the Activity bar, select Extensions.
2. In the Search Extensions in Marketplace textbox, enter C#. Entering "C#" filters the list of extensions to show only the extensions that have something to do with C# coding.
3. In the filtered list of available extensions, select the extension labeled "C# Dev Kit - Official C# extension from Microsoft" published by Microsoft.
   
   ![image](https://github.com/user-attachments/assets/faca9844-285c-4a45-a127-7960277d32d7)

5. Select Install.
6. Notice that installing the C# Dev Kit installs the following extensions:
   - .NET Install Tool. This extension installs and manages different versions of the .NET SDK and Runtime.
   - C# - Base language support for C#.
   - C# Dev Kit - Official C# extension from Microsoft

### Install IntelliCode for C#

1. On the Activity bar, select Extensions.
2. In the Search Extensions in Marketplace textbox, enter IntelliCode for C#
3. In the filtered list of available extensions, select the extension labeled IntelliCode for C# Dev Kit - AI-assisted development for C# Dev Kit published by Microsoft.
   
![image](https://github.com/user-attachments/assets/2d562b95-23ac-44a2-b751-6ebee8f98dd9)

4. Select Install.

### Verify Dotnet version

1. Open a new Terminal
2. Run command dotnet --version

## Create your first console application

1. Run command ```dotnet new console -o path/projectname```
![image](https://github.com/user-attachments/assets/aa991c31-70e5-4d9a-8eef-2631cc2db8aa)

2. Implement changes and save.
3. Build project ```$dotnet build```
4. Run the project ```$dotnet run```

## .NET Class Library
- Which of the following tools is required to run command line interface commands such as dotnet run?
- C# data types (such as string and int) are actually made available through classes in the .NET Class Library.

## Stateful versus stateless methods
- **Stateless** methods are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.
- **Stateful** (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.
- However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

## Methods
- Methods might accept no parameters or multiple parameters, depending on how they were designed and implemented.
- When passing in multiple parameters, separate them with a , symbol.
- Method parameters are variables used inside the method.
- The method definition specifies the names and types of any parameters that are required.
- When a caller invokes the method, the calling statement provides concrete values, called arguments, for each parameter.
- Methods might return a value when they complete their task, or they might return nothing (void).
- Overloaded methods support several implementations of the method, each with a unique method signature (the number of parameters and the data type of each parameter).
- IntelliSense can help write code more quickly. It provides a quick reference to methods, their return values, their overloaded versions, and the types of their parameters.
- learn.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work.

## Array
- C# arrays allow you to store sequences of values in a single data structure.
- Arrays can be used to store multiple values of the same type in a single variable.
- In other words, imagine a single variable that can hold many values. Once you have a single variable that stores all the values, you can sort the values, reverse the order of the values, loop through each value and inspect it individually, and so on.
- An array is a sequence of individual data elements accessible through a single variable name.
- You use a zero-based numeric index to access each element of an array.

### Declaring arrays

```cs
   string[] orderIDs = new string[3];

   orderIDs[0] = "A123";
   orderIDs[1] = "B456";
   orderIDs[2] = "C789";
   // orderIDs[3] = "D000";

   Console.WriteLine($"First: {orderIDs[0]}");
   Console.WriteLine($"Second: {orderIDs[1]}");
   Console.WriteLine($"Third: {orderIDs[2]}");

   orderIDs[0] = "F000";

   Console.WriteLine($"Reassign First: {orderIDs[0]}");
```

### Initialize an array

```c
   string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
```

### Lenght of an array
```cs
   string[] orderIDs = { "A001", "B002", "C003" };

   Console.WriteLine($"Lenght: {orderIDs.Length}");
```

### Looping arrays

- Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
- The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
- Use the ++ increment operator to add 1 to the current value of a variable.

```cs
   int[] inventory = { 200, 450, 700, 175, 250 };
   int sum = 0;
   int bin = 0;
   foreach (int items in inventory)
   {
       sum += items;
       bin++;
       Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
   }
   Console.WriteLine($"We have {sum} items in inventory.");

```

## Variables

### Variable name rules
There are some variable naming rules that are enforced by the C# compiler.

- Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
- Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields.
- Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
- Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

### Variable name conventions

- Variable names should use **camel case**, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.
- Variable names should be **descriptive** and meaningful in your application. 
- Variable names should be **one or more entire words** appended together. 
- Variable names **shouldn't include the data type** of the variable.

## Comments

- Use code comments to leave meaningful notes to yourself about the problem your code solves.
- Don't use code comments that explain how C# or the .NET Class Library works.
- Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, at which point you can delete the old code.
- Never trust comments. They may not reflect the current state of the code after many changes and updates.

```cs

// Loop through each blank orderID

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

```

## Decision Logic

Decision logic is used to establish alternative pathways through your code, where the decision about which path to follow is based on the evaluation of an expression.

### What is an expression?
An expression is any combination of values (literal or variable), operators, and methods that return a single value. A statement is a complete instruction in C#, and statements are comprised of one or more expressions.
```cs
if (myName == "Luiz")

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
```

### Evaluating equality and inequality
- When checking for equality, you'll locate the equality operator == between the two values being checked. If the values on either side of the equality operator are equivalent, then the expression will return true. Otherwise, it will return false.
- To check for inequality, you'll use the inequality operator != between the two values.

### Evaluating comparisons
When working with numeric data types, you might want to determine if a value is larger or smaller than another value. Use the following operators to perform these types of comparisons:

- Equal ==
- Inequal !=
- Greater than >
- Less than <
- Greater than or equal to >=
- Less than or equal to <=

### What is logical negation?
- The term "Logical Negation" refers to the unary negation operator !.
- Some people call this operator the "not operator".
- When you place the ! operator before a conditional expression (or any code that's evaluated to either true or false), it forces your code to reverse its evaluation of the operand.
- When logical negation is applied, the evaluation produces true , if the operand evaluates to false , and false , if the operand evaluates to true.
- Use the logical negation operator ! to evaluate the opposite of a given expression.
- Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.

```cs
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
```

### What is the conditional operator?
- The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false.
- The conditional operator is commonly referred to as the **ternary conditional operator**.
- You can use the conditional operator to reduce the size of your code, but you should ensure that the resulting code is easily readable.
- You can use the conditional operator when you need to return a value that's based on a binary condition. Your code will return the first option when the condition evaluates to true, and it will return the second option when the condition evaluates to false.

```cs
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```

## Data Types
There are many data types, but for starting level we'll focus on just a few for now:

| Type |  Description  | Example |
|:-----|:--------|------|
| **char**   |used for a single alphanumeric character | 'b' |
| **string**   |  used for words, phrases, or any alphanumeric data for presentation, not calculation  | "Hello" |
| **int**   | used for a whole number | 1 |
| **decimal**   | used for a number with a fractional component | 2.625, 12.3981m |
| **bool**   | used for a true/false value | true |


## Variables
A variable is a container for storing a type of value. Variables are temporary values you store in the computer's memory

```cs
string name;
int count;
```
**Considerations about variable names**

- Can contain alphanumeric characters and the underscore character.
- Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
- Must begin with an alphabetical letter or an underscore, not a number.
- They are case-sensitive, meaning that string Value; and string value; are two different variables.
- Must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.

**Coding recomendations**
- Use camel case convention. For example: ```string myVariable```
- Avoid to use underscore at the beginning.
- Use descriptive names. Avoid contractions or abbreviations.
- Don't include the data type on the name of the variable.

## Implicitly type
An implicitly typed local variable is created by using the var keyword followed by a variable initialization.
The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.

```cs
var message = "Hello world!";
```

## Formatting strings

### Escape character sequences
Use character escape sequences when you need to insert a special character into a literal string.

- \n sequence will add a new line
- \t sequence will add a tab
- \\" for double quotation mark
- \\ when you need to use a backslash in all other scenarios
- @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
- \u plus a four-character code to represent Unicode characters (UTF-16) in a string

```cs
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\test");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```
### Concatenate strings
To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.

```cs
string firstName = "Bob";
string message = "Hello " + firstName;
```
### String interpolation
String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions. 
An interpolation expression is indicated by an opening and closing curly brace symbol { }. You can put any C# expression that returns a value inside the braces. 
The literal string becomes a template when it's prefixed by the $ character.
```cs
string message = $"{greeting} {firstName}!";
```
**Using Verbatim literals**
```cs
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

## Math operations

### Basic Operations
- **Addition** + is the addition operator
- **Subtraction** - is the subtraction operator
- **Multiplication** * is the multiplication operator
- **Division** / is the division operator

```cs
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
```
### Casting numbers

Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.
To cast you add the cast operator before the value. 

```cs
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
```
### Determine the remainder after integer division
The modulus operator % tells you the remainder of int division. 
What you really learn from this is whether one number is divisible by another. 

```cs
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
```

### Order of operations
You can use the () symbols as the order of operations operators.

In math, PEMDAS is an acronym that helps to remember the order of operations. The order is:

- Parentheses (whatever is inside the parenthesis is performed first)
- Exponents (No operator on C#)
- Multiplication and Division (from left to right)
- Addition and Subtraction (from left to right)

### Increment and Decrement

To increment and/or decrement values, especially when you're writing looping logic or code that interacts with a data structure.

The += operator adds and assigns the value on the right of the operator to the value on the left of the operator
```cs
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
```
The ++ operator increments the value of the variable by 1. So, lines two and three in the following code snippet are the same:
```cs
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.
```

If you use the operator before the value as in ++value, then the increment will happen before the value is retrieved. Likewise, value++ will increment the value after the value has been retrieved.
```cs
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
```

## Decision Logic
Developers refer to the code that implements different execution paths as code branches.

### If Statement

- The most widely used code branching statement is the if statement.
- The if statement relies on a Boolean expression that is enclosed in a set of parentheses.
- If the expression is true, the code after the if statement is executed. If not, the .NET runtime ignores the code and doesn't execute it.
- The combination of if and else statements allows you to test for one condition, and then perform one of two outcomes.
- The code block for the if will be run when the Boolean expression is true, and the code block for the else will be run when the Boolean expression is false.
- You can nest if statements to narrow down a possible condition. However, you should consider using the if, else if, and else statements instead.
- Use else if statements to create multiple exclusive conditions.
- An else is optional, but it must always come last when included.

```cs
if (total > 14)
{
    Console.WriteLine("You win!");
}
```

### What is a Boolean expression?
A Boolean expression is any code that returns a Boolean value, either true or false. 
Other simple Boolean expressions can be created by using operators to compare two values. Operators include:

- ==, the "equals" operator, to test for equality
- >, the "greater than" operator, to test that the value on the left is greater than the value on the right
- <, the "less than" operator, to test that the value on the left is less than the value on the right
- >=, the "greater than or equal to" operator
- <=, the "less than or equal to" operator


## What is a code block?
A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }.

### Code Block
- A code block is one or more C# statements that define an execution path.
- The statements outside of a code block affect when, if, and how often that block of code is executed at run time.
- The boundaries of a code block are typically defined by squiggly braces, {}.

### Code blocks and variable scope
- When you declare a variable inside a code block, its visibility is local to that code block and that variable cannot be accessed outside of the code block.
- To ensure that a variable is visible both inside and outside of a code block, you must declare the variable prior to the code block (outside and above the code block).
- Ensure that variables are initialized before your code attempts to access them (for all potential code execution paths).
- 
### Variable scope 
- Refers to a variable's visibility to the other code in your application.
- A locally scoped variable is only accessible inside of the code block in which it's defined.
- If you attempt to access the variable outside of the code block, you'll get a compiler error.

```cs
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");
```

## Readability of single-line form if statements
When implementing an if statement that includes a single-statement code block, Microsoft recommends that you consider these conventions:
- Never use single-line form (for example: if (flag) Console.WriteLine(flag);
- Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
- Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
- If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, you can remove the curly braces of the code block and white space.
- Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif-else statement (either present or removed consistently).
- Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
- Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.

## Switch statement
- A switch statement is a C# selection statement that provides an alternative to an if-elseif-else branching construct.
- The switch statement provides advantages over an if-elseif-else construct when evaluating a single value against a list of known matching values.
- The selected switch section is chosen based on a pattern match with the statement's match expression.
- Use the switch statement when you have one value with many possible matches, each match requiring a branch in your code logic.
- A single switch section containing code logic can be matched using one or more labels defined by the case keyword.
- Use the optional default keyword to create a label and a switch section that will be used when no other case labels match.

```cs
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
```

## for Iteration Loops

- The for statement iterates through a code block a specific number of times.
- This level of control makes the for statement unique among the other iteration statements.

The for statement includes the following six parts:

- The for keyword.
- A set of parentheses that defines the conditions of for iteration. The parentheses contain three distinct parts, separated by the end of statement operator, a semi-colon.
- The first part defines and initializes the iterator variable. In this example: int i = 0. This section is referred to as the initializer.
- The second part defines the completion condition. In this example: i < 10. In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10. When i becomes equal to 10, the runtime stops executing the for statement's code block. The docs refer to this section as the condition.
- The third part defines the action to take after each iteration. In this case, after each iteration, i++ will increment the value of i by 1. The docs refer to this section as the iterator.
- Finally, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of i is referenced inside of the code block. The docs refer to this section as the body.
- The for iteration statement allows you to iterate through a block of code a specific number of times.
- The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parentheses: the initializer, condition, and iterator.
- It's common to use the for statement when you need to control how you want to iterate through each item in an array.
- If your code block has only one line of code, you can eliminate the curly braces and white space if you wish.

```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

## do-while and while statements

### What is the do-while statement?
- The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true.
- Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.

```cs Sintaxis
do
{
    // This code executes at least one time
} while (true);
```
- The flow of execution starts inside of the curly brace. The code executes at least one time, then the Boolean expression next to the while keyword is evaluated. If the Boolean expression returns true, the code block is executed again.

- The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
- The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
- The continue keyword to step immediately to the Boolean expression.


## Loops differences

- The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
- The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
- The do-while statement: conditionally executes its body one or more times.
- The while statement: conditionally executes its body zero or more times.


## Data types

A data type is a way a programming language defines how much memory to save for a value. There are many data types in the C# language to be used for many different applications and sizes of data.

- Values are stored as bits, which are simple on / off switches. Combining enough of these switches allows you to store just about any possible value.
- There are two basic categories of data types: value and reference types. The difference is in how and where the values are stored by the computer as your program executes.
- Simple value types use a keyword alias to represent formal names of types in the .NET Library.
- Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else. In comparison, variables of value types directly contain their data.

### Integral Type

- An integral type is a simple value type that represents whole numbers with no fraction (such as -1, 0, 1, 2, 3). The most popular in this category is the int data type.
- There are signed and unsigned numeric data types. Signed integral types use 1 bit to store whether the value is positive or negative.
- You can use the MaxValue and MinValue properties of numeric data types to evaluate whether a number can fit in a given data type.


#### Signed Integral Types
- A signed type uses its bytes to represent an equal number of positive and negative numbers.
```cs
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
```

```
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807
```

#### Unsigned Integral Types

An unsigned type uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
```cs
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
```
```
Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
```

### Floating Point types
- A floating point is a simple value type that represents numbers to the right of the decimal place. 
- You must consider the digits of precision each type allows. Precision is the number of value places stored after the decimal point.
- **float** and **double** values are stored internally in a binary (base 2) format, while **decimal** is stored in a decimal (base 10) format.
- Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.

```cs
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
```

```
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
```

## Reference types vs Value types

### Value Type
- A **value type** variable stores its values directly in an area of storage called the **stack**. 
- The **stack** is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). 
- When the stack frame has finished executing, the values in the stack are removed.
- Value types can hold smaller values and are stored in the stack. 

### Reference Type
- A **reference type** variable stores its values in a separate memory region called the heap. 
- The heap is a memory area that is shared across many applications running on the operating system at the same time.
- The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value.
- The .NET Runtime stores the value, and then returns the memory address to the variable. When your code uses the variable, the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.
- The string data type is also a reference type.
- Reference types can hold large values, and a new instance of a reference type is created using the new operator.
- Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
- Reference types include arrays, strings, and classes.

## Choosing correct data type

- int for most whole numbers
- decimal for numbers representing money
- bool for true or false values
- string for alphanumeric value
- byte: working with encoded data that comes from other computer systems or using different character sets.
- double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
- System.DateTime for a specific date and time value.
- System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

## Convert data

- Use a helper method on the data type
- Use a helper method on the variable
- Use the Convert class' methods
- Prevent a runtime error while performing a data conversion
- Perform an explicit cast to tell the compiler you understand the risk of losing data
- Rely on the compiler to perform an implicit cast when performing an expanding conversion
- Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal)
- Use the Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information

### Implicit Conversion

#### Widening conversion
- The term widening conversion means that you're attempting to convert a value from a data type that could hold less information to a data type that can hold more information.
- In this case, a value stored in a variable of type int converted to a variable of type decimal, doesn't lose information.
- When you know you're performing a widening conversion, you can rely on implicit conversion. The compiler handles implicit conversions.
```cs
int myInt = 3;
decimal myDecimal = myInt;
```

#### Narrowing conversion
- The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information. In this case, you may lose information such as precision (that is, the number of values after the decimal point). An example is converting value stored in a variable of type decimal into a variable of type int.
- When you know you're performing a narrowing conversion, you need to perform a cast. Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.


### Explicit Conversion
- To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert (example: (int)myDecimal).
- You perform an explicit conversion to the defined cast data type (int).
- Use cast to convert decimal to int.

```cs
int myInt = (int)myDecimal;
```

### Performing Data Conversions

#### Number to String
- Use ToString() to convert a number to a string
- Every data type variable has a ToString() method. 

```cs
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
```

#### String to Number
- Convert a string to an int using the Parse() helper method
- Most of the numeric data types have a Parse() method, which converts a string into the given data type.

```cs
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
```

#### Convert using the Convert class
The Convert class has many helper methods to convert a value from one type into another. 

```cs
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
```

#### Compare casting and converting 

- When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would be the same.
- When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If you changed the literal value to 1.499m, it would be rounded down to 1.

```cs
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
```
### Use TryParse()
The TryParse() method does several things simultaneously:

- It attempts to parse a string into the given numeric data type.
- If successful, it stores the converted value in an out parameter, explained in following section.
- It returns a bool to indicate whether the action succeeded or failed.

```cs
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
```

## Working with Arrays Methods
The Array class has methods that can manipulate the size and contents of an array.

### Sort() 
- Use the Sort() method to manipulate the order based on the given data type of the array.
- Sort() method of the Array class to sort the items in the array alphanumerically
  
```cs
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Sort(pallets);
```

### Reverse()
- Use the Reverse() method to flip the order of the elements in the array.
- Reverse() method of the Array class to reverse the order of items
  
```cs
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Reverse(pallets);
```

### Clear()
- The Array.Clear() method allows you to remove the contents of specific elements in your array and replace it with the array default value.
- For example, in a string array the element value cleared is replaced with null, when you clear a int array element the replacement is done with 0 (zero).

```cs
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Clear(pallets, 0, 2);
```

### Resize()
- The Array.Resize() allows you to add or remove elements to an Array.
- When Add elements, the new elements are added at the end of the current elements. The two new elements will be null until you assign a value to them.

```cs
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Resize(ref pallets, 6);
```

- When Remove elements, the removed elements are from the end.
```cs
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Resize(ref pallets, 3);
```
### ToCharArray()
-You use the ToCharArray() method to create an array of char, each element of the array has one character of the original string.
```cs
string value = "abc123";
char[] valueArray = value.ToCharArray();
```

### Join()
- Combine all of the chars into a new separated-value string.
```cs
string value = "abc123";
char[] valueArray = value.ToCharArray();
string result = String.Join(",", valueArray);
Console.WriteLine(result);
```

### Split
- You use the Split() method for variables of type string to create an array of strings.

```cs
string value = "This is an example, using split, from and string, separated by commas";
string[] arrayValues = value.Split(',');
foreach (var arrayValue in arrayValues)
{
    Console.WriteLine(arrayValue);
}
```

## Composite Formatting
- Composite formatting uses numbered placeholders within a string.
- At run time, everything inside the braces is resolved to a value that is also passed in based on their position.

```cs
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
```

### string interpolation?
- String interpolation is a technique that simplifies composite formatting.
- Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.
- In order for a string to be interpolated, you must prefix it with the $ directive.

```cs
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
```

### Formatting currency
Composite formatting and string interpolation can be used to format values for display given a specific language and culture. 
In the following example, the :C currency format specifier is used to present the price and discount variables as currency. Update your code as follows:
```cs
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
```

### Formatting numbers
When working with numeric data, you might want to format the number for readability by including commas to delineate thousands, millions, billions, and so on.
Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.

The N numeric format specifier makes numbers more readable. Update your code as follows:
```cs
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
```

### Formatting percentages
Use the P format specifier to format percentages and rounds to 2 decimal places. Add a number afterwards to control the number of values displayed after the decimal point. Update your code as follows:
Format percentages using the :P format specifier.

```cs
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
```

## String Methods

- Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
- Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
- Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
- Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
- Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

### String.IndexOf()
- You use the IndexOf() method to locate the position of one or more characters string inside a larger string. 
- IndexOf() gives you the first position of a character or string inside of another string.
- IndexOf() returns -1 if it can't find a match
- IndexOfAny() returns the first position of an array of char that occurs inside of another string.
  
```cs
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
```

### String.Substring()
- You use the Substring() method to return the part of the larger string that follows the character positions you specify.
- Substring() returns just the specified portion of a string, using a starting position and optional length.
  
```cs
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
```

### String.LastIndexOf()
- You also use LastIndexOf() to find the final location of a string within another string.
- LastIndexOf() returns the last position of a character or string inside of another string.


```cs
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
```
### String.Remove()
- You would typically use Remove() when there's a standard and consistent position of the characters you want to remove from the string.
- The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.

```cs
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
```

### String.Replace
- The Replace() method is used when you need to replace one or more characters with a different character (or no character). 
- The Replace() method is different from the other methods used so far, it replaces every instance of the given characters, not just the first or last instance.
- The Replace() method swaps all instances of a string with a new string.

```cs
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
```

////
1. To sort a string array, why is it important to use the String.Trim() method on each array element before sorting? 

Only string arrays with elements trimmed with String.Trim() can sort.

String.Trim() removes leading white space that would sort before numbers and letters.
Correct. String.Trim() removes both leading and trailing whitespace.


The array sort is noticeably faster using String.Trim() on each element.
2. Both foreach and for are good choices to iterate small single dimension arrays like {"cat", "fox", "dog", "snake", "eagle"}, but when is it best to use a for loop? 

When the elements have alphabetical sort order.

To perform a search on each element in the array.

To evaluate a specific range of elements.
Correct. A for is better when index ranges that aren't the first to the last index are required.

## Methods
- Create a method by declaring the return type, name, input parameters, and method body.
- Method names should clearly reflect the task the method performs.
- Use a method by calling its name and including parentheses ().
- When choosing a method name, it's important to keep the name concise and make it clear what task the method performs. 
- Method names should be Pascal case and generally shouldn't start with digits.
- Names for parameters should describe what kind of information the parameter represents. Consider the following method signatures:
- Methods can be used to quickly structure applications
- The return keyword can be used to terminate method execution
- Each step of a problem can often be translated into its own method
- Use methods to solve small problems to build up your solution

```cs
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);
```
### Use Parameters
- Information consumed by a method is called a parameter.
- The terms 'parameter' and 'argument' are often used interchangeably. However, 'parameter' refers to the variable in the method signature.
- The 'argument' is the value passed when the method is called.
- Parameters in a method work similar to variables.
- A parameter is defined by specifying the data type followed by the name of the parameter.
- Parameters are declared in the method signature, and the values for the parameters are provided by the method caller instead of being initialized inside the method itself.
- Multiple parameters are separated by commas.
- Methods can accept variable or literal arguments.

```cs
void CountTo(int max) 
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"{i}, ");
		}
	}
```

### Variable scope
- Variables declared inside of a method are only accessible to that method.
- Variables declared in top-level statements are accessible throughout the program.
- Methods don't have access to variables defined within different methods.
- Methods can call other methods.

### Methods with optional parameters

- Parameters are made optional by setting a default value in the method signature.
- A parameter becomes optional when it's assigned a default value
- Named arguments are specified with the parameter name, followed by a colon and the argument value.
- When combining named and positional arguments, you must use the correct order of parameters.

```cs
-- Named parameters
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);

-- Optional parameters
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
```

### Return type syntax
- Methods can return a value by including the return type in the method signature.
- Methods can return any data type, or they can return nothing at all.
- The return type must always be specified before the method name.
- Using void as the return type means the method only performs operations and doesn't return a value
- When a data type (such as int, string, bool, etc.) is used, the method performs operations and then returns the specified type upon completion.
- Inside the method, the keyword return is used to return the result.
- In void methods, you can also use the return keyword to terminate the method.

```cs
int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}
```

### Testing, Debugging, and Exception Handling

- The term "exception handling" refers to the process that a developer uses to manage those runtime exceptions within their code.
- Errors that occur during the build process are referred to as errors, and aren't part of the exception handling process.
- Software testing categories can be organized under the types of testing, the approaches to testing, or a combination of both.
- One way to categorize the types of testing is to split testing into Functional and Nonfunctional testing.
- The functional and nonfunctional categories each include subcategories of testing.
- For example, functional and nonfunctional testing could be divided into the following subcategories:

	- Functional testing - Unit testing - Integration testing - System testing - Acceptance testing
	- Nonfunctional testing - Security testing - Performance testing - Usability testing - Compatibility testing

#### Code debugging 
- Code debugging is a process that developers use to isolate an issue and identify one or more ways to fix it.
- The issue could be related to either code logic or an exception. Either way, you work on debugging your code when it isn't working the way you want it to.
- Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate.

#### Exception handling
- Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
- As you read earlier, errors that occur during the application runtime are referred to as exceptions. If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.
- Handling exceptions is definitely a responsibility of the developer. C# provides a way for you to "try" the code that you know might generate an exception, and a way for you to "catch" any exceptions that do occur.

#### Code debugging process
- The one approach that's commonly regarded as being the most successful is using a debugger.
- A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach.
- Debuggers help you isolate the cause of a bug and help you resolve it.
- A debugger connects to your code using one of two approaches:
  	- By hosting your program in its own execution process.
	- By running as a separate process that's attached to your running program.

 - The primary benefit of using a debugger is that you can watch your program running. You can follow program execution one line of code at a time. This approach minimizes the chance of guessing wrong.
 - The two most important features that come with almost all debuggers are:
	- Control of your program execution. You can pause your program and run it step by step, which allows you to see what code is executed and how it affects your program's state.
 	- Observation of your program's state. For example, you can look at the value of your variables and function parameters at any point during your code execution.

### What are exceptions?

- In C#, errors in the program at runtime are propagated through the program by using a mechanism called exceptions.
- Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
- Exceptions can be thrown by the .NET runtime or by code in a program.
- Exceptions are represented by classes derived from Exception.
- Each class identifies the type of exception and contains properties that have details about the exception.
- Exceptions are used in C# to propagate errors at runtime, and are represented by classes derived from the Exception class.
- Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
- When an exception is caught, code can access its contents and take corrective action to mitigate the error.
- The .NET runtime generates exceptions when it detects an error and the exception contains information about the type of error that occurred.

### VS Views
Configure and launch the debugger: The Run menu and RUN AND DEBUG view can both be used to configure and launch debug sessions.
Examine application state: The RUN AND DEBUG view includes a robust interface that exposes various aspects of your application state during a debug session.
Runtime execution control: The Debug toolbar provides high-level runtime controls during code execution.
The Visual Studio Code user interface can be used to configure, start, and manage debug sessions. The launch.json file contains the launch configurations for your application.
The Run menu provides easy access to common run and debug commands grouped into six sections.
The RUN AND DEBUG view provides access to runtime tools, including the Run and Debug controls panel. The sections of the RUN AND DEBUG view are VARIABLES, WATCH, CALL STACK, and BREAKPOINTS.
The Debug toolbar provides execution controls while your application is running such as pause/continue, step over, step into, step out, restart and stop.
The DEBUG CONSOLE is used to display messages from the debugger. The DEBUG CONSOLE can also display console output from your application.

#### Run menu
![image](https://github.com/user-attachments/assets/d0dd5a39-5167-4e80-ab9c-472b4c487ba6)
The Run menu provides menu options that are grouped into six sections.

Start and stop applications. This section of the menu includes options for starting and stopping code execution, with and without the debugger attached.

Launch configurations. This section of the menu provides access to examine or create launch configurations.

Runtime control. This section of the menu enables the developer to control how they want to advance through the code. Controls are enabled when execution has paused during a debug session.

Set Breakpoints. This section of the menu enables the developer to set breakpoints on code lines. Code execution pauses on Breakpoints during a debug session.

Manage Breakpoints. This section of the menu enables the developer to manage breakpoints in bulk rather than individually.

Install Debuggers. This section of the menu opens the Visual Studio Code EXTENSIONS view filtered for code debuggers.

#### Run and Debug view user interface
![image](https://github.com/user-attachments/assets/d91df074-47db-4fd6-9369-1454517cec35)

The RUN AND DEBUG view provides access to runtime tools that can be invaluable during the debug process.

Screenshot showing sections of the Visual Studio Code debugger user interface.

Run and Debug controls panel. Used to configure and start a debug session.

VARIABLES section. Used to view and manage variable state during a debug session.

WATCH section. Used to monitor variables or expressions. For example, you could configure an expression using one or more variables and watch it to see when a particular condition is met.

CALL STACK section. Used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application. The call stack shows which method is currently being executed, as well as the method or methods in the execution path that led to the current point of execution (current line of code).

BREAKPOINTS section. Displays the current breakpoint settings.

Debug toolbar. Used to control code execution during the debug process. This toolbar is only displayed while the application is running.

Current execution step. Used to identify the current execution step by highlighting it in the Editor. In this case, the current execution step is a breakpoint (breakpoints are marked with a red dot to the left of the line number).

DEBUG CONSOLE. Used to display messages from the debugger. The DEBUG CONSOLE panel is the default console for console applications and is able to display output from Console.WriteLine() and related Console output methods.

#### Controls panel for the Run and Debug view
![image](https://github.com/user-attachments/assets/643b7242-8c40-4887-8e13-aaf8efa88bd3)

At the top of the RUN AND DEBUG view, you can find the launch controls:

Screenshot showing the Controls panel for the Run and Debug view.

Start debugging. This button (a green arrow) is used to start a debug session.

Launch configurations. This dropdown menu provides access to launch configurations. The selected option is displayed.

Open 'launch.json'. This button (a gear shape) can be used to open the launch.json file, where you can edit the launch configuration if needed.

Views and More Actions. This button (an ellipsis) enables you to show/hide sections of the debug panel as well as the DEBUG CONSOLE panel.

#### Debug toolbar
![image](https://github.com/user-attachments/assets/8541bc3d-c304-4002-924c-1a8c125c42f4)

The Debug toolbar provides execution controls while your application is running.

Screenshot showing Debug toolbar user interface.

Pause/Continue. This button can be used to pause execution when the code is running and Continue when code execution has been paused.

Step Over. This button can be used to execute the next method as a single command without inspecting or following its component steps.

Step Into. This button can be used to enter the next method or code line and observe line-by-line execution steps.

Step Out. When inside a method, this button can be used to return to the earlier execution context by completing all remaining lines of the current method as though they were a single command.

Restart. This button can be used to terminate the current program execution and start debugging again using the current configuration.

Stop. This button can be used to terminate the current program execution.

In addition to six execution controls, the Debug toolbar provides a "handle" on the left side that enables the developer to reposition the toolbar, and a "More" dropdown on the right side that enables the developer to disconnect the debugger.

 Note

You can use the setting debug.toolBarLocation to control the location of the debug toolbar. It can be floating (the default), docked to the RUN AND DEBUG view, or hidden. A floating debug toolbar can be dragged horizontally and down to the Editor area.


### Breakpoint configuration

#### Set Breakpoint
- Breakpoints are used to specify where code execution pauses
- Visual Studio Code provides several ways to configure breakpoints in your code. For example:
	- Code Editor: You can set a breakpoint in the Visual Studio Code Editor by clicking in the column to the left of a line number.
	- Run menu: You can toggle a breakpoint on/off from the Run menu. The current code line in the Editor specifies where the Toggle Breakpoint action is applied.

 #### Remove Breakpoint
 - To remove a breakpoint, repeat the action used to set a breakpoint.
 - For example, click the red circle to the left of the line number or use the toggle breakpoint option on the Run menu.
 - ![image](https://github.com/user-attachments/assets/d1299dea-47ec-4870-b833-5eaae6cc8694)

#### All Breakpoint operations
- the Run menu provides options for performing bulk operations that act on all breakpoints:
	- Enable All Breakpoints: Use this option to enable all disabled breakpoints.
	- Disable All Breakpoints: Use this option to disable all breakpoints.
	- Remove All Breakpoints: Use this option to remove all breakpoints (both enabled and disabled breakpoints are removed).

#### Conditional breakpoints

- A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.
- For example, you can create a conditional breakpoint that pauses execution when a variable named numItems is greater than 5.
![image](https://github.com/user-attachments/assets/e1996c33-0559-4e17-85d0-d372467f84f3)
![image](https://github.com/user-attachments/assets/c003d3bf-16d2-4880-8e34-88127def6477)
![image](https://github.com/user-attachments/assets/6e4e0b4a-6c7d-4399-8b61-b1854a60b7f8)

#### Hit Count breakpoints 
- A 'hit count' breakpoint can be used to specify the number of times that a breakpoint must be encountered before it will 'break' execution.
- You can specify a hit count value when creating a new breakpoint (with the Add Conditional Breakpoint action) or when modifying an existing one (with the Edit Condition action).
- In both cases, an inline text box with a dropdown menu opens where you can enter the hit count value.

#### Logpoints
- A 'Logpoint' is a variant of a breakpoint that does not "break" into the debugger but instead logs a message to the console.
- Logpoints are especially useful for injecting logging while debugging production environments that cannot be paused or stopped.
- A Logpoint is represented by a "diamond" shaped icon rather than a filled circle. Log messages are plain text but can include expressions to be evaluated within curly braces ('{}').
- Logpoints can include a conditional 'expression' and/or 'hit count' to further control when logging messages are generated. 

#### Step Into and Step Out
- Use breakpoints to pause code execution during a debug session.
- Use Step Into from the Debug controls toolbar to observe the next executable code line. The Step Into button is used to advance to the next executable statement.
- Use Step Out from the Debug controls toolbar to advance through the current method and back to the code line that called the method.

### The launch configurations file
- You've already seen that Visual Studio Code uses the launch.json file to configure the debugger.
- The launch.json file includes one or more launch configurations in the configurations list. The launch configurations use attributes to support different debugging scenarios.
- Mandatory attributes:

name: The reader-friendly name assigned to the launch configuration.
type: The type of debugger to use for the launch configuration.
request: The request type of the launch configuration.

- Non-Mandatory Attributes
preLaunchTask: attribute specifies a task to run before debugging your program.
program: set to the path of the application dll or .NET Core host executable to launch. This property normally takes the form: ${workspaceFolder}/bin/Debug/<target-framework>/<project-name.dll>
cwd: specifies the working directory of the target process.
args: specifies the arguments that are passed to your program at launch. There are no arguments by default.
console: specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.

![image](https://github.com/user-attachments/assets/5f95e5fa-329f-4407-9984-5678bad33580)

```cs
"version": "0.2.0",
"configurations": [
    {
        "name": "Launch Project123",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject123",
        "program": "${workspaceFolder}/Project123/bin/Debug/net7.0/Project123.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project123",
        "console": "internalConsole",
        "stopAtEntry": false
    },
    {
        "name": "Launch Project456",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject456",
        "program": "${workspaceFolder}/Project456/bin/Debug/net7.0/Project456.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project456",
        "console": "internalConsole",
        "stopAtEntry": false
    }
]
```

### Sections of the Run and Debug view

#### VARIABLES section
Monitoring variable state is an important aspect of code debugging. Unexpected changes in variable state will often help to identify logic errors in your code.

The VARIABLES section organizes your variables by scope. The Locals scope displays the variables in the current scope (the current method).

#### WATCH section
What if you want to track a variable state across time or different methods? It can be tedious to search for the variable every time. That's where the WATCH section comes in handy.

#### CALL STACK section
Every time your code enters a method from another method, a call layer is added to the application's call stack. When your application becomes complex and you have a long list of methods called by other methods, the call stack represents the trail of method calls.

The CALL STACK section is useful when you're trying to find the source location for an exception or WATCH expression. 

#### BREAKPOINTS section
The BREAKPOINTS section displays the current breakpoint settings and can be used to enable or disable specific breakpoints during a debug session.

### Exception Handling Process
- Runtime errors in a C# application are managed using a mechanism called exceptions.
- Exceptions provide a structured, uniform, and type-safe way of handling both system level and application-level error conditions.
- Exceptions are generated by the .NET runtime or by the code in an application.

#### Common scenarios that require exception handling

- User input: Exceptions can occur when code processes user input. For example, exceptions occur when the input value is in the wrong format or out of range.
- Data processing and computations: Exceptions can occur when code performs data calculations or conversions. For example, exceptions occur when code attempts to divide by zero, cast to an unsupported type, or assign a value that's out of range.
- File input/output operations: Exceptions can occur when code reads from or writes to a file. For example, exceptions occur when the file doesn't exist, the program doesn't have permission to access the file, or the file is in use by another process.
- Database operations: Exceptions can occur when code interacts with a database. For example, exceptions occur when the database connection is lost, a syntax error occurs in a SQL statement, or a constraint violation occurs.
- Network communication: Exceptions can occur when code communicates over a network. For example, exceptions occur when the network connection is lost, a timeout occurs, or the remote server returns an error.
- Other external resources: Exceptions can occur when code communicates with other external resources. Web Services, REST APIs, or third-party libraries, can throw exceptions for various reasons. For example, exceptions occur due to network connections issues, malformed data, etc.

#### Exception handling blocks
Exception handling in C# is implemented by using the **try**, **catch**, and **finally** keywords
```cs
try
{   
   // try code block - code that may generate an exception
}
catch
{   
   // catch code block - code to handle an exception
}
finally
{   
   // finally code block - code to clean up resources
}
```

- The **try** code block contains the guarded code that may cause an exception.
- The **catch** code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it.
- The **finally** code block contains code that executes whether an exception occurs or not.
- The **throw** − A program throws an exception when a problem shows up. This is done using a throw keyword.

#### How are exceptions represented in code?
- Exceptions are represented in code as objects, which means they're an instance of a class.
- Exceptions are types, represented by classes that are all ultimately derived from System.Exception.

#### The Call Stack
- Call stack unwinding is the process that the .NET runtime uses when a C# program encounters an error. 
- The call layer that it needs is the method that has a catch clause that can handle the exception that occurred.
- When an exception occurs, the .NET runtime searches for the nearest catch clause that can handle it. The search starts with the method where the exception was thrown, and moves down the call stack if necessary.

#### Compiler-generated exceptions
The .NET runtime throws exceptions when basic operations fail. Here's a short list of runtime exceptions and their error conditions:

- **ArrayTypeMismatchException**: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
- **DivideByZeroException**: Thrown when an attempt is made to divide an integral value by zero.
- **FormatException**: Thrown when the format of an argument is invalid.
- **IndexOutOfRangeException**: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
- **InvalidCastException**: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
- **NullReferenceException**: Thrown when an attempt is made to reference an object whose value is null.
- **OverflowException**: Thrown when an arithmetic operation in a checked context overflows.

#### Properties of the Exception class:

- **Data**: The Data property holds arbitrary data in key-value pairs.
- **HelpLink**: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
- **HResult**: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
- **InnerException**: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
- **Message**: The Message property provides details about the cause of an exception.
- **Source**: The Source property can be used to access the name of the application or the object that causes the error.
- **StackTrace**: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
- **TargetSite**: The TargetSite property can be used to get the method that throws the current exception.

```cs
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}
```

```cs
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
```

#### Exception reference links
https://learn.microsoft.com/dotnet/standard/exceptions/exception-class-and-properties
https://learn.microsoft.com/dotnet/api/system.exception.

#### Create New Exception

Here are some common exception types that you might use when creating an exception:

- **ArgumentException** or **ArgumentNullException**: Use these exception types when a method or constructor is called with an invalid argument value or null reference.
- **InvalidOperationException**: Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
- **NotSupportedException**: Use this exception type when an operation or feature is not supported.
- **IOException**: Use this exception type when an input/output operation fails.
- **FormatException**: Use this exception type when the format of a string or data is incorrect.

```cs
ArgumentException invalidArgumentException = new ArgumentException();
```

- When creating and throwing an exception, the exception type must match the intended purpose of the exception as closely as possible.
- To throw an exception, you create an instance of an exception-derived class, configure its properties, and then use the throw keyword.
- When creating an exception object, it's important to provide clear error messages and additional information to help users correct the issue.

#### Things to avoid when throwing exceptions
The following list identifies practices to avoid when throwing exceptions:

- Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
- Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
- Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
- Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.
