using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownList : MonoBehaviour {

    public Dropdown continents;
    public Dropdown regions;


    public Dropdown m_Dropdown;
    int m_DropdownValue;

    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
        Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);
    }

    void Update () {

        m_DropdownValue = m_Dropdown.value;
        if (m_DropdownValue == 1)
        {
            continents.enabled = true;

        }
        if (m_DropdownValue == 2)
        {
            regions.enabled = true;

        }

    }
}
