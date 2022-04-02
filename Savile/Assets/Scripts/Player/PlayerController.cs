using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private PlayerInput m_PlayerInput;
    private PlayerAnimator m_Animator;
    private PlayerInteraction m_PlayerInteraction;
    private CharacterController characterController;

    private float playerSpeed;
    private bool isRunning;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float rotateSmoothTime;
    private float rotateSmoothVelocity;


    void Start()
    {
        m_PlayerInput = GetComponent<PlayerInput>();
        m_PlayerInteraction = GetComponent<PlayerInteraction>();
        m_Animator = GetComponent<PlayerAnimator>();
        characterController = GetComponent<CharacterController>();

        playerSpeed = walkSpeed;
    }

    void Update()
    {
        float horizontal = m_PlayerInput.GetHorizontalAxis();
        float vertical = m_PlayerInput.GetVerticalAxis();
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            if (!isRunning)
            {
                playerSpeed = walkSpeed;
                m_Animator.SetRunAnimation(false);
            }

            else
            {
                playerSpeed = runSpeed;
                m_Animator.SetRunAnimation(true);
            }

            characterController.Move(direction * playerSpeed * Time.deltaTime);
            m_Animator.SetWalkAnimation(true);

            float rotateAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotateAngle, ref rotateSmoothVelocity, rotateSmoothTime);
            transform.rotation = Quaternion.Euler(0, smoothAngle, 0);

        }

        else
        {
            m_Animator.SetWalkAnimation(false);
        }
    }

    public void SetPlayerRun(bool state)
    {
        isRunning = state;
    }


}
