# dotnet-hello-api

Beginner-friendly ASP.NET Core Minimal API built using **C# + .NET 10**.

This project was created for the **Prompt-Powered Kickstart: Beginner’s Toolkit with GenAI** capstone.

The API runs a local web server and exposes:

* A status endpoint
* A Hello API endpoint
* Swagger UI for testing

---

## Requirements

Install .NET SDK.

Verify installation:

```
dotnet --version
```

---

## How to Run the Project

Open terminal inside the repository:

```
cd HelloApi
dotnet run
```

When the server starts you will see something like:

```
Now listening on: http://localhost:5136
```

**IMPORTANT:**
Keep this terminal running while testing.

---

## How to Test the API (VERY IMPORTANT)

The terminal only shows the base URL.
You must manually open the specific routes below.

Use the base URL printed in your terminal.

Example used here:

```
http://localhost:5136
```

---

### 1. Status Endpoint

Open in browser:

http://localhost:5136/

Expected:

```
{"status":"ok","app":"HelloApi","framework":".NET"}
```

---

### 2. Hello API Endpoint

Open in browser:

http://localhost:5136/api/hello

Expected:

```
{"message":"Hello from Tommy in Nairobi! 🚀 Powered by .NET 10"}
```

---

### 3. Swagger UI (Interactive API Tester)

Open:

http://localhost:5136/swagger/index.html

Inside Swagger:

1. Expand **GET /api/hello**
2. Click **Try it out**
3. Click **Execute**
4. View JSON response

---

## Stop the Server

Press:

```
Ctrl + C
```

---

## Project Purpose

This repository demonstrates AI-assisted learning to build a Minimal API using .NET.

It includes:

* Working codebase
* Setup instructions
* Testing instructions
* Toolkit documentation
