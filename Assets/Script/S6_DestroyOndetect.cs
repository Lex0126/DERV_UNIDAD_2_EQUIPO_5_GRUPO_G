using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S6_DestroyOndetect : MonoBehaviour
{
   
    [SerializeField] TextMeshProUGUI text_c;
    int count;
    // Start is called before the first frame update
    void Start()
    {
               count =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Enemy")){
            Destroy(obj);
            count++;
            text_c.text = count.ToString();
        }
    }
    
}
