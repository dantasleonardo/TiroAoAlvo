using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    private Vector3 m_Mouse;
    public new GameObject m_Arma;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        m_Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(m_Mouse.x, m_Mouse.y, transform.position.z);
        m_Arma.transform.position = new Vector3(m_Mouse.x + 2, m_Arma.transform.position.y, transform.position.z);
    }
}
