The RemainderOutputBuilder Class library allows users to create an OutputBuilder class and pass in the desired upper limit, as well as the two different strings that they desire to be included with numbers divisible by 3 and text to be included with numbers divisible by 5. If a number is divisible by both 3 and five, then both passed in string values are included for that number.

The OutputBuilder Class includes a method named GetOutputs which uses the values that were passed into the constructor for the OutputBuilder class and returns a List of Outputs objects that has an int as well as a string (noted above).

This project also includes a Unit Test project (RemainderBuilderTests) that has a single test to make sure the value of 15 (which would be divisible by both 3 and 5) returns the expected result.

Inside of the OutputBuilder class I have included a method that checks for the upper limit value that a user can pass in to make sure that the value is within the range of 1 to int.Max and resets to either end if a value is passed in outside of that range.
