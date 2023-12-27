namespace BOL;

public class Product{
    public int id{get;set;}
    public string title{get;set;}
    public string imageURL{get;set;}
    public string category{get;set;}
    public string description{get;set;}
    public float unitPrice{get;set;}
    public int balance;
    public string paymentTerm{get;set;}
    public string delivery{get;set;}

    public Product(int id, string title, string imageurl, string category, string description, float unitprice,int balance,string paymentterm,string delivery){
        this.id = id;
        this.title = title;
        this.imageURL = imageurl;
        this.category = category;
        this.description = description;
        this.unitPrice = unitprice;
        this.balance = balance;
        this.paymentTerm = paymentterm;
        this.delivery = delivery;
    }
}