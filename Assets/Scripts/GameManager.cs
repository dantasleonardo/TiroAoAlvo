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

    public bool m_Pause;
    public GameObject Pause;

    //Variavel para definir quando pode continuar marcando pontos
    public bool m_ContinuarJogando;

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

    public void Pausar()
    {
        if(m_Pause == false)
        {
            m_Pause = true;
            Time.timeScale = 0f;
            Cursor.visible = true;
            Pause.SetActive(true);
            m_ContinuarJogando = false;
        }
        else
        {
            m_Pause = false;
            Time.timeScale = 1f;
            Cursor.visible = false;
            Pause.SetActive(false);
            m_ContinuarJogando = true;
        }
    }

    private void Start()
    {
        m_ContinuarJogando = true;
        //Time.timeScale = 1f;
        m_TempoAtual = m_TempoMax;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }

        m_TempoAtual -= Time.deltaTime;
        AtualizarTempo();

        if(m_TempoAtual <= 0)
        {
            if(m_PontuacaoAtual > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", m_PontuacaoAtual);
            }

            m_TextoTempo.text = "0";
            Cursor.visible = true;
            GameOver.SetActive(true);
            Time.timeScale = 0f;
            m_ContinuarJogando = false;
        }
    }
}
