using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Contém os scripts para todas as ações dos botões de menu e pause
public class Menu : MonoBehaviour
{
   public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Game");
    }

    public void Voltar()
    {
        FindObjectOfType<GameManager>().Pausar();
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Debug.Log("SAIU");
        Application.Quit();
    }
}
