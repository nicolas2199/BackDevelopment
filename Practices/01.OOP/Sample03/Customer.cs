public class Customer:Person
{
public string AccountNumber { get; set; }
public string AccountType { get; set; }

public Customer():base()
{

}
public Customer(int id, string firstName,string lastName, dateTime dateOfBirth,char sex,string accountNumber,string accountType):base(id,firstName,lastName,dateOfBirth,sex)
    
{
  this.AccountNumber = accountNumber;
  this.AccountType = accountType;
}
}