using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class S8_Cortina : MonoBehaviour

{
    int contador_segundos;

    [SerializeField] TextMeshProUGUI Tiempo;
    // Start is called before the first frame update
    void Start()
    {
        contador_segundos =0;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()

{

}
 IEnumerator corrutinaTiempo(){
        while (true){
            Tiempo.text = contador_segundos++.ToString();
            yield return new WaitForSeconds(0.25f);
    
        }
    }
}
