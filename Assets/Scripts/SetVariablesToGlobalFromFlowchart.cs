using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariablesToGlobalFromFlowchart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlagAOn()
    {
        GlobalVariable.flagA = true;
    }

    public void FlagAOff()
    {
        GlobalVariable.flagA = false;
    }

    public void FlagBOn()
    {
        GlobalVariable.flagB = true;
    }

    public void FlagBOff()
    {
        GlobalVariable.flagB = false;
    }

    public void FlagCOn()
    {
        GlobalVariable.flagC = true;
    }

    public void FlagCOff()
    {
        GlobalVariable.flagC = false;
    }

}
