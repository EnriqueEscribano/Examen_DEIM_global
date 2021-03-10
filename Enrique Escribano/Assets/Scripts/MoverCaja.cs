using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverCaja : MonoBehaviour
{

    private string currentTime;
    private float speed = 100f;
    
    [SerializeField] GameObject Cesta;
    [SerializeField] MeshRenderer myMesh;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
        PulsarBotón();

    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosZ = transform.position.z;
        float desplX = Input.GetAxis("Horizontal");
        float desplZ = Input.GetAxis("Vertical");

        //Restringir movimiento horizontal
        if ((PosX < 120 || desplX < 0) && (PosX > -120 || desplX > 0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Restringir movimiento eje Z
       
        if ((PosZ < 160 || desplZ < 0) && (PosZ > -160 || desplZ > 0))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }

        // las || significan or.
    }
    void PulsarBotón()  //Pulsar botón para que aparezca la cesta
    {

        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            other.Cesta.tag == "Cesta" = true;
            if (other.gameObject.tag == "Cesta")
            {

                //Desactivamos el render y cambiamos la booleana de vivo a false para que se pare la nave.
                myMesh.enabled = false;

            }
        }
        //Necesito que primero se active la cesta.
       
        if (Input.GetKey(KeyCode.JoystickButton5))
        {
  
        }

    }
    
}