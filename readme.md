DDDServer
=========

DDDServer is a temporary name, at the moment the project is only an idea, I created a set of interfaces and example projects to check if the idea is valid and if there is a demand for it.

I got inspired from [Microsoft Orleans](http://research.microsoft.com/en-us/projects/orleans/) to create something similiar for DDD/CQRS/Event Sourcing (Sorry for the amount of buzzwords) so instead of Actor/Grain the Aggregates will live in the cloud.

The idea is that Aggregates will live in the Cloud (set of scalable nodes) and we will communicate with the aggregates with commands, requests and events. Some terminology before we continue:

* Node - the service that aggregates are living on.
* Cloud - set of nodes, nodes can come and go to handle the load.
* Aggregate - Same as DDD definition, the root domain object.
* Event - Events are raised when ever aggregate change state, to persisnt an aggregate we save the events instead of aggregate state. To load an aggregate we fetch the aggregate events and apply them.
* Command - Message to the aggregate to change the state. Command doesn't change state directly but instead apply events on the aggregate.
* Request - Request is the way to ask the aggregate for its state, in pure CQRS we won't have requests, so it's more like CQS, if you want pure CQRS just don't use requests.
* Client Proxy - because aggregates lives on the Cloud we need a way to communucate with them. The client provides an API to send commands and requests and to subscribe for events.

As mentioned earlier this is the design and check for demand phase, take a look at the source code, see the API and examples.

If this project intrest you or you want to contribute please let me know by responding to the following issue https://github.com/somdoron/DDDServer/issues/1.

