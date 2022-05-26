using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff_Create : MonoBehaviour
{
    public GameObject prefab;
        
    void Update()
    {
        if(Input.GetButtonDown("Fire2")){
            Instantiate(prefab, transform.position + transform.forward*5, transform.rotation);
        }
    }
}
