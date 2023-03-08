using ConsoleApp_Tarde;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado multilase", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor() + " " + p2.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse RAZER");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor() + " " + p2.getValor());

