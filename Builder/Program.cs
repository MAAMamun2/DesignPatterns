using Builder;

IComputerBuilder gamingBuilder = new GamingComputerBuilder();
ComputerDirector director = new ComputerDirector(gamingBuilder);

director.ConstructComputer();
Computer gamingComputer = director.GetComputer();
Console.WriteLine("Gaming Computer: " + gamingComputer);


IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director = new ComputerDirector(officeBuilder);

director.ConstructComputer();
Computer officeComputer = director.GetComputer();
Console.WriteLine("Office Computer: "+officeComputer);

Console.ReadLine(); 