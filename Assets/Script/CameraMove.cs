using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5.0f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (gameManager.gameStart)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
    }
}
