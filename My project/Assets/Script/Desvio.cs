using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Mathematics;
using UnityEngine;

public class Desvio : MonoBehaviour
{
    [Header("Primeira quest�o")]
    public float n1;
    public float n2;

    [Header("Segunda quest�o")]
    public float maior;
    public float menor;

    [Header("Terceira quest�o")]
    public int senha;

    [Header("Quarta quest�o")]
    public int escolhaComida;

    [Header("Quinta quest�o")]
    public int imparPar;

    [Header("Sexta quest�o")]
    public int divPor5;

    [Header("Setima quest�o")]
    public string nome1;
    public float nota1;
    public float nota2;
    public float nota3;
    public float media;

    [Header("Oitava quest�o")]
    public float kWh;
    public int tipoDeConsumidor;

    [Header("Nona quest�o")]
    public float lado1;
    public float lado2;
    public float lado3;

    [Header("Decima quest�o")]
    public float IMC;
    public float peso;
    public float altura;

    [Header("Decima primeira quest�o")]
    public string codigo;

    // Start is called before the first frame update
    void Start()
    {
        _1Questao();
        _2Questao();
        _3Questao();
        _4Questao();
        _5Questao();
        _6Questao();
        _7questao();
        _8Questao();
        _9Questao();
        _10Questao();
        _11Questao();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void _1Questao()
    {
        if (n1 == n2)
        {
            Debug.Log("Os numeros s�o iguais");
        }
        else
        {
            Debug.Log("Os numeros s�o diferentes");
        }
    }
    public void _2Questao()
    {
        if(maior > menor)
        {
            Debug.Log("O maior numero � " + maior);
        }else 
        {
            Debug.Log("O maior numero � " + menor);
        }
    }
    public void _3Questao()
    {
        if (senha == 1234)
        {
            Debug.Log("Acesso perimitido");
        }
        else
        {
            Debug.Log("Acesso negado");
        }
    }
    public void _4Questao()
    {
        Debug.Log("Card�pio: ");
        Debug.Log("1. Hamburger Gourmet");
        Debug.Log("2. Pizza");
        Debug.Log("3. Macarronada");
        Debug.Log("4. Feijoada");
        Debug.Log("Digite o numero correspodente ao prato ex.: Hambuger = 1");
        switch (escolhaComida) 
        {
            case 1:
                Debug.Log("R$ 20,00");
            break;
            case 2:
                Debug.Log("R$ 56,00");
            break;
            case 3:
                Debug.Log("R$ 35,00");
            break;
            case 4:
                Debug.Log("R$ 40,00");
            break;
            default:
                Debug.Log("N�o existe essa op��o no cardapio");
            break;
        }
    }
    public void _5Questao()
    {
        if(imparPar %2 == 0)
        {
            Debug.Log("O numero � par");
        }else
        {
            Debug.Log("O munero � impar");
        }
    }
    public void _6Questao()
    {
        if(divPor5 %5 == 0)
        {
            Debug.Log("O numero � divisivel por 5");
        }else
        {
            Debug.Log("O numero n�o � divisil por 5");
        }
    }
    public void _7questao()
    {
        media = (nota1 + nota2 + nota3)/3;
        if(media >= 6)
        {
            Debug.Log("O aluno " + nome1 + "esta APROVADO");
        }else if(media >= 4 && media <= 5.9f)
        {
            Debug.Log("O aluno " + nome1 + "esta  de recupera��o");
        }
        else
        {
            Debug.Log("O aluno " + nome1 + "esta REPROVADO");
        }
    }
    public void _8Questao()
    {
        switch (tipoDeConsumidor)
        {
            case 1:
                Debug.Log("O valor a pagar �" + kWh * 1.3f);
            break;
            case 2:
                Debug.Log("O valor a pagar �" + kWh * 2.2f);
            break;
            case 3:
                Debug.Log("O valor a pagar �" + kWh * 3.1f);
            break;
            default:
                Debug.Log("N�o existe essa op��o");
            break;
        }
    }
    public void _9Questao()
    {
        if(lado1 == lado2 && lado1 == lado3)
        {
            Debug.Log("O triangulo � Equilatero");
        }
        if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Debug.Log("O triangulo � Isoceles");
        }else
        {
            Debug.Log("O triangulo � Escaleno");
        }
    }
    public void _10Questao()
    {
        IMC = peso/math.pow(altura, 2);
        if (IMC > 35)
        {
            Debug.Log("A pessoa tem obesidade morbida");
        }if(IMC <= 35 && IMC > 30)
        {
            Debug.Log("A pessoa tem obesidade");
        }if (IMC <= 30 && IMC > 25)
        {
            Debug.Log("A pessoa tem sobre peso");
        }if(IMC <= 25 && IMC > 20)
        {
            Debug.Log("A pessoa esta em um peso normal");
        }
        else
        {
            Debug.Log("A pessoa esta abaixo do peso");
        }


    }
    public void _11Questao()
    {
        switch(codigo)
        {
            case "ABCD":
                Debug.Log("O pre�o �: R$ 5,30");
            break;
            case "XYPK":
                Debug.Log("O pre�o �: R$ 6,00");
            break;
            case "KLMP":
                Debug.Log("O pre�o �: R$ 3,20");
            break;
            case "QRST":
                Debug.Log("O pre�o �: R$ 2,50");
            break;
            default:
                Debug.Log("N�o existe essa op��o");
            break;
        }
    }
}
