# plan B 

## Requirements:
### 1. APIGATEWAY 7
Ocelot 
### 2. AGGREGATOR 5
### 3. N-layer + Dapper 10 
One repository on ADO.NET
Rest on Dapper
### 4. N-Layer + Entity Framework 25
FluentAPI, Fluent Validation , Pagination
### 5. Clean Archicteture + Mongo 16
CQRS , MediatR
### 6. Redis cache 7
### 7. Identity server 10
Clients, Scopes, Resources , TestUsers
### 8. RabbitMQ/Kafka 8 GRPC 
Communitaion into microservices 
### 9. Tests 8
Unit tests, Moq,  Intergrational
### 10. Docker + K8s 4

## Music streaming selaed
### Services:
1. Library (N-layer + Entity Framework)
2. Playlist (Clean Architecture + Redis + Mongo) 
3. Artist (N-layer + Dapper)
4. Album (N-layer + Entity Framework)
5. SongStreamer (N-layer + Entity Framework + GRPC )
6. FileStorageAPI (N-layer + Dapper)
7. Identity (Identity server)
8. APIGATEWAY (Ocelot)
9. AGREGATOR

### Articles and Posts hybrid *codename Licht*
0. Comment (N-layer + Entity Framework)
1. Articles (N-layer + Dapper Kafka producer) 
2. Posts (N-layer + Entity Framework Kafka producer) 
3. Feed (Event storage???) //Create user recieve queuies or make list dymanicly
4. Bookmark (N-Layer + Entity Framework Kafka consumer)
5. Users (N-layer + Entity Framework )  
6. Images (Clean Architecture + Mongo +Redis GRPC)
7. FileStorage (N-layer + ADO.NET + GRPC)
8. APIGATEWAY
9. AGGREGATOR
10. Identity Server

## Online shop
1. Cart (Clear Architecture + Mongo + Redis) (16)
2. Catalog (N-layer + Entity Framework)
3. Invetory (N-layer + ADO.NET)
4. FileStorageAPI (N-layer + Entity Framework)
5. Order (N-layer + Entity Framework)
6. Discount (N-layer + Dapper, GRPC)
7. User (N-layer + Entity Framework)
8. Identity (Identity Server) (10)
9. APIGATEWAY (7)
10. AGREGATOR (5)