public class Person
{
    //Attributes
    //private int id;
    //private string firstName;
    //private string lastName;
    //private DateTime dateOfbirth;
    //private char sex;
    //Properties
    //public int id
   // {
       // get
        //{
           // return this.id;
        //}
        //set
        //{
          //  this.id = value;
        //}
    //}

    public int Id{get; private set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public char Sex { get; set; }

    public Person()
    {

    } 

    public Person(int id, string firstName,string lastName, dateTime dateOfBirth,char sex)
    {
         this.Id=Id;
         this.FirstName = firstName;
         this.LastName =lastName;
         this.DateOfBirth = dateOfBirth;
         this.Sex = sex;
    }
}