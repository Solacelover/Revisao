using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Mathematics;
using UnityEngine;

public class Desvio : MonoBehaviour
{
    [Header("Primeira questão")]
    public float n1;
    public float n2;

    [Header("Segunda questão")]
    public float maior;
    public float menor;

    [Header("Terceira questão")]
    public int senha;

    [Header("Quarta questão")]
    public int escolhaComida;

    [Header("Quinta questão")]
    public int imparPar;

    [Header("Sexta questão")]
    public int divPor5;

    [Header("Setima questão")]
    public string nome1;
    public float nota1;
    public float nota2;
    public float nota3;
    public float media;

    [Header("Oitava questão")]
    public float kWh;
    public int tipoDeConsumidor;

    [Header("Nona questão")]
    public float lado1;
    public float lado2;
    public float lado3;

    [Header("Decima questão")]
    public float IMC;
    public float peso;
    public float altura;

    [Header("Decima primeira questão")]
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
            Debug.Log("Os numeros são iguais");
        }
        else
        {
            Debug.Log("Os numeros são diferentes");
        }
    }
    public void _2Questao()
    {
        if(maior > menor)
        {
            Debug.Log("O maior numero é " + maior);
        }else 
        {
            Debug.Log("O maior numero é " + menor);
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
        Debug.Log("Cardápio: ");
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
                Debug.Log("Não existe essa opção no cardapio");
            break;
        }
    }
    public void _5Questao()
    {
        if(imparPar %2 == 0)
        {
            Debug.Log("O numero é par");
        }else
        {
            Debug.Log("O munero é impar");
        }
    }
    public void _6Questao()
    {
        if(divPor5 %5 == 0)
        {
            Debug.Log("O numero é divisivel por 5");
        }else
        {
            Debug.Log("O numero não é divisil por 5");
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
            Debug.Log("O aluno " + nome1 + "esta  de recuperação");
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
                Debug.Log("O valor a pagar é" + kWh * 1.3f);
            break;
            case 2:
                Debug.Log("O valor a pagar é" + kWh * 2.2f);
            break;
            case 3:
                Debug.Log("O valor a pagar é" + kWh * 3.1f);
            break;
            default:
                Debug.Log("Não existe essa opção");
            break;
        }
    }
    public void _9Questao()
    {
        if(lado1 == lado2 && lado1 == lado3)
        {
            Debug.Log("O triangulo é Equilatero");
        }
        if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Debug.Log("O triangulo é Isoceles");
        }else
        {
            Debug.Log("O triangulo é Escaleno");
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
                Debug.Log("O preço é: R$ 5,30");
            break;
            case "XYPK":
                Debug.Log("O preço é: R$ 6,00");
            break;
            case "KLMP":
                Debug.Log("O preço é: R$ 3,20");
            break;
            case "QRST":
                Debug.Log("O preço é: R$ 2,50");
            break;
            default:
                Debug.Log("Não existe essa opção");
            break;
        }
    }
}
