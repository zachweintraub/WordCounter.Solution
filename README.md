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
| RepeatCounter class contains property _count that is set automatically and retrieved with a GetCount method.| Pass the phrase "hello world hello galaxy hello universe" and the target word "hello" into the constructor, call the GetCount method.| GetCount returns 3.|
