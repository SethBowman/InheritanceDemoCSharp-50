using InheritanceDemoCSharp_50;

var seth = new Person();

seth.Name = "Seth";
seth.Age = 30;

seth.Greet();

var cruz = new Coder();

cruz.Name = "Cruz";
cruz.Age = 32;
cruz.ProgrammingLanguage = "C#";

cruz.Greet();
cruz.Code();

var bob = new BackEndDev();

bob.Name = "Bob";
bob.Age = 35;
bob.ProgrammingLanguage = "Java";
bob.DataBase = "Microsoft SQL";
 
bob.Greet();
bob.Code();

