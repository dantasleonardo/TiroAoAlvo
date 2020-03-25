using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcarPonto : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<GameManager>().AdicionarPonto();
        Destroy(this.gameObject);
    }
}
