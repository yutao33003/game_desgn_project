using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] objectsToShow; // 需要依次顯示的物件
    public float delayBetweenObjects = 1.0f; // 每個物件之間的延遲時間
    public float fadeDuration = 0.5f; // 漸變顯示的時長

    void Start()
    {
        StartCoroutine(ShowObjectsInSequence());
    }

    private IEnumerator ShowObjectsInSequence()
    {
        // 確保所有物件在開始時都是隱藏狀態
        foreach (GameObject obj in objectsToShow)
        {
            if (obj != null)
            {
                SetObjectAlpha(obj, 0); // 設置透明
                obj.SetActive(true);    // 激活物件以啟用渲染器
            }
        }

        // 按順序顯示物件
        foreach (GameObject obj in objectsToShow)
        {
            if (obj != null)
            {
                yield return StartCoroutine(FadeInObject(obj));
                yield return new WaitForSeconds(delayBetweenObjects);
            }
        }
    }

    private IEnumerator FadeInObject(GameObject obj)
    {
        SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();
        if (renderer == null)
        {
            Debug.LogWarning($"{obj.name} 缺少 SpriteRenderer，無法漸變顯示。");
            yield break;
        }

        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsedTime / fadeDuration);

            SetObjectAlpha(obj, alpha);

            yield return null;
        }

        // 確保完全顯示
        SetObjectAlpha(obj, 1);
    }

    private void SetObjectAlpha(GameObject obj, float alpha)
    {
        SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            Color color = renderer.color;
            color.a = alpha;
            renderer.color = color;
        }
    }
}

