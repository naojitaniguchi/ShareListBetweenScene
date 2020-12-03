using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetValues : MonoBehaviour
{
    public string globalValueTag = "GlobalVale";
    public string stringCollectionTag = "StringCollection";
    GameObject valuesObj;
    GameObject stringCollectionObj;
    Values values;
    Fungus.StringCollection stringCollection;


    // Start is called before the first frame update
    void Start()
    {
        valuesObj = GameObject.FindGameObjectWithTag(globalValueTag);
        values = valuesObj.GetComponent<Values>();

        stringCollectionObj = GameObject.FindGameObjectWithTag(stringCollectionTag);
        stringCollection = stringCollectionObj.GetComponent<Fungus.StringCollection>();

        for (int i = 0; i < values.myList.Count; i++)
        {
            Debug.Log(values.myList[i]);
        }

        Debug.Log(values.flags[(int)Values.FLAGS.FLAG_0]);
        Debug.Log(values.flags[(int)Values.FLAGS.FLAG_1]);
        Debug.Log(values.flags[(int)Values.FLAGS.FLAG_2]);

        setValuesToStringCollection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValuesFromStringCollection()
    {
        for ( int i = 0; i < stringCollection.Count; i ++)
        {
            Debug.Log((string)stringCollection.Get(i));

            values.myList.Add((string)stringCollection.Get(i));
        }
    }

    public void setValuesToStringCollection()
    {
        for (int i = 0; i < values.myList.Count; i++)
        {
            stringCollection.Add(values.myList[i]);
        }
    }

}
