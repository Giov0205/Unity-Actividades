using UnityEngine;

public class CambioColorTecla : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;
    private bool alternativo;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            alternativo = !alternativo;
            spriteRenderer.color = alternativo ? Color.red : colorOriginal;
        }
    }
}