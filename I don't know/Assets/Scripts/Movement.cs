using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static UnityEditor.Searcher.SearcherWindow.Alignment;


public class Movement : MonoBehaviour
    
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    public float speed = 1;
    // Update is called once per frame
    public float horizantalInput;
    void Update()
        
    {
        float horizantalInput = Input.GetAxis("horizontal");
        float verticalInput = Input.GetAxis("vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizantalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    }
}
