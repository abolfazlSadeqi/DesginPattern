The State pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes.
The State pattern is useful when the behavior of an object depends on its state and needs to change dynamically when its state changes.

The State is a behavioural design pattern that lets an object alter its behaviour when its internal state changes. For the system, it appears as if the object changed its class.
The State design pattern is one of the most useful patterns described by the Gang of Four. Games often depend on the State pattern because objects can change so frequently. Many other simulations, whether they are games or not, depend on the State pattern as well.
•	Context
•	defines the interface of interest to clients
•	maintains an instance of a ConcreteState subclass that defines the current state.
•	State  
•	defines an interface for encapsulating the behavior associated with a particular state of the Context.
•	Concrete State  
•	each subclass implements a behavior associated with a state of Context
