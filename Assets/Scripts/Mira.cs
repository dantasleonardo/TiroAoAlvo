using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    private Vector3 m_Mouse;
    public new GameObject m_Arma;
    public AudioSource m_SomTiro;

    //todo o código está alocado no GameObject da mira
    private void SomTiro()
    {
        if(Input.GetMouseButtonDown(0))
        {
            m_SomTiro.Play();
        }
    }

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        m_Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(m_Mouse.x, m_Mouse.y, transform.position.z);
        m_Arma.transform.position = new Vector3(m_Mouse.x + 2, m_Arma.transform.position.y, transform.position.z);

        SomTiro();
    }
}
