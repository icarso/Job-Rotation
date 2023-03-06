/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/
//1)
int i= 13, soma= 0, k= 0;

while (k < i){
    k++;
    soma += k;
}

Console.WriteLine(soma);

// Ao final do processamento, qual será o valor da variável SOMA? R: A variável soma retorna 91.

/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//2)
int numAnt = 0, numAtual = 1, numero, fibonacci;
bool pertenceFibonacci = false;

Console.WriteLine("Informe um número interiro: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= numero;  i++){
    fibonacci = numAnt + numAtual;
    numAnt = numAtual; 
    numAtual = fibonacci;

    if (numero == fibonacci)
        pertenceFibonacci = true;
}

if(pertenceFibonacci)
        Console.WriteLine("O número {0} pertence à sequencia de Fibonacci.", numero);
else 
        Console.WriteLine("O número {0} não pertence à sequencia de Fibonacci.", numero);
        
/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/

/*3)Descubra a lógica e complete o próximo elemento:



a) 1, 3, 5, 7, ___                    9     Lógica: ímpares
b) 2, 4, 8, 16, 32, 64, ____          128   Lógica: dobro
c) 0, 1, 4, 9, 16, 25, 36, ____       49    Lógica: soma números ímpares
d) 4, 16, 36, 64, ____                100   Lógica: A partir de 12 à diferença soma 8 (Progressão Aritmética)
e) 1, 1, 2, 3, 5, 8, ____             13    Lógica: Fibonacci
f) 2,10, 12, 16, 17, 18, 19, ____     200   Lógica: números com a letra d
*/

/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//4)
/*
Determinando Ribeirão Preto como posicao=0, têm-se as posições iniciais do carro (0) e caminhão (100).

De acordo com a fórmula de movimento retilíneo uniforme, eles irão se cruzar quando a posição do carro for igual a posição do caminhão. Para isso, precisamos considerar o atraso de 10 minutos, ou 0.17 horas, onde:

velocidadeNormal    80 = 1 hora

posicaoAtrasada = 1-0.17 horas = 0.83;

Agora, determina-se que o encontro ocorrerá quando as posições forem iguais, ou seja, quando:*/

double posicaoCaminhao = 100, encontro = 0;

for (var posicaoCarro=0; posicaoCarro<=100; posicaoCarro++){

  while(posicaoCarro != posicaoCaminhao){
      if (posicaoCaminhao == posicaoCarro){
          encontro = posicaoCaminhao;
          break;
      }
      posicaoCaminhao -= 0.83;
  }
}
Console.WriteLine("O encontro ocorreu a {0} km de Ribeirão Preto.", encontro);

/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//5) Escreva um programa que inverta os caracteres de um string.

string frase = "Juiz de Fora";

for (int i=frase.Length-1; i>=0; i--){
  Console.Write(frase[i]);
}


/*---------------------------------------------------------------------------------------------------------------------------------------------------------------*/
