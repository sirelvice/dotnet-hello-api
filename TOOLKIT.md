# Prompt-Powered Kickstart: Beginner Toolkit for C# + .NET 10 Minimal APIs

## 1. Title & Objective

**Title:** Getting Started with C# and .NET 10 – A Beginner’s Toolkit for Minimal APIs
**Chosen tech:** C# + ASP.NET Core Minimal API (.NET)
**End goal:** Run a local API with `GET /api/hello` returning JSON, testable in browser/Swagger.

---

## 2. Quick Summary

.NET is Microsoft’s cross-platform framework for building apps.
C# is the main language.
ASP.NET Core Minimal APIs allow creating small APIs with minimal boilerplate.

---

## 3. System Requirements

* Windows/macOS/Linux
* Terminal + VS Code (recommended)
* .NET SDK installed

---

## 4. Installation & Setup

1. Verify .NET:

```bash
dotnet --version
```

2. Run the project:

```bash
cd HelloApi
dotnet run
```

When the server starts, the terminal prints a base URL such as:

```
http://localhost:5136
```

---

## 5. Testing

After running `dotnet run`, open the URL printed in your terminal.

Example:

```
http://localhost:5136
```

### Hello API Endpoint

```
http://localhost:5136/api/hello
```

Returns JSON hello message.

### Swagger UI

```
http://localhost:5136/swagger/index.html
```

Inside Swagger:

1. Expand **GET /api/hello**
2. Click **Try it out**
3. Click **Execute**
4. View JSON response

---

## 6. AI Prompt Journal

Below are examples of prompts used during development and learning.

### Prompt 1

"Give me a beginner-friendly step-by-step guide to install .NET SDK and verify dotnet works."

Reflection:
Helped confirm installation quickly using `dotnet --version`.

---

### Prompt 2

"Show me how to create an ASP.NET Core Minimal API using dotnet CLI and add a GET endpoint returning JSON."

Reflection:
Helped understand Minimal API structure and routing.

---

### Prompt 3

"How do I add Swagger UI to a .NET Minimal API so I can test endpoints easily?"

Reflection:
Swagger allowed testing directly in the browser without extra tools.

---

### Prompt 4

"I got a build error with WithOpenApi not found — how can I fix it?"

Reflection:
Learned that different templates behave differently and the API still works without that extension.
