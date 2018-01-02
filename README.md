# Validation Utilities is a set of useful utilitiy APIs, aimed to help with argument validation.

[![Build Status](https://travis-ci.org/mkArtak/ValidationUtilities.png)]

The NuGet package for this repo can be found at https://www.nuget.org/packages/AM.Common.Validation/
Imagine the below simple example:

```
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
```
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
```
using AM.Common.Validation;

// ...
public void MyMethod<T>(T param)
{
	SomeAction(param.Ensure(nameof(param)).IsNotNull().Value);
}
```
