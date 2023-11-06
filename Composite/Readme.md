The Composite design pattern composes objects into tree structures to represent part-whole hierarchies. 
This pattern lets clients treat individual objects and compositions of objects uniformly.


•	IComponent: This is a shared interface that specifies the operation each component needs to implement.
•	Leaf: This is an individual component.
•	Composite: This is a collection of components. It can include both leaves and other composites.
•	Client: This class has access to different components via the shared interface IComponent, taking advantage of polymorphism.


