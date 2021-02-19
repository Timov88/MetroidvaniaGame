using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{

    float m_LastPressTime;
    float m_PressDelay = 0.5f;
 
    void OnButtonPress()
    {
    if (m_LastPressTime + m_PressDelay > Time.unscaledTime)
        return;
    m_LastPressTime = Time.unscaledTime;
 
    
    }
}
