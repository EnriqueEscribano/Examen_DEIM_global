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
        float PosZ = transform.position.z;
        float desplX = Input.GetAxis("Horizontal");
        float desplZ = Input.GetAxis("Vertical");

        //Restringir movimiento horizontal
        if ((PosX < 100 || desplX < 0) && (PosX > 100 || desplX > 0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Restringir movimiento eje Z
       
        if ((PosZ < 100 || desplZ < 0) && (PosZ > 100 || desplZ > 0))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }

        
        
        
        // las || significan or.
    }
}
