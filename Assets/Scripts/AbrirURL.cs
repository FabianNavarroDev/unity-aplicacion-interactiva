using UnityEngine;

public class AbrirURL : MonoBehaviour
{
    public string url;

    public void Abrir()
    {
        Application.OpenURL(url);
    }
}