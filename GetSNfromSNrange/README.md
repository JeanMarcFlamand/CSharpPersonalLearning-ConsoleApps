# Serial Number Range Search

## Introduction
This README.md file provides information about a C# function `getsnfromsnrange` that can be used to search for a serial number
within a specified range of serial numbers.

## Function Name
`getsnfromsnrange`

## Function Description
The `getsnfromsnrange` function takes two parameters: the serial number to search for
and the range of serial numbers to search within. It returns `True` if the serial number is found within the specified range, and `False` otherwise.

## Example
Suppose you want to search for the serial number `257` within the following range:
4-251, 255, 257-625, 627-660, 672-715
- The hyphen (-) is used to indicate a continuous range between two values.
- The comma (,) is used to separate different ranges or individual values.
- If there are unique values within the range, no range separator (-) is used.

- ## User Interaction
- This code will allow the user to input a serial number and range,
- Check if the serial number is within the range.
- And ask if they want to try another example or exit the program.
