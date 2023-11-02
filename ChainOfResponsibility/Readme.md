the Chain of Responsibility relies on transforming particular behaviors into stand-alone objects called handlers. 
In our case, each check should be extracted to its own class with a single method that performs the check. 
The request, along with its data, is passed to this method as an argument.

The pattern suggests that you link these handlers into a chain. 
Each linked handler has a field for storing a reference to the next handler in the chain. 
In addition to processing a request, handlers pass the request further along the chain.
The request travels along the chain until all handlers have had a chance to process it.

Here’s the best part: a handler can decide not to pass the request further down the chain and effectively stop any further processing.

In our example with ordering systems, a handler performs the processing and then decides whether to pass the request further down the chain. 
Assuming the request contains the right data, all the handlers can execute their primary behavior, whether it’s authentication checks or caching.


----

Chain of Responsibility and Decorator have very similar class structures. 
Both patterns rely on recursive composition to pass the execution through a series of objects. However, there are several crucial differences.

The CoR handlers can execute arbitrary operations independently of each other. 
They can also stop passing the request further at any point. 
On the other hand, various Decorators can extend the object’s behavior while keeping it consistent with the base interface.
In addition, decorators aren’t allowed to break the flow of the request.

