using UnityEngine;
using UnityEngine.InputSystem;

public class ActivarAnimacion : MonoBehaviour
{
    private Animator animator;
    private bool girando = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                girando = !girando;
                animator.SetBool("Girando", girando);
            }
        }
    }
}