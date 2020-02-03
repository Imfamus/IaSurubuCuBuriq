using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class lies : MonoBehaviour
{
    public int height;
    
    // Update is called once per frame
    void Update(){
            if (Input.GetKeyDown(KeyCode.Z))
            {
            GetComponent<RectTransform>();
            height += 100;
            }
        }
}
