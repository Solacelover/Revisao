using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desvio : MonoBehaviour
{
    //prieira quest�o
    float n1,n2;
    //segunda quest�o
    float maior, menor;
    //terceira quest�o
    public int senha;
    // Start is called before the first frame update
    void Start()
    {
        _1Questao();
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
}
