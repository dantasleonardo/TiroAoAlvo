using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text m_TextoPontuacao;
    public Text m_TextoHighScore;

    void Start()
    {
        m_TextoPontuacao.text = "Pontuação: " + FindObjectOfType<GameManager>().m_PontuacaoAtual;
        m_TextoHighScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");
    }
}
