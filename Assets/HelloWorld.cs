using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myMessage; 
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello Player See My ball rolling over lava");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myMessage);}
}
