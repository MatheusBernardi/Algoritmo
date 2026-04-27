//algoritmo que calcula a área do círculo
//declaração das variáveis
double raio = 0.0;
double raio = 0.0;
double pi = 3,14159;

//interação com o usuário
Console.WriteLine("-----Cálculo da área do círculo-----");
Console.Write("Informe o valor do raio do círculo");
raio = convert.ToDouble(Console.ReadLine());

//cálculo da área
area = pi * (raio * raio);

//exibir o resultado no terminal
//Interpolação de strings (textos)
Console.WriteLine($"O valor da área do círculo é {area:F3}");