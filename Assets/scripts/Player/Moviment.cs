using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float mSpeed;
    public Camera camera; 
    public float speedCamera = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f; 
    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 10f; 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.None;
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        yaw = speedCamera * Input.GetAxis("Mouse X"); //horizontal
        pitch = speedCamera * Input.GetAxis("Mouse Y");  //vertical
        transform.Rotate(0, yaw, 0);
        camera.transform.Rotate(-pitch, 0, 0); 
    }
}
