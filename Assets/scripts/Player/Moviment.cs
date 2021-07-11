using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float mSpeed;

    public float speedCamera = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f; 
    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 200f; 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.None;
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        yaw += speedCamera * Input.GetAxis("Mouse X");
        pitch -= speedCamera * Input.GetAxis("Mouse Y");
		if (pitch > 5)
			pitch = 5;
		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
    }
}
