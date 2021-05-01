using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rays : MonoBehaviour {
    Ray ray;
    RaycastHit hitInfo;
    public PlayerController michelle;
    public musicalNotes notes;
    public GameObject line;

    void Update()
    {

        ray = new Ray(transform.position, transform.right * 50);

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.tag == "gate" && notes.notesnumber !=15)
            {
            //   Debug.Log("red!");
                line.GetComponent<Renderer>().material.color = Color.red;
             
            }
            else if (hitInfo.transform.gameObject.tag == "gate" && (notes.notesnumber == 15))
            {
            //   Debug.Log("green!");
                line.GetComponent<Renderer>().material.color = Color.green;

            }
            else if (hitInfo.transform.gameObject.tag == "Player" && (notes.notesnumber == 15))
            {
               // Debug.Log("pass!");
                line.GetComponent<Renderer>().material.color = Color.green;
                SceneManager.LoadScene(sceneBuildIndex: 1);

            }
        }
    }

    
}