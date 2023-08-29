namespace assignments.oopclass
{
    class Book
    {
        string bookname,avtor,booktype,booklanguage;
        int pages,CreatYear,price;
        public Book(string Namebook)
        {
            bookname=Namebook;
        }
        public string Booktype
        {
            get{return booktype;}
            set{booktype=value;}
        }
        public string Language
        {
            get{return booklanguage;}
            set{booklanguage=value;}
        }
        public string Avtor
        {
         get{return avtor;}
         set{avtor=value;}  
        }
        public int Pages
        {
            get
            {
                return pages; 
            }
            set
            {
                pages=value;
            }
        }
        public int Price
        {
            get{return price;}
            set{price=value;}
        }
        public void Bookinfo()
        {
            System.Console.WriteLine($"About your book\nname:{bookname}\ntype:{booktype}\nlanguage:{booklanguage}\navtor:{avtor}");
            System.Console.WriteLine($"pages:{pages}\nprice:{price}");

        }

    }
}