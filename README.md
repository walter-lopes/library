# Library 

## Architecture Overview
This project is structured as a full-stack application with the following components:

Frontend: A React-based single-page application (SPA) that provides the user interface.
Backend: A RESTful API developed with .NET Core to handle business logic and data access.
Database: MySQL database to store application data.
Docker Compose: Used to orchestrate the entire application stack for development and production environments.
Prerequisites

Before you begin, ensure you have installed all of the following on your development machine:

Docker and Docker Compose
.NET Core SDK (version specify here)
Node.js and npm
Getting Started
Follow these steps to get your development environment set up:

## Clone the repository

```
git clone https://github.com/walter-lopes/library.git
cd library
```

## Run the application using Docker Compose, it inits the database with our seed

```
docker compose up -d
```

This command builds and starts the containers for the React frontend, .NET Core backend, and MySQL database.

Accessing the application

Frontend is accessible at http://localhost:3000
Backend API can be accessed via http://localhost:5000/swaggger

# Development

## Frontend Development
###Navigate to the frontend directory:

```

cd frontend/library
```
### Install dependencies:
```
npm install
```
### Run the React development server:
```
npm start
```

## Backend Development
### Navigate to the backend directory:
```

cd backend/LibraryAPI

```
### Restore .NET dependencies:

```
dotnet restore

```
### Run the .NET Core development server:
```
dotnet run

```
