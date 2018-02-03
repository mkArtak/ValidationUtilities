# Validation Utilities is a set of useful utilitiy APIs, aimed to help with argument validation. ![Build Status](https://travis-ci.org/mkArtak/ValidationUtilities.png)


The NuGet package for this repo can be found at https://www.nuget.org/packages/AM.Common.Validation/

Here how the ValidationUtilities can help with the below sample code:

```csharp
public void SomeMethod(string argument1)  
{  
   if (string.IsNullOrWhiteSpace(argument1))  
   {  
       throw new ArgumentException("Invalid value");  
   }    
     
   // some logic here.  
}  
```

This can now be rewritten as:  
```csharp
using AM.Common.Validation;

// ...

public void SomeMethod(string argument1)  
{  
   argument1.Ensure().IsNotNullOrWhitespace();
   
  // some logic here.  
}  
```

And this is only for a single validation scenario. Imaging a method which have multiple arguments and multiple validation rules which apply to each.

It's also possible to inline the usage as follows:
```csharp
using AM.Common.Validation;

// ...
public void MyMethod<T>(T param)
{
    SomeAction(param.Ensure(nameof(param)).IsNotNull().Value;
}
```

The `Ensure()` method can be called with the name of the parameter being validated passed to it, which will result excepitons, which will include the argument name, where relevant. Here how the above validation can be rewritten:

```csharp
argument1.Ensure(nameof(argument1)).IsNotNullOrWhitespace();
```

A new addition to the validation utilities is the property validation, which can be accomplished as follows:

```csharp
using AM.Common.Validation;

public class MyClass
{
    public string Property1 {get;set;}
}

public class Client
{
    public void Call(MyClass instance)
    {
        instance.Ensure(i => i.Property1).IsNotNull();
    }
}
```