# CitiesProject (in Linq!) 

The purpose of this team activity is to help you become more familiar with using linq to handle enumerable data. 
You will be completing the cities project that was given to you during your training, except with much 
of the project taken care of.

## Requirements

Code is provided to read the CSV and write the JSON files. There is a `FormatCities` method which will return a `List<Country>` and take cities as `Row` objects.

Your task is to edit the `FormatCities` method to return a `List<Country>` object where each country is populated with the correct `Name`, and a `List<State>` object that holdes each of the states in that country. The `State` objects need to have the correct `Name`, and a `List<Cities>` that holds city objects that are in each state.

## Models

**Input:** Row objects

**Output:** Country objects, with states and cities inside them

There are four classes for you to worry about, `Row`, `Country`, `State`, and `City` objects.
- `Row`s are the objects that comes from the CSV. You may call the `Country`, `State`, and `City` names of of it, or the `Population` intager value.
- `Country` and `State` objects are very similar. They each have an empty constructor and a constructor that takes their `Name`s and their list of `State` or `City` objects respectively. They have properties to access those fields as well.
- The `City` class has the same two constructors, but the two-parameter constructor instead takes it's `Name` and `Population` instead.

## Some helpful Linq method references

`.ToList()`

This will actually execute the linq query, you might run into problems if you don't call this at the end of your linq query.

`.Select(lambda)` 

The map of Linq. Allows you to apply a function over each element in the colletion (x input, x output). It takes a lambda expression as a parameter which is your function that will return the new element.

`.Where(lambda)`

The filter of Linq. Allows you to apply a function over each element in the collection, but only keeps the element if the function returns true (x input, less than x output). It takes a lambda that returns true or false.

`.Distinct()`

Returns a unique list of elements. If there are any duplicate elements in the collection, it will return the collection with only one of each value.

`.OrderBy(lambda)`

The a sort method of Linq. Allows the user to sort the collection by a specified lambda expression. *Hint: `.OrderBy(z => z)` can order alphabetically, `.OrderBy(city => city.Population)` can order numerically*

(Extra credit methods)

`.SelectMany(lambda)`

Same thing as a Select, but you can return lists instead of elements, and the method will flatten the multiple list returns into one list.

`.Aggregate((optional)seed, lambda)`

The reduce of Linq. Will use an optional seed value and a lambda to accumulate over each element one by one, returning only one value (many x input, single x output). Easiest to just use an example:

```C#
var chars = new []{"a","b","c", "d"};
var csv = chars.Aggregate( (a,b) => a + ',' + b);
Console.WriteLine(csv); // Output a,b,c,d
// Note: a represents the accumulation, b represents the current value
```
