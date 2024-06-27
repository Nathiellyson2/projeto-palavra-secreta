// projeto do jogo da palavra secreta
// usuário vai digitar uma letra até acertar a palavra secreta.

string palavraSecreta = "AMIGO"; // Pode mudar o nome da palavra secreta!
char[] palavraSecretaArray = new char[palavraSecreta.Length];

/*  A seguir tem um "for", que talvez seja complicado de entender:
primeiro eu crio o "contadorDaPalavraSecreta" no "for" que servirá para acessar cada caractere da palavra secreta,
logo, cada caractere vai ser atribuido individualmente em cada loop para "letrasDaPalavraSecreta",
por fim, eu adiciono cada caractere em sua posição no array que foi criado logo acima. */

for (int contadorDaPalavraSecreta = 0; contadorDaPalavraSecreta < palavraSecreta.Length; contadorDaPalavraSecreta++) {
    char letrasDaPalavraSecreta = palavraSecreta[contadorDaPalavraSecreta];
    palavraSecretaArray[contadorDaPalavraSecreta] = letrasDaPalavraSecreta;
}

Console.WriteLine("\t\tBEM VINDO AO JOGO DA PALAVRA SECRETA!");
Console.WriteLine("\t\tVAMOS COMEÇAR?");


while (palavraSecretaArray.Length != 0) {
    Console.Write("\t\tDIGITE UMA LETRA: ");
    char letraDoUsuario = Convert.ToChar(Console.ReadLine().ToUpper());

    bool letraEncontrada = false;

    // Aqui é utilizado o "foreach" para iterar o array e comparar com a letra que o usuário digitou.
    // Se ele tiver acertado a letra, ela é deletada do array.
    if (palavraSecretaArray.Length != 0) {
        foreach (char letraParaComparar in palavraSecretaArray) {
            if (letraParaComparar == letraDoUsuario) {
                palavraSecretaArray = palavraSecretaArray.Where(i => i != letraDoUsuario).ToArray();
                letraEncontrada = true;
                break;
            }
        }
        if (letraEncontrada) {
                Console.WriteLine($"PARABÉNS VOCÊ ACERTOU UMA LETRA! AGORA FALTAM {palavraSecretaArray.Length} LETRAS");
        }
        else {
            Console.WriteLine("ERRRRRRROOOOOUUUUUUUUUU!");
        }        
    }
}
Console.WriteLine($"PARABÉNS VOCÊ GANHOU!, A PALAVRA SECRETA É {palavraSecreta}");