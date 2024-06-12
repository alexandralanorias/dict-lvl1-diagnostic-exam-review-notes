# Program Simulation

- action of a situation or process of program you have created.

# Loop

- it is a **programming structure** that repeats a sequence of instructions until a specific condition is met.
    - 3 common kinds of loop used in the examination
        - `for`
        - `while`
        - `do while`

## `for` Loop

- `for` loop provides a concise way of writing the loop structure. Unlike a `while` loop, a `for` statement consumes the initialization, condition and increment/decrement in on line thereby providing a shorter, easy t debug structure of looping.
    
    ```cpp
    int main() {
    	for(int start = 0; start < 10; start++) {
    		cout << "My name is Alexandra Lanorias." << endl;
    	}
    	
    	return 0;
    }
    ```
    
    > This code is a simple C++ program that outputs the text "My name is Alexandra Lanorias." ten times. Here's a step-by-step explanation of what each part of the code does:
    > 
    > 1. **int main()**: This is the main function where the execution of the program begins.
    > 2. **for(int start = 0; start < 10; start++)**: This is a `for` loop that initializes an integer variable `start` to 0 and iterates as long as `start` is less than 10. After each iteration, the variable `start` is incremented by 1.
    > 3. **cout << "My name is Alexandra Lanorias." << endl;**: Within the loop, this statement is executed during each iteration. It uses the `cout` object from the `iostream` library to print the text "My name is Alexandra Lanorias." followed by a newline character (`endl`).
    > 4. **return 0;**: This statement indicates that the program has successfully completed its execution and returns 0 to the operating system.
    > 
    > When the program runs, the `for` loop executes 10 times, so the string "My name is Alexandra Lanorias." is printed 10 times, each on a new line.
    > 

## `while` Loop

- Same like previous loop mentioned above. It checks condition before entering loop but not as brief as the `for` loop.
    
    ```cpp
    int main() {
    	int start = 0;
    	
    	while(start < 10) {
    		cout << "We are now using a while loop." << endl;
    		start++;
    	}
    	
    	return 0;
    }
    ```
    
    > This code is a C++ program that outputs the text "We are now using a while loop." ten times. Here's a step-by-step explanation of what each part of the code does:
    > 
    > 1. **int main()**: This is the main function where the execution of the program begins.
    > 2. **int start = 0;**: This line declares an integer variable `start` and initializes it to 0.
    > 3. **while(start < 10)**: This is a `while` loop that continues to execute as long as the condition `start < 10` is true.
    > 4. **cout << "We are now using a while loop." << endl;**: Within the loop, this statement uses the `cout` object from the `iostream` library to print the text "We are now using a while loop." followed by a newline character (`endl`).
    > 5. **start++;**: This statement increments the value of `start` by 1 after each iteration of the loop.
    > 6. **return 0;**: This statement indicates that the program has successfully completed its execution and returns 0 to the operating system.
    > 
    > When the program runs, the `while` loop executes 10 times, so the string "We are now using a while loop." is printed 10 times, each on a new line. The loop increments `start` after each print, and when `start` reaches 10, the loop condition `start < 10` becomes false, and the loop terminates.
    > 

## `do while` Loop

- Like the other loops. This one is different in terms of prioritizing. It checks condition when coming out from loop.
    
    ```cpp
    int main() {
    	int start = 0;
    	
    	do {
    		cout << "We are now using do while." << endl;
    		start++;
    	} while(start < 10);
    	
    	return 0;
    }
    ```
    
    > This code is a C++ program that outputs the text "We are now using do while." ten times. Here is a step-by-step explanation of what each part of the code does:
    > 
    > 1. **int main()**: This is the main function where the execution of the program begins.
    > 2. **int start = 0;**: This line declares an integer variable `start` and initializes it to 0.
    > 3. **do { ... } while(start < 10);**: This is a `do-while` loop. The code inside the `do` block is executed first, and then the condition `start < 10` is checked. If the condition is true, the loop repeats. This ensures that the code inside the `do` block is executed at least once, even if the condition is false from the start.
    > 4. **cout << "We are now using do while." << endl;**: Within the `do` block, this statement uses the `cout` object from the `iostream` library to print the text "We are now using do while." followed by a newline character (`endl`).
    > 5. **start++;**: This statement increments the value of `start` by 1 after each iteration of the loop.
    > 6. **} while(start < 10);**: This checks the condition `start < 10`. If the condition is true, the loop executes again. If false, the loop terminates.
    > 7. **return 0;**: This statement indicates that the program has successfully completed its execution and returns 0 to the operating system.
    > 
    > When the program runs, the `do` block is executed first, printing "We are now using do while." and incrementing `start` by 1. This process repeats until `start` is no longer less than 10. Therefore, the text "We are now using do while." is printed 10 times, each on a new line.
    > 

