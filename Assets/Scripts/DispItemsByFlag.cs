using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispItemsByFlag : MonoBehaviour
{
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(GlobalVariable.flagA);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
