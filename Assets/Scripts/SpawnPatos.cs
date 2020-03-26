using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPatos : MonoBehaviour
{
    public GameObject[] m_SpawnPatos;
    public float m_TempoToSpawn;
    public float m_TempoAtual;

    void Update()
    {
        m_TempoAtual -= Time.deltaTime;

        if (m_TempoAtual <= 0)
        {
            SpawnarPatos();
        }
    }

    public void SpawnarPatos()
    {
        int m_ValorAleatorio = Random.Range(0, m_SpawnPatos.Length);
        Instantiate(m_SpawnPatos[m_ValorAleatorio], transform.position, transform.rotation);
        m_TempoAtual = m_TempoToSpawn;
    }
}
