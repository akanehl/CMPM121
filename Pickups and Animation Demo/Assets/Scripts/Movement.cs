using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rig;
    public float speed = 10;
    public Camera a_Camera;
    public Camera b_Camera;
    public Camera c_Camera;
    public GameObject FlashLight;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        a_Camera.enabled = true;
        b_Camera.enabled = false;
        c_Camera.enabled = false;
        FlashLight.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(haxis, 0, vaxis) * speed * Time.deltaTime;

        rig.MovePosition(transform.position + movement);

        if (Input.GetKeyDown(KeyCode.F))
        {
            FlashLight.SetActive(!FlashLight.activeSelf);
        }
    }
}
