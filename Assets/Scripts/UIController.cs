using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    [SerializeField]
    GameObject m_canvas;

    [SerializeField]
    GameObject m_laserPointer;

    private bool m_UIStatus;

    // Use this for initialization
    void Start () {
        m_UIStatus = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.Back) && m_UIStatus == true)
        {
            m_canvas.SetActive(false);
            m_laserPointer.SetActive(false);
            m_UIStatus = false;
        }
        else if (OVRInput.Get(OVRInput.RawButton.Back) && m_UIStatus == false)
        {
            m_canvas.SetActive(true);
            m_laserPointer.SetActive(true);
            m_UIStatus = true;
        }
    }
}
