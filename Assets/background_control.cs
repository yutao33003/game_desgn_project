using UnityEngine;
using System.Collections;

public class background_control : MonoBehaviour {

    public SpriteRenderer spriteRenderer; // �Ϥ��� SpriteRenderer
    public Color startColor = Color.white; // �_�l�C��
    public Color endColor = new Color(176f / 255f, 176f / 255f, 176f / 255f, 1f); // �ؼ��C��
    public float transitionDuration = 2.0f; // ���ܮɪ�


    // Start is called before the first frame update
    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        StartCoroutine(ChangeColor());
    }

    private System.Collections.IEnumerator ChangeColor()
    {
        float elapsedTime = 0;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            spriteRenderer.color = Color.Lerp(startColor, endColor, t); // �C�⺥��
            yield return null;
        }

        // �T�O�������Υؼ��C��
        spriteRenderer.color = endColor;
    }
}
