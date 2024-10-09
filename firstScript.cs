using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1_Script : MonoBehaviour
{
    public float speed_1 = 1.0f;  //public degisken Inspector'da görünür
    private float speed_2 = 0.5f; //private degisken sadece bu script icinde kullanılabilir
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, 0, 0); // Küpü x ekseninde tasima
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed_1 * Time.deltaTime;
        transform.position += new Vector3(0, moveVertical, 0); // Y ekseninde hareket

        /*
        float moveHorizontal = Input.GetAxis("Horizontal") * speed_1 * Time.deltaTime;
        transform.position += new Vector3(moveHorizontal, 0, 0); // X ekseninde hareket
        */
    }
}
