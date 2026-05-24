using UnityEngine;
using TMPro;

public class ControlFuentes : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float tamañoMinimo = 20f;
    public float tamañoMaximo = 100f;

    public void AumentarFuente()
    {
        if (texto.fontSize < tamañoMaximo)
        {
            texto.fontSize += 5;
        }
    }

    public void DisminuirFuente()
    {
        if (texto.fontSize > tamañoMinimo)
        {
            texto.fontSize -= 5;
        }
    }
}