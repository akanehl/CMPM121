using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathNetCollider : MonoBehaviour
{
    private int level;
    private Vector3 reset;
    public Camera main;
    // Start is called before the first frame update
    void Start()
    {
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        reset =new Vector3 (level*25 , 0 , 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = reset;
            main.GetComponent<BandicootCam>().lockY();
        }
    }

    public void incrementLevel()
    {
        level ++;
    }
}
