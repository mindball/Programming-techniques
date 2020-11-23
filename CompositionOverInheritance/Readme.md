# Composition Over Inheritance scottlilly.com
Sometimes, a project needs several classes that appear to be similar, but have different behavior.

In object-oriented programming, we will often handle this with inheritance. We create a base class. Then, we create sub-classes that inherit from the base class, and have the properties and functions that are unique to the sub-class.

But, that can sometimes lead to messy code.

An alternative is to use “composition”, to have a single class that can be “composed” to handle the different behaviors.



This text you see here is *actually* written in Markdown! To get a feel for Markdown's syntax, type some text into the left window and watch the results in the right.

### Where I’ve found it useful
```
There are two common situations when you would want to consider using composition, instead of inheritance: when you need to do multiple inheritance, and when your sub-classes start to have their own sub-classes.

These are big indicators that the composition might be a better choice.

You might also combine object composition with the Strategy Design Pattern. Instead of composing the object with property values (the attack type and damage), you could also compose it by configuring how it will perform its actions.
```



See [https://scottlilly.com/](https://scottlilly.com/)
