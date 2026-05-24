using UnityEngine;
using UnityEngine.InputSystem;

public class ArrastrarSprite : MonoBehaviour
{
    private bool arrastrando = false;
    private Vector3 offset;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos2D = Mouse.current.position.ReadValue();
        Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos2D.x, mousePos2D.y, 0));
        mousePos.z = 0;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                arrastrando = true;
                offset = transform.position - mousePos;
            }
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            arrastrando = false;
        }

        if (arrastrando)
        {
            transform.position = mousePos + offset;
        }
    }
}