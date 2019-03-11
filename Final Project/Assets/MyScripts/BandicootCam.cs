using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandicootCam : MonoBehaviour
{
    public GameObject player;
    private float offset;
    private Vector3 zOnly;
    public float level;
    private bool unlockYAxis;
    // Start is called before the first frame update
    void Start()
    {
        unlockYAxis = false;
        offset = transform.position.z;
        Camera.main.transform.rotation = Quaternion.Euler(30, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!unlockYAxis)
        {
            zOnly = new Vector3(level, 3, player.transform.position.z + offset);
        }
        if(unlockYAxis)
        {
            zOnly = new Vector3(level, player.transform.position.y + 3, player.transform.position.z + offset);
        }
        transform.position = zOnly;
        Debug.Log(unlockYAxis);
    }

    public void unlockY()
    {
        unlockYAxis = !unlockYAxis;
    }
        
    public void lockY()
    {
        unlockYAxis = false;
    }


    public void incrementLevel()
    {
        level += 25;
    }
}
