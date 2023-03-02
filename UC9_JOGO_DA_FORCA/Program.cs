int i, tentativas, tentativas1 = 0, tentativas2 = 0;
int encontrado = 0;
string letra = "";
string[] palavra_secreta = new string[10];
string[] palavra_visivel = new string[10];
string jogador_1, jogador_2;
for (i = 0; i <= 9; i++)
{
    Console.WriteLine((i + 1) + "ª Letra da palavra (total de 10 letras)");
    palavra_secreta[i] = Console.ReadLine();
}

for (i = 0; i <= 9; i++)
{
    Console.Write(palavra_secreta[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

Console.Clear();

tentativas = 0;
// Cadastre os Usuários...
Console.WriteLine("Cadastre o jogador 1");
jogador_1 = Console.ReadLine();

Console.WriteLine("Cadastre o jogador 2");
jogador_2 = Console.ReadLine();

while (tentativas < 5)
{
    // SEMPRE MOSTRAR A PALAVRA EM JOGO NA TELA...
    Console.Clear();
    for (i = 0; i <= 9; i++)
    {
        Console.Write(palavra_visivel[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("Você já ERROU " + tentativas1 + " vezes " + jogador_1 + "! (Máximo de 5 ERROS!)");
    Console.WriteLine("");

    Console.WriteLine("");
    Console.WriteLine("Você já ERROU " + tentativas2 + " vezes " + jogador_2 + "! (Máximo de 5 ERROS!)");
    Console.WriteLine("");

    // Usuário informa uma LETRA para tentativa de acerto...
    if (tentativas1 < 5)
    {
        Console.WriteLine("Qual LETRA deseja tentar " + jogador_1 + "?");
        letra = Console.ReadLine();

        for (i = 0; i < 10; i++)
        {
            // Se LETRA existe, JOGO mostra a LETRA na tela e na posição para o usuário;
            if (letra == palavra_secreta[i])
            {
                palavra_visivel[i] = letra;
                encontrado = 1;
            }

        }
        // Se LETRA não existe, JOGO informa Letra Incorreta!
        if (encontrado == 0)
        {
            Console.WriteLine("LETRA não encontrada " + jogador_1);
            tentativas1++;
        }
        encontrado = 0;
    }
    if (tentativas2 < 5)
    {
        Console.WriteLine("Qual LETRA deseja tentar " + jogador_2 + "?");
        letra = Console.ReadLine();
        for (i = 0; i < 10; i++)
        {
            // Se LETRA existe, JOGO mostra a LETRA na tela e na posição para o usuário;
            if (letra == palavra_secreta[i])
            {
                palavra_visivel[i] = letra;
                encontrado = 1;
            }

        }
        // Se LETRA não existe, JOGO informa Letra Incorreta!
        if (encontrado == 0)
        {
            Console.WriteLine("LETRA não encontrada " + jogador_2);
            tentativas2++;
        }
        encontrado = 0;
    }

    Console.WriteLine("");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}