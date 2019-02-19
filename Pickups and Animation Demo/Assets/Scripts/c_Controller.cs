using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_Controller : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 zeroX;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        zeroX = new Vector3 (0, transform.position.y, transform.position.z);
        transform.position = zeroX;
    }
}
