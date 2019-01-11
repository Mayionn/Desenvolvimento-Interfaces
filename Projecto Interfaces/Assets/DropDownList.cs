using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownList : MonoBehaviour {


    Dropdown m_Dropdown;
    public Canvas option1;
    public Canvas option2;



    int m_DropdownValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        m_Dropdown = GetComponent<Dropdown>();

        //Output the first Dropdown index value
        Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);
    }

    void Update()
    {

        m_DropdownValue = m_Dropdown.value;

        if (m_DropdownValue == 0)
        {
            option1.enabled = false;
            option2.enabled = false;
        }

        if (m_DropdownValue == 1)
        {
            option1.enabled = true;
            if (option2.enabled == true)
                option2.enabled = false;
        }

        if (m_DropdownValue == 2)
        {
            option2.enabled = true;
            if (option1.enabled == true)
                option1.enabled = false;
        }
    }
}
