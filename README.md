# Assignment 5
in this repo contains the microservice implementaion between a customer and order service

# HOW TO RUN THE PROJECT
- install visual studio or vscode and clone this repo to your repository
- run ***dotnet build*** to make sure all services are installed for each services
- the CustomerService acts as the server while the OrderService acts as the CLient
- Start the CustomerService first before the OrderService

The CustomerService should run on ***http://localhost:5081***
This has been referenced by the OrderService which runs on ***http://localhost:5248***

You can test the endpoint by accessing ***http://localhost:5248/order/getcustomer/{customerId}***
