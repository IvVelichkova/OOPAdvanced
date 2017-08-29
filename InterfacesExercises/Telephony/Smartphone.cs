using System;
 public  class Smartphone:IBrowseble,ICalling
 {
     private string browser;
     private string phonenumber;

     public Smartphone()
     {
         this.Broser = browser;
         this.PhoneNumber = phonenumber;
     }

     public string Broser { get; private set; }
     public string PhoneNumber { get; set; }

     public string Browser()
     {
         return $"Browsing: {this.browser}";
     }

     

     
     public string Calling()
     {
        return $"";
    }

    
 }

