using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour
{
    public List<string> myList = new List<string>();
    public enum FLAGS
    {
        FLAG_0,
        FLAG_1,
        FLAG_2,
        FLAG_MAX,
    }
    public bool[] flags = new bool[(int)FLAGS.FLAG_MAX];


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            myList.Add("a");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myList.Add("b");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myList.Add("c");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            flags[(int)FLAGS.FLAG_0] = !flags[(int)FLAGS.FLAG_0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            flags[(int)FLAGS.FLAG_1] = !flags[(int)FLAGS.FLAG_1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            flags[(int)FLAGS.FLAG_2] = !flags[(int)FLAGS.FLAG_2];
        }
    }
}
