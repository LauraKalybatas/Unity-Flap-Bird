using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
