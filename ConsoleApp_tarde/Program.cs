using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;
using System.Runtime.InteropServices;

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

List<Veiculo> veiculoLista = new List<Veiculo>();

veiculoLista.Add(car);
veiculoLista.Add(boing);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}


Console.WriteLine("Qtd i" +
    "tens da lista: " + veiculoLista.Count);

Random rand = new Random();

List<Produto> produtoLista = new List<Produto>();
List<Cliente> clienteLista = new List<Cliente>();

for (int i=0;i<rand.Next(200,500);i++)
{
    int aux = 0;
    aux = i * 10;
    Produto p = new Produto(i, "Teste", aux);
    produtoLista.Add(p);
   
}

for (int i = 0; i < rand.Next(150, 300); i++)
{

    int aux = i * 3;
    Cliente c = new Cliente(aux, "Fernando", "123465", e1);
    clienteLista.Add(c);

}

foreach (var item in produtoLista)
{
    Console.WriteLine(item.ProdutoCompleto());
}

foreach (var item in clienteLista)
{
    Console.WriteLine(item.ClienteCompleto());
}