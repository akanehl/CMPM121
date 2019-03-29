using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rig;
    [SerializeField]
    public float speed = 10;
    GameObject sphere;
    GameObject cube;
    GameObject capsule;



    // Start is called before the first frame update
    void Start()
    {
       
        rig = GetComponent<Rigidbody>();
        
        sphere = GameObject.FindWithTag("Sphere");
        cube = GameObject.FindWithTag("Cube");
        capsule =GameObject.FindWithTag("Capsule");

        
        
    }

    
    Vector3 move = new Vector3(0, 0, 0);
    Quaternion rotation = new Quaternion(0,0,0,0);
    Vector3 scale = new Vector3(0, 0, 0);
    Color c = new Color(0, 0, 0, 1);
    float shape = 1;
    


    // Update is called once per frame
    void Update()
    {



        //MOVEMENT
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(haxis, 0, vaxis)*speed*Time.deltaTime;

        rig.MovePosition(transform.position + movement);
        

       //SCALE 
       Vector3 scalar = new Vector3(1, 1, 1);
       if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale= transform.localScale + scalar;
        }
       if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale= transform.localScale - scalar;
        }

        //ROTATE
       if (Input.GetKeyDown(KeyCode.X))
        {
            transform.Rotate(10, 0, 0);
        }
       if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.Rotate(0, 10, 0);
        }
       if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(0, 0, 10);
        }


        //Color Changing
       if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
       if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;          
        }
       if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

       //Enable Gravity
       if(Input.GetKeyDown(KeyCode.T))
        {
            rig.useGravity = true;
        }

        //Shape Changing
        if (Input.GetKeyDown(KeyCode.C))
        {
            cube.SetActive(true);
            sphere.SetActive(false);
            capsule.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            sphere.SetActive(false);
            cube.SetActive(false);
            capsule.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            sphere.SetActive(true);
            cube.SetActive(false);
            capsule.SetActive(false);
        }

        //Save/Load
        if (Input.GetKeyDown(KeyCode.O)) 
        {
            move = transform.position;
            rotation = transform.localRotation;
            scale = transform.localScale;
            c = GetComponent<Renderer>().material.color;
            if (cube.activeSelf)
            {
                shape = 1;
            }
            if (sphere.activeSelf)
            {
                shape = 2;
            }
            if (capsule.activeSelf)
            {
                shape = 3;
            }

        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (shape == 1)
            {
                cube.SetActive(true);
                sphere.SetActive(false);
                capsule.SetActive(false);
            }
            if (shape == 2)
            {
                sphere.SetActive(true);
                cube.SetActive(false);
                capsule.SetActive(false);
            }
            if (shape == 3)
            {
                sphere.SetActive(false);
                cube.SetActive(false);
                capsule.SetActive(true);
            }

            rig.MovePosition(move);
            transform.localRotation = rotation;
            transform.localScale = scale;
            GetComponent<Renderer>().material.color = c;



        }
    }
}
