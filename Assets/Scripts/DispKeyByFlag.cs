using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispKeyByFlag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariable.flagA == false)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
