using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCaja : MonoBehaviour
{

    private float speed = 100f; 

    private string currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();

    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float posZ = transform.position.z;
        float desplX = Input.GetAxis("Horizontal");

        //Restringir movimiento horizontal
        if ((PosX < 100 || desplX < 0) && (PosX > 100 || desplX > 0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }


        // las || significan or.
    }
}
