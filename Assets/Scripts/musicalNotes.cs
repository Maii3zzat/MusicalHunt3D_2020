using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicalNotes : MonoBehaviour {
    public int notesnumber;
    public AudioSource strum;

    void Start()
    {
        strum = GetComponent<AudioSource>();
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            notesnumber++;
            GetComponent<AudioSource>().Play();
            this.gameObject.transform.localScale = new Vector3(0, 0, 0);
            Destroy(this.gameObject, 3f);
           
            
        }
    }

    
}
