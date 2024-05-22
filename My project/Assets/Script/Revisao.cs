using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisao : MonoBehaviour
{
    //primeira questão
    public double n1, n2, n3;
    //segunda questão
    public string nome;
    //terceira questão
    public int numero1,numero2,numero3;
    public float media;
    //quarta questão
    public int sucessorEantecessor;
    //quinta questão
    public double areaDoQuadrado;
    //sexta questão
    public float dobroEatercaparte;
    //setima questão
    public float altura;
    public float largura;
    public float litrosDeTinta;
    //oitava questão
    public float dinheiro;
    //nona questão
    public float desconto;
    //decimal questão
    public float aumento;

    // Start is called before the first frame update
    void Start()
    {
        _1Questao();
        _2Questao();
        _3Questao();
        _4Questao();
        _5Questao();
        _6Questao();
        _7Questao();
        _8Questao();
        _9Questao();
        _10Questao();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _1Questao() 
    {
        Debug.Log(n1 + 2);
        Debug.Log(n2 + 3);
        Debug.Log(n3 + 8);
        Debug.Log(n2 + n3);
    }
    public void _2Questao() 
    {
        Debug.Log("Ola senhor(a) " + nome);
    }
    public void _3Questao()
    {   
        media = (numero1 + numero2 + numero3) / 3;   
        if(media >= 6)
        {
            Debug.Log("Aprovado");
        }else if(media < 6)
        {
            Debug.Log("repovado");
        }
    }
    public void _4Questao()
    {
        Debug.Log("O sucessor é " +  (sucessorEantecessor + 1).ToString());
        Debug.Log("O antecessor é" + (sucessorEantecessor - 1).ToString());
    }
    public void _5Questao()
    {
        Debug.Log("A area do quadrado " +(Math.Pow(areaDoQuadrado,2)).ToString() );
    }
    public void _6Questao()
    {
        Debug.Log("O dobro do numero é " + (dobroEatercaparte * 2).ToString());
        Debug.Log("E a terça parte é " + (dobroEatercaparte/3).ToString());
    }
    public void _7Questao()
    {
        litrosDeTinta = altura * largura / 2;
        Debug.Log("A quantidade de litros de tinta necessaria é de " +  litrosDeTinta.ToString());
    }
    public void _8Questao()
    {
        Debug.Log("A quantidade de dolares que pode ser comprado é de " + (dinheiro/5.15f).ToString());
    }
    public void _9Questao()
    {
        Debug.Log("O preço final é de " + (desconto * 0.95f).ToString());
    }
    public void _10Questao()
    {
        Debug.Log("O salario final " + (aumento * 1.15f).ToString());
    }
}
