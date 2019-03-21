using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnding : MonoBehaviour
{
    public GameObject player;
    public Camera main;
    public GameObject deathNet;
    public static int level = 0;

    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            levelUp();
        }
    }

    void levelUp()
    {
        level++;
        Vector3 newLevel = new Vector3(level *25, 0, 0);
        player.transform.position = newLevel;
        main.GetComponent<BandicootCam>().incrementLevel();
        deathNet.GetComponent<deathNetCollider>().incrementLevel();
    }
}
