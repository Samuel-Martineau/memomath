using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sources : MonoBehaviour {

    public string[] source;
    

    private void Start()
    {
        foreach(string item in source)
        {
            Debug.Log(item);
        }

    }
}
