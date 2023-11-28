// By wrapping the class in the CatWorx.BadgeMaker namespace, we can access it directly from any class that uses CatWorx.BadgeMaker
// protection level of private, which means that they can only be accessed within the class itself.
// Fortunately, we can control the access level of properties when we declare them, using an access modifier.
namespace CatWorx.BadgeMaker
{ class Employee
  {
    private string FirstName;
    private string LastName;
    private int Id;
    private string PhotoUrl;
    public Employee(string firstName, string lastName, int id, string photoUrl) {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        PhotoUrl = photoUrl;
    }
    public string GetFullName() {
        return  FirstName + " " + LastName;
    }
  
    public int GetId() {
        return Id;
    }
    public string GetPhotoUrl() {
        return PhotoUrl;
    }
  }
}