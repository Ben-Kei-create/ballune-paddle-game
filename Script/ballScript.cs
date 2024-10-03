using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float speed;
    void Start()
    {
     speed = Random.Range(5f, 15f);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) // Removed the 's' here
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            // ボールを破棄する
            Destroy(gameObject);
        }
    } // Ensure this closing brace is for the class
} // Ensure this is the closing brace for the ballScript class