using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {


    public musicalNotes note;
    public Text countnotes;

	void Update () {
        countnotes.text = note.notesnumber.ToString("00");

	}

}
