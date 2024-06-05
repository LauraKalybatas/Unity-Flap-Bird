using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoY;
    // Start is called before the first frame update
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));   
    }

    // Update is called once per frame
    void Update()
    {
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
