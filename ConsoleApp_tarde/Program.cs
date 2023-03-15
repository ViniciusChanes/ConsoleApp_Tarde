using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado multilase", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor() + " " + p2.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse RAZER");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor() + " " + p2.getValor());

Endereco e1 = new Endereco(1,
    "15906304",
    "Mario Miziara",
    91,
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447", e1);
Cliente c2 = new Cliente(2, "Vinicius", "99132-0000", e1);
Cliente c3 = new Cliente(3, "Fernando 2", "99156457", e1);
Cliente c4 = new Cliente(4, "Alexandre", "99112347", e1);
Cliente c5 = new Cliente(5, "Arthur", "991864247", e1);
Cliente c6 = new Cliente(6, "Lucas", "991235447", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().getRua());
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "Portal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());


Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadeRodas = 4;
car.quantidadeAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadeRodas = 2;
bicicleta.quantidadeAssentos = 1;
bicicleta.TemMotor = false;

Aviao boing = new Aviao();
boing.cor = "Branco";
boing.quantidadeRodas = 18;
boing.quantidadeAssentos = 336;
boing.TemMotor = true;
































