using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjet : MonoBehaviour
{
    public float speed;
    private Vector3 positionInicial;
    // Start is called before the first frame update
    void Start()
    {
        positionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime*2;
        transform.position = new Vector3(speed, positionInicial.y, positionInicial.z);
    }
}
