using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uicontroller : MonoBehaviour
{
    //private int V = 90;
    public int value = 0;
    public GameObject bara;
    public Vector3 position;

    private void OnMouseDown()
    {
       // GetComponent<RectTransform>().rotation.x = V;
    }



    void Update()
    {
        // update money
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("moneyz added");
            value += 10;
        }
    }
}
