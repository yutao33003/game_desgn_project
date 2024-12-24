using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] objectsToShow; // �ݭn�̦���ܪ�����
    public float delayBetweenObjects = 1.0f; // �C�Ӫ��󤧶�������ɶ�
    public float fadeDuration = 0.5f; // ������ܪ��ɪ�

    void Start()
    {
        StartCoroutine(ShowObjectsInSequence());
    }

    private IEnumerator ShowObjectsInSequence()
    {
        // �T�O�Ҧ�����b�}�l�ɳ��O���ê��A
        foreach (GameObject obj in objectsToShow)
        {
            if (obj != null)
            {
                SetObjectAlpha(obj, 0); // �]�m�z��
                obj.SetActive(true);    // �E������H�ҥδ�V��
            }
        }

        // ��������ܪ���
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
            Debug.LogWarning($"{obj.name} �ʤ� SpriteRenderer�A�L�k������ܡC");
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

        // �T�O�������
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

