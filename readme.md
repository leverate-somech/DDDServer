DDDServer
=========

DDDServer is a temporary name, at the moment the project is only an idea, I created a set of interfaces and example projects to check if the idea is valid and if there is a demand for it.

I got inspired from [Microsoft Orleans](http://research.microsoft.com/en-us/projects/orleans/) to create something similiar for DDD/CQRS/Event Sourcing (Sorry for the amount of buzzwords).

The idea is to create scalable solution that host Aggregates and Command Handlers and all the rest will be taken care of:

* Persistence
* Communication
* Message Bus
* Snapshoting
* Scalability/horizontal partition/sharding
* Reliablity (Active-Passive)

As mentioned earlier this is the design and check for demand phase, take a look at the source code, see the API and examples.

If this project intrest you or you want to contribute please let me know by responding to the following issue https://github.com/somdoron/DDDServer/issues/1.

