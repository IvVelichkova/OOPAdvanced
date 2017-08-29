using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//title, author and price
public class Book
{
    private string title;
    private string author;
    private decimal price;


    public Book(string author,string title,decimal price)
    {
        
        this.Title = title;
        this.Author = author;
        this.Price = price;

    }


    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public virtual string Author
    {
        get { return this.author; }
        set
        {
            //if (value.Contains(' '))
            //{
                //var current = value.Split(' ');
                //var isNum = current[1].ToArray();
                //var digit = isNum[0].ToString();
                //int num1;
                //bool res = int.TryParse(digit, out num1);
                //if (res)
                //{
                //    throw new ArgumentException("Author not valid!");

                //}
                if (value.Contains(' '))
                {
                    var current = value.Split(' ');
                    var name = current[1];
                    Regex regex = new Regex("((\\d.+))");
                    Match match = regex.Match(name);
                    if (match.Success)
                    {
                        throw new ArgumentException("Author not valid!");
                    }

                }
     
            this.author = value;
        }
    }

    public virtual string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

   
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f1}")
            .AppendLine();

        return sb.ToString();
    }

}