# `if` Condition

- It is a programming conditional statement that, if proved true, performs a function or displays information. If proved false, performs no display and proceeds to the next line.

## Commonly Used Operators

- Arithmetic Operators
    - +    — Addition
    - -      — Subtraction
    - *     — Multiplication
    - /     — Division
    - %    — Modulus
    
    ```csharp
    #include <iostream>
    
    int main() {
        int num1 = 10, num2 = 5, equiv = 0;
        
        equiv = num1 + num2;
        std::cout << "10 + 5 = " << equiv << std::endl;
    
        // To mimic Console.ReadKey in C#, which waits for a key press, we can use cin.get()
        std::cin.get();
        return 0;
    }
    ```
    
    > This C++ code performs a simple arithmetic operation and displays the result. Here’s a detailed explanation of each part of the code:
    > 
    > 
    > ### Code Explanation
    > 
    > ```cpp
    > #include <iostream>
    > 
    > ```
    > 
    > - This line includes the iostream library, which is necessary for input and output operations. It allows the program to use `std::cout` for output and `std::cin` for input.
    > 
    > ```cpp
    > int main() {
    > 
    > ```
    > 
    > - This is the main function where the program execution begins. In C++, `int main()` is the standard entry point for the program.
    > 
    > ```cpp
    > int num1 = 10, num2 = 5, equiv = 0;
    > 
    > ```
    > 
    > - These lines declare and initialize three integer variables:
    >     - `num1` is initialized to 10.
    >     - `num2` is initialized to 5.
    >     - `equiv` is initialized to 0.
    > 
    > ```cpp
    > equiv = num1 + num2;
    > 
    > ```
    > 
    > - This line calculates the sum of `num1` and `num2` and assigns the result to `equiv`. Here, `equiv` becomes 15 because 10 + 5 = 15.
    > 
    > ```cpp
    > std::cout << "10 + 5 = " << equiv << std::endl;
    > 
    > ```
    > 
    > - This line outputs the text "10 + 5 = " followed by the value of `equiv` to the console. `std::cout` is the standard output stream in C++, and `std::endl` is used to insert a newline character, effectively ending the line.
    > 
    > ```cpp
    > std::cin.get();
    > 
    > ```
    > 
    > - This line waits for a key press before the program continues or exits. It mimics the `Console.ReadKey` method in C#, which waits for the user to press a key before closing the console window. This is useful to prevent the console window from closing immediately after displaying the output, especially when running the program in an environment where the console window closes automatically (e.g., double-clicking the executable in Windows).
    > 
    > ```cpp
    > return 0;
    > 
    > ```
    > 
    > - This line indicates that the program has completed successfully. Returning 0 from the `main` function is a convention in C++ that signals successful completion of the program to the operating system.
    > 
    > ### Summary
    > 
    > When this program runs, it:
    > 
    > 1. Declares and initializes three integer variables.
    > 2. Computes the sum of `num1` and `num2`, storing the result in `equiv`.
    > 3. Prints "10 + 5 = 15" to the console.
    > 4. Waits for the user to press a key before terminating.
    > 
    > This basic program demonstrates variable initialization, arithmetic operations, output to the console, and basic input handling in C++.
    > 
- Relational Operators
    - <     — less than
    - >     — greater than
    - ≤     — less than or equal to
    - ≥     — greater than or equal to
    - ==  — equal to
    - !=    — not equal to

13:15