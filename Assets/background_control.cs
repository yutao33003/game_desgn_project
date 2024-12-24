using UnityEngine;
using System.Collections;

public class background_control : MonoBehaviour {

    public SpriteRenderer spriteRenderer; // 圖片的 SpriteRenderer
    public Color startColor = Color.white; // 起始顏色
    public Color endColor = new Color(176f / 255f, 176f / 255f, 176f / 255f, 1f); // 目標顏色
    public float transitionDuration = 2.0f; // 漸變時長


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
            spriteRenderer.color = Color.Lerp(startColor, endColor, t); // 顏色漸變
            yield return null;
        }

        // 確保完全應用目標顏色
        spriteRenderer.color = endColor;
    }
}
