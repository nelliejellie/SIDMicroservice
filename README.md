# Assignment 5

in this repo contains the microservice implementaion between a customer and order service

This microservice architecture uses grpc to communicate with each services

# HOW TO RUN THE PROJECT

- install visual studio or vscode and clone this repo to your repository
- run **_dotnet build_** to make sure all services are installed for each services
- the CustomerService acts as the server while the OrderService acts as the CLient
- Start the CustomerService first before the OrderService

The CustomerService should run on **_http://localhost:5081_**
This has been referenced by the OrderService which runs on **_http://localhost:5248_**

You can test the endpoint by accessing **_http://localhost:5248/order/getcustomer/{customerId}_**
