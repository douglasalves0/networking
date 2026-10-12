# Useful Info

## Lecture
https://youtu.be/Bf7GQjXFuGI?si=ZLQCiXWmc96vk3GG

## Project - HTTP from Scratch

Build an HTTP client and server in C# using raw TCP sockets, implementing the HTTP application layer without high-level HTTP libraries or frameworks.

The project is divided into three parts:

1. **Client Implementation and Server Framework**, implement the HTTP client from scratch and use a server framework to handle requests.
2. **Client Framework and Server Implementation**, use an HTTP client framework and implement the server from scratch.
3. **Client and Server Implementation**, implement both the client and server from scratch, handling HTTP requests and responses directly over TCP sockets.

The server exposes `localhost:8080/sum?A=<int>&B=<int>` and returns `{"C": A+B}` as JSON. The goal is to understand HTTP internals by progressively replacing high-level abstractions with manual protocol implementation.
