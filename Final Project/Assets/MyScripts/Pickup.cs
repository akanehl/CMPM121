using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    public Text countText;
    private static float count;
    public AudioSource pickupSound;
    public AudioClip mySound;
    // Start is called before the first frame update
    void Start()
    {
        pickupSound.clip = mySound;
        count = 0;
        countText.text = "Bolts: " + count.ToString();
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
            pickupSound.Play();
            this.gameObject.SetActive(false);
            count++;
            countText.text = "Bolts: " + count.ToString();
            


        }
    }
}
