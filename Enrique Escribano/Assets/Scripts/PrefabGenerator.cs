﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyEgg;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform InitPos;
    //Distancia entre columnas
    [SerializeField] float dist;
    //Vector que usaremos para posicionar las columnas de inicio
    Vector3 newPos;
    private float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("EggCorrutine");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CrearHuevo();
        }

    }

    void CrearHuevo()
    {
        //Creo un nuevo vector3, para ello primero creo un número random, que es un número aleatorio entre los valores que le asigno, en este caso el 0 y el 10.
        float posRandom1 = Random.Range(0f, 100f);
        float posRandom2 = Random.Range(0f, 100f);
        Vector3 DestPos = new Vector3(posRandom1, 0, posRandom2);
        Vector3 NewPos = InitPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia. Como tenemos su componente Transform, le indicamos que lo que quiero es su posición.
        Instantiate(MyEgg, NewPos, Quaternion.identity);
    }

    IEnumerator EggCorrutine()
    {

        for (int n = 0; ; n++)
        {
           
            CrearHuevo();
            yield return new WaitForSeconds(1);
        }
    }
}

