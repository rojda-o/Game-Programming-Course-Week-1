using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    public float speed_1 = 1.0f; // Public değişken, Inspector'da görünür
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed_1 * Time.deltaTime; 
        transform.position += new Vector3(0, moveVertical, 0); // Y ekseninde hareket 

    }
}
