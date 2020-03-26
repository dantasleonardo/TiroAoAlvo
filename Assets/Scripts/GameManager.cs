using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int m_pontuacaoAtual;
    public Text m_Pontuacao; 

    public void AdicionarPonto()
    {
        m_pontuacaoAtual += 1;
        m_Pontuacao.text = "Pontuação: " + m_pontuacaoAtual;
    }

    public void RetirarPonto()
    {
        m_pontuacaoAtual -= 1;
        m_Pontuacao.text = "Pontuação: " + m_pontuacaoAtual;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
