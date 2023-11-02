Extending a class is the first thing that comes to mind when you need to alter an object’s behavior. 
However, inheritance has several serious caveats that you need to be aware of.

Inheritance is static. You can’t alter the behavior of an existing object at runtime. 
You can only replace the whole object with another one that’s created from a different subclass.
Subclasses can have just one parent class. 
In most languages, inheritance doesn’t let a class inherit behaviors of multiple classes at the same time.
One of the ways to overcome these caveats is by using Aggregation or Composition  instead of Inheritance. 
Both of the alternatives work almost the same way: 
one object has a reference to another and delegates it some work, whereas with inheritance, 
the object itself is able to do that work, inheriting the behavior from its superclass.

With this new approach you can easily substitute the linked “helper” object with another, changing the behavior of the container at runtime. 
An object can use the behavior of various classes, having references to multiple objects and delegating them all kinds of work. 
Aggregation/composition is the key principle behind many design patterns, including Decorator. On that note, let’s return to the pattern discussion.

