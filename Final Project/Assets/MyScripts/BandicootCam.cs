using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandicootCam : MonoBehaviour
{
    public GameObject player;
    private float offset;
    private Vector3 zOnly;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.z;
        Camera.main.transform.rotation = Quaternion.Euler(30, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        zOnly = new Vector3(0, 3 ,player.transform.position.z + offset);
        transform.position = zOnly;
        
    }
}
