using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float m_VelocidadePato;
    public float m_TempoDestruicao;

    public void Start()
    {
        //Destrói os patos depois de X tempo
        Destroy(this.gameObject, m_TempoDestruicao);
    }

    private void Update()
    {
        transform.position += Vector3.right * m_VelocidadePato * Time.deltaTime;
    }
}
