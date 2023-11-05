Flyweight is a structural design pattern that allows programs to support vast quantities of objects by keeping their memory consumption low.


•	Flyweight: 
This is the interface that defines the behavior for the Flyweight concrete classes to perform operations on the extrinsic properties (states).
An abstract can also be used in place of the interface.


•	ConcreteFlyweight: 
This class inherits from the Flyweight interface and provides the functionality and the stateless information that will be shared across the objects.


•	UnsharedFlyweight: 
The UnsharedFlyweight inherits from the Flyweight interface and provides the possibility of creating a stateful object that is not shared.


•	FlyweightFactory: 
This is the factory class that maintains a reference list of all Flyweight objects that have been created, and when the client demands a new object, 
first it is checked in the list, if the required object is found then it is returned to the client. If the requested object is not present
, then a new one is created, added to the reference list and the same is returned to the client.


•	Client: 
This is the consumer of the Flyweight objects and maintains a reference of all the objects it is using as well 
as it also computes and maintains the extrinsic state of the object.
