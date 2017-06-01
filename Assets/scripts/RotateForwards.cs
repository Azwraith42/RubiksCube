using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateForwards : MonoBehaviour{

    private bool _isRotating = false;
    public Button button;

    public void rotateForwards() {
        button.interactable = false;
        _isRotating = true;
    }

    IEnumerator TurnUp() {
        for (int i = 0; i < 90; i++) {
            this.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(1, 0, 0), -1f);
            yield return null;
        }
        button.interactable = true;
    }

    // Update is called once per frame
    void Update() {
        if (_isRotating) {
            _isRotating = false;
            StartCoroutine("TurnUp");
        }
    }
}
