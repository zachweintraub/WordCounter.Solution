# Word Counter

#### Never wonder how many times a word occurs within a given phrase again!

#### By **Zach Weintraub**

## Description

A C# application that counts instances of a given word within a given string. The app determines case-sensitivity based on user preference.

| Specs | Sample Input | Sample Output |
| :-------------     | :------------- | :------------- |
|Can use a constructor to create an instance of the RepeatCounter class.|Call RepeatCounter constructor.| New instance of RepeatCounter created. |
| "RepeatCounter" class stores a phrase and can retrieve it with the GetPhrase method.| Pass the phrase "hi mom" into the constructor, call the GetPhrase method.| New instance of RepeatCounter class, "hi mom" is returned. |
| "RepeatCounter" class stores a target word and can retrieve it with the GetTarget method.| Pass the phrase "hi mom" and the target word "mom" into the constructor, call the GetTarget method.| New instance of RepeatCounter class, "mom" is returned. |
| "RepeatCounter" class contains a CalculateCount method that returns 1 if the phrase and target word are the same.| Pass "mom" into the constructor as both phrase and target, call the CalculateCount method.| CalculateCount returns 1. |
| CalculateCount method correctly counts a single instance of the target word in a multi-word phrase.| Pass the phrase "hi mom" and the target word "mom" into the constructor, call the CalculateCount method.| CalculateCount returns 1. |
| CalculateCount method correctly counts multiple instances of the target word in a multi-word phrase.| Pass the phrase "hello world hello galaxy hello universe" and the target word "hello" into the constructor, call the CalculateCount method.| CalculateCount returns 3. |
| RepeatCounter constructor accepts boolean argument to set case sensitivity. If true, CalculateCount method correctly counts exact instances of the target word in a multi-word phrase.| Pass the phrase "Hello world hEllo galaxy heLLo universe" and the target word "hEllo" into the constructor, call the CalculateCount method.| CalculateCount returns 1. |
| RepeatCounter constructor accepts boolean argument to set case sensitivity. If false, CalculateCount method correctly counts multiple instances of the target word in a multi-word phrase, regardless of case.| Pass the phrase "Hello world hEllo galaxy heLLo universe" and the target word "HELLO" into the constructor, call the CalculateCount method.| CalculateCount returns 3. |

## Setup/Installation Requirements

1. This application is temporarily lacking a user interface :/

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#/.NET

## Support and contact details

_Email me with any questions, comments, or concerns:_
zachweintraub@gmail.com

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_{Zach Weintraub}_**
