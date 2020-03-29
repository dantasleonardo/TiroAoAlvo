using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcarPonto : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (FindObjectOfType<GameManager>().m_ContinuarJogando == true)
        {
            FindObjectOfType<GameManager>().AdicionarPonto();
            Destroy(this.gameObject);
        }
    }
}
