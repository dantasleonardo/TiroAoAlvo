using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int m_PontuacaoAtual;
    public Text m_Pontuacao; 

    public void AdicionarPonto()
    {
        m_PontuacaoAtual += 1;
        m_Pontuacao.text = "Pontuação: " + m_PontuacaoAtual;
    }

    public void RetirarPonto()
    {
        m_PontuacaoAtual -= 1;
        m_Pontuacao.text = "Pontuação: " + m_PontuacaoAtual;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
