using AbstractFactory.Factories;

Hero elf = new Hero(new ElfFactory());
elf.Move();
elf.Hit();

Hero warior = new Hero(new WariorFactory());
warior.Move();
warior.Hit();