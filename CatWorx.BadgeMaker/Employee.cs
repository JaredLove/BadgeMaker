// By wrapping the class in the CatWorx.BadgeMaker namespace, we can access it directly from any class that uses CatWorx.BadgeMaker
// protection level of private, which means that they can only be accessed within the class itself.
// Fortunately, we can control the access level of properties when we declare them, using an access modifier.
namespace CatWorx.BadgeMaker
{
  class Employee
  {
    public string FirstName;
    public string LastName;
    public int Id;
    public string PhotoUrl;

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetFullName() {

    return  FirstName + " " + LastName;
    
    }
  }
}