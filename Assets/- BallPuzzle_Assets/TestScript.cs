using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

class TestScript : MonoBehaviour
{
    //Basic Types
    public bool Switch = false; 
    public string Text = "Ciao";
    public int Number = 5;
    public float DecimalNumber = 5.56f;

    //Compound Types
    public Vector3 direction;
    public Color color;
    public Quaternion rotation;

    //Reference Types
    public GameObject gameObject;
    public Camera camera;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()    
    {
        NewValue();
    }

    void FixedUpdate(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewValue(){
        
    }

    
  
}
