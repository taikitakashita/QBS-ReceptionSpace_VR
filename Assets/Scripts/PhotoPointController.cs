using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPointController : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Button PhotoPointButton = GetComponent<Button>();    // 対象のボタン
        PhotoPointButton.animator.SetTrigger("Normal");
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
