namespace person;

public class Person{

    public int Id{get;set;}

    public string FirstName{get;set;}

    public string LastName{get;set;}

    public Person(){
        this.Id = 0;
        this.FirstName = null;
        this.LastName = null;
    }
    public Person(int id,string FirstName, string LastName){
        this.Id = id;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }




}