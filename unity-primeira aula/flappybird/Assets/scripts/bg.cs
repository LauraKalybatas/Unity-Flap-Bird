using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoImgNaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImgReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoImgNaCena = tamanhoImgReal * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImgNaCena);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
