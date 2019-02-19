using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraSwitch : MonoBehaviour
{

    public Camera a_Camera;
    public Camera b_Camera;
    public Camera c_Camera;
    public GameObject DoorAC;
    public GameObject DoorBC;
    private Vector3 move = new Vector3(1, 0, 0);
    private float points = 0;

    // Start is called before the first frame update
    void Start()
    {
        a_Camera.enabled = true;
        b_Camera.enabled = false;
        c_Camera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(points >= 2)
        {
            OpenDoor(DoorAC);
        }
        if(points >= 6)
        {
            OpenDoor(DoorBC);
        }
        if(points == 10)
        {
            SceneManager.LoadScene("Title");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ac_Trigger"))
        {
            a_Camera.enabled = !a_Camera.enabled;
            c_Camera.enabled = !c_Camera.enabled;
        }
        if (other.gameObject.CompareTag("bc_Trigger"))
        {
            b_Camera.enabled = !b_Camera.enabled;
            c_Camera.enabled = !c_Camera.enabled;
        }
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            points++;
        }
    }

    void OpenDoor(GameObject d)
    {
        d.transform.position = d.transform.position + move;
    }
}
