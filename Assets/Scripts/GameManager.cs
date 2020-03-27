using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int m_PontuacaoAtual;
    public Text m_Pontuacao;

    public float m_TempoMax;
    public float m_TempoAtual;
    public Text m_TextoTempo;

    public GameObject GameOver;

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

    public void AtualizarTempo()
    {
        m_TextoTempo.text = Mathf.FloorToInt(m_TempoAtual).ToString();
    }

    private void Start()
    {
        m_TempoAtual = m_TempoMax;
    }

    void Update()
    {
        m_TempoAtual -= Time.deltaTime;
        AtualizarTempo();

        if(m_TempoAtual <= 0)
        {
            m_TextoTempo.text = "0";
            Cursor.visible = true;
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
