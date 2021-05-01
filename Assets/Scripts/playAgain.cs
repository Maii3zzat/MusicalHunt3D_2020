using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playAgain : MonoBehaviour
   
{
    public void pAgain()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);

    }
}
