using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoY;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private uiScript scriptDaUI;

    // Start is called before the first frame update
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));   
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<birdie>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<uiScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.pontuei && this.transform.position.x < posicaoPassaro.x){
            Debug.Log("Pontuou");
            this.pontuei = true;
            this.scriptDaUI.adicionarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
