using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariableToFlowchartFromGlobal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setFlagA()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetBooleanVariable("FlagA", GlobalVariable.flagA);
    }

    public void setFlagB()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetBooleanVariable("FlagB", GlobalVariable.flagB);
    }

    public void setFlagC()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetBooleanVariable("FlagC", GlobalVariable.flagC);
    }

}
