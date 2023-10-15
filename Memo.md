## Steps to Create and Run Unit Tests in a C# Project:
### Method
1. Navigate to Project Root: Open a terminal and navigate to the root directory where your main project (HelloWorldExample.csproj) is located.

2. Create a Test Project: Create a new NUnit test project using the following command:

```bash
dotnet new nunit -n HelloWorldExample.Tests
This will create a new folder called HelloWorldExample.Tests with a test project inside it.
```

3. Add Reference to Main Project: Navigate into the HelloWorldExample.Tests directory and run the following command to add a reference to your main project:

```bash
dotnet add reference ../HelloWorldExample.csproj
```

This allows your test project to access the classes and methods in your main project.

4. Restore Packages: Run dotnet restore in both the HelloWorldExample and HelloWorldExample.Tests directories to resolve all dependencies.

5. Write Tests: Open the UnitTest1.cs file (or create a new .cs file) in the HelloWorldExample.Tests directory and write your NUnit tests.

6. Run Tests: Navigate to the HelloWorldExample.Tests directory in your terminal and run the following command to execute all tests:

```bash
dotnet test
```

This will discover and run all the tests in the HelloWorldExample.Tests project and display the results.

### Conclution
And there you have it! These are the basic steps to create and run unit tests for a C# project using NUnit.
Anone, hope this summary helps you in your future projects! 🐾
