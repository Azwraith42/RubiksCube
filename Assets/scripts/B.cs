using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B : MonoBehaviour {

    private bool _isRotating = false;
    public Button button;


    public void rotateB() {
        button.interactable = false;
        _isRotating = true;
    }

    IEnumerator TurnB() {
        List<Transform> tList = new List<Transform>();
        foreach (Transform child in this.transform) {
            if (child.position.z > 0.6) {
                // add child to list of things we will move
                tList.Add(child);
            }
        }


        for (int i = 0; i < 90; i++) {
            //get all planes at y = 1
            //this.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 1f);
            foreach (Transform curr in tList) {
                curr.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 1f);
            }
            yield return null;
        }
        button.interactable = true;
    }

    // Update is called once per frame
    void Update() {
        if (_isRotating) {
            _isRotating = false;
            StartCoroutine("TurnB");
        }
    }
}
