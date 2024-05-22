using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desvio : MonoBehaviour
{
    //prieira questão
    float n1,n2;
    //segunda questão
    float maior, menor;
    //terceira questão
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
}
