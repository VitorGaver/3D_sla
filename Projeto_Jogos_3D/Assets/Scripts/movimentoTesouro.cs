using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoTesouro : MonoBehaviour
{
    public Vector3 girar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(girar);
    }
}
