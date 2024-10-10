using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerTrampaCortine : MonoBehaviour
{
    // Start is called before the first frame update
    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;

    Transform spawn;

    [SerializeField] List <GameObject>lista_enemigos;

    int contador_enemigo_actual;
    void Awake(){
        spawn =GameObject.Find("Spawn Enemigos").transform;
    }
    void Start()
    {
        tiempo_para_nuevo_enemigo =1;
        contador_enemigo_actual= 0;
    }
    

    // Update is called once per frame
    void Update()
    {
       
        
    }
    IEnumerator corrutinaSpawn(){
        //tiempo_en_trigger += Time.deltaTime;
        while(tiempo_en_trigger>tiempo_para_nuevo_enemigo){
                    /// version con corrutina
            lista_enemigos[contador_enemigo_actual].transform.position =spawn.position;

            ///agrega una fuerza de empuje al enemigo hacia abajo
            lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce(-1 *10f*transform.up,ForceMode.Impulse);
            contador_enemigo_actual++;
            contador_enemigo_actual %= contador_enemigo_actual;
            tiempo_en_trigger =0;
        }
        yield return new WaitForSeconds(tiempo_para_nuevo_enemigo);

    }

    private void OnTriggerStay(Collider other){
        tiempo_en_trigger += Time.deltaTime;
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine("corrutinaSpawn");
            Debug.Log("Se inicio");

        }

    }

}
