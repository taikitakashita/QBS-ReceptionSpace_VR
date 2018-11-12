using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    [SerializeField]
    GameObject m_canvas;

    private bool m_canvasStatus;

    // Use this for initialization
    void Start () {
        m_canvasStatus = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.Back) && m_canvasStatus == true)
        {
            m_canvas.SetActive(false);
            m_canvasStatus = false;
        }
        else if (OVRInput.Get(OVRInput.RawButton.Back) && m_canvasStatus == false)
        {
            m_canvas.SetActive(true);
            m_canvasStatus = true;
        }
    }
}
