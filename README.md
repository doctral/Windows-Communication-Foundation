# Windows-Communication-Foundation

## Overview
1. Platform for building distributed, service-oriented applications
    1. Define services and hosts for those services
    2. Define clients to connect to services
    3. Secure, Scalable, robust, and flexible
2. SOAP messaging
3. WCF Configuration
    1. Endpoints:
        1. Address
        2. Binding
        3. Contract
    2. Behaviors
    3. Bindings
4. WCF allows you to easily connect clients and services for remote communications.
5. The service boundary is defined through a combination of the service contract, data contracts, and configuration.
6. Behaviors configure aspects about how the service behaves when service messages are received
7. Bindings configure aspects about how the service behaves when sevice messages are received 
8. Binding configure aspects of the communication pipe shared with the client

## Implementing Services
1. Create a WCF Service Library project
2. Define Service Contract
3. Define Data Contracts for operation parameters and return types
4. Define the Service implementation class
5. Service implementation class can use **ServiceBehavior** annotation to drive aspects of its behavior when called as a service.
6. Service instance lifetime: 
    1. Per call (favored)
    2. Per session (default)
    3. Singleton

## Hosting Services
1. Services need to run in a host process
2. The host listens for incoming messages and dispatches calls to the appropriate service method
3. How the service is exposed by the host is driven through configuration
4. Hosting Options:
    1. Self Host:  
        1. Any .NET process
        2. User ServiceHost class
    2. IIS Host: 
        1. can only handle HTTP traffic
        2. When using IIS hosting, there is no need to specify address in endpoint
    3. WCF Service Library
        1. OK for quick "smoke testing"
        2. Generally want to debug and develop with a self host or IIS host
    