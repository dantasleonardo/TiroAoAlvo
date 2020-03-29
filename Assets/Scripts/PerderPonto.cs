using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerderPonto : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (FindObjectOfType<GameManager>().m_ContinuarJogando == true)
        {
            FindObjectOfType<GameManager>().RetirarPonto();
            Destroy(this.gameObject);
        }
    }
}
