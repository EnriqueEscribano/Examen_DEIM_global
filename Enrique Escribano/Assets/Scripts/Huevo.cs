using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{

    [SerializeField] MeshRenderer myMesh;


    void OnTriggerEnter(Collider other)            //Other se refiere para cualquier otro objeto, en este caso el plano

    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);          //This se refiere a la clase en la que estamos, en este caso Huevo

        }
        if (other.gameObject.tag == "Cesta")
        {
            Destroy(this.gameObject);          //This se refiere a la clase en la que estamos, en este caso Huevo

        }
    }

}


//En principio los huevos tendrían que bajar puesto que tienen activado el use gravity.
