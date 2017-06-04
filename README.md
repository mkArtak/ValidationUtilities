# dotnet-standard-utilities
A set of useful utilitiy libraries, aimed to help with validation.
Imagine the below simple example:

public void SomeMethod(string argument1)  
{  
   **if (string.IsNullOrWhiteSpace(argument1))  
   {  
       throw new ArgumentException("Invalid value");  
   }**    
     
   // some logic here.  
}  

This can now be rewritten as:  
public void SomeMethod(string argument1)  
{  
   **argument1.Ensure().IsNotNullOrWhitespace();**   
   
  // some logic here.  
}  

And this is only for a single validation scenario. Imaging a method which have multiple arguments and multiple validation rules which apply to each.
