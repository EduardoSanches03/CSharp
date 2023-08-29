//Calcular a área de um triângulo

float _base, _altura;

Console.WriteLine("Para calcular a área de um triângulo, iremos precisar de duas informações: \nBase e Altura.");
Console.WriteLine("--------------------------------");
Console.WriteLine("Informe a Base do Triângulo:");
_base = float.Parse(Console.ReadLine());
Console.WriteLine("--------------------------------");
Console.WriteLine("Agora, informe a altura do Triângulo:");
_altura = float.Parse(Console.ReadLine());

float _area = (_base * _altura) / 2;
Console.WriteLine("--------------------------------");
Console.WriteLine("A área deste triângulo é: "+_area);
Console.WriteLine("--------------------------------");


//Realizar inserção de dados em um vetor e filtrar entre pares e impares
Console.WriteLine("Iremos criar uma pilha de 10 números, insira 10 números diferentes");
float[] pilha = new float[10];
for(int i=0;i < pilha.Length; i++)
{
    Console.WriteLine("Insira um número na puilha: ");
    pilha[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("----------\nNúmeros pares: ");
for(int i=0; i < 10; i++)
{
    if (pilha[i] % 2 == 0)
        Console.WriteLine("" + pilha[i]);  
}

Console.WriteLine("----------\nNúmeros ímpares: ");
for (int i = 0; i < 10; i++)
{
    if (pilha[i] % 2 != 0)
        Console.WriteLine("" + pilha[i]);
}
