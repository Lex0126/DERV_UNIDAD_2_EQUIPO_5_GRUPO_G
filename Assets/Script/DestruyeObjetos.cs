using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter (Collision other){
        if(other.gameObject.CompareTag("Enemy")){
            GameObject obj = other.gameObject;
            Destroy(obj,3);
        }
    }
}
