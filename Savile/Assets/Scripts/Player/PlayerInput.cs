using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerController m_playerController;

    void Start()
    {
        m_playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        //Run
        if (Input.GetKey(KeyCode.LeftShift))
        {
            m_playerController.SetPlayerRun(true);
        }

        //Walk
        else
        {
            m_playerController.SetPlayerRun(false);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            //Interact
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            //Inventory
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Pause
        }

    }

    public float GetHorizontalAxis()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public float GetVerticalAxis()
    {
        return Input.GetAxisRaw("Vertical");
    }
}
