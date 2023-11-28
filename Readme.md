# Project Name

This is a technical challenge from encora company.

which is about String Manipulation: Sort Strings.

Here is a brief summary

You are given N strings.
For each string, perform the following sorting operations:
1.  Reorder the alphabets in the string according to their frequency, i.e., the alphabet with the highest frequency is first.
2. If two or more alphabets have the same frequency, the lexicographically smallest alphabet comes first.


## Description

Function Description
In the provided code snippet, implement the provided sortingOperations (...) method using the variables to print the output. You can write your code in the space below the phrase -WRITE YOUR LOGIC HERE".

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output

## What I did?

SortingOperations is the method that does the process of sorting the strings that are passed, basically receives two parameters one called N which is the number of String to process and the other is the list of such string, it returns a list of string sorted according to the specifications of the challenge, it is static because it is within a static method (it is a console application).

### Steps in the process:

1)	I declared a string list and made its instance immediately and called it result, the purpose of this list is to store all the strings that have been successfully sort and return it as a response.
2)	I created a FOR loop to only iterate the number of times the size of the string.
3)	I declare a string variable to store the first value of my list and start processing the strings in my list.
4)	Then I create a dictionary of type char and int, char to store the letters and int to store the frequencies of each letter within the string I am processing, I use linq to group by letters and then I assign each letter as Key within the Dictionary and each occurrence as the value with a Count() method
5)	Then I create a list of Char based on my dictionary and take all the letters sorted in a decending order to take the letter with the highest frequency number for this I use charFrecuency[c] then I do a subsequence order and convert it to list
6)	Then I create a variable called sortedString which is basically the string already formed again based on my char list that we created earlier and select all the considerations that are already sorted and repeated based on my charFrequency[c] and finally I convert it to ToArray() and store it in my result list


## Unit Test Explanation and Capture:

We send two strings in a list, as you can see the string number is the InputString count, in the ACT we call our SortingOperation function and send them the parameters.

Then we make some checks in the Assert multiple this to run the asserts at the same time, first check that the number of string is equal to the number expected, second that the number of string that our SortingOperation function answers is equal to the expected and finally compare the collections expected and those sent by our function.


