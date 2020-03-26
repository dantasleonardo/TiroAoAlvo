using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerderPonto : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<GameManager>().RetirarPonto();
        Destroy(this.gameObject);
    }
}
