using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float m_VelocidadePato;

    private void Update()
    {
        transform.position += Vector3.right * m_VelocidadePato * Time.deltaTime;
    }
}
