using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadioRTL
{
    /// <summary>
    /// Théo Valet
    /// </summary>
}
public class PlayerBehavior : MonoBehaviour
{
    private bool OnPreparation = false;
    private bool CrabIsLock = false;
    private bool Frappe = false;

    public GameObject NormalCrab;
    private void Update()
    {

        if (Input.GetButtonDown("Préparation"))
            OnPreparation = true;

        if (Input.GetButtonUp("Frappe"))
            Frappe = true;

    }
}
