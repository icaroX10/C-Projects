

# VARIAVEIS E TIPOS PRIMITIVOS 

CSharp � uma linguagem estaticamente tipada. Significa que precisar definir o tipo antes de usa-los.  
Para declarar vari�veis em C# utilizando uma sintax semelhante ao java e ao C   
```
int myInt = 1;
float myFloat = 1f;
bool myBoolean = true;
string myName = "John";
char myChar = 'a';
double myDouble = 1.75;

```

Note que o dados com ponto fluante necessitando utilizar a letra 'F' como identifica��o no tipo de dado.  

C# suporta inferencia de tipos. Ou seja, nem sempre ser� necess�rio informar o tipo de dada conter� na v�riavel, o compilador tentar� compreender automaticamente. Ele n�o fara opera��es em variaveis de tipos diferentes.

```
var x = 1;
var y = 2;
var sum = x + y; 

```

### Enum

Enums s�o inteiros que devem ser usados quando um n�mero inteiro � usado para especificar uma op��o de uma quantidade fixa de op��es

```
public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}

public class Tutorial
{
    public static void Main()
    {
        CarType myCarType = CarType.Toyota;
    }
}

```

## EXERCICIO DE REPASSE

Crie 3 vari�veis

Uma string chamada productName valor TV.   
Uma integer chamada productYear valor 2012.   
E outra double chamada productPrice valor 279.99.
