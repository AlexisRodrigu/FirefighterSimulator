using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    private float gravity = 10.0f;
    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }

    public void PointerEnter()
    {
        Debug.Log("<color=red><b>" + "Entras" + "</b></color>");
    }
    public void PointerExit()
    {
        Debug.Log("<color=yellow><b>" + "Sales" + "</b></color>");
    }
    public void PointerClick()
    {
        GameManager.Instance.StarGame(true);
    }
}
