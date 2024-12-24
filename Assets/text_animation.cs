using System.Collections;
using UnityEngine;
using TMPro;

public class text_animation : MonoBehaviour
{
    public TMP_Text m_text;
    [Range(0, 0.5f)] public float speed = 0.1f;

    private void Awake()
    {
        gameObject.TryGetComponent<TMP_Text>(out m_text);
    }

    private void Start()
    {
        StartCoroutine(TypeWriter());
    }

    private IEnumerator TypeWriter()
    {
        m_text.ForceMeshUpdate();
        TMP_TextInfo textInfo = m_text.textInfo;
        int total = textInfo.characterCount;
        bool complete = false;
        int current = 0;

        while (!complete)
        {
            if (current > total)
            {
                current = total;
                yield return new WaitForSecondsRealtime(1);
                complete = true;
            }

            m_text.maxVisibleCharacters = current;
            current += 1;
            yield return new WaitForSecondsRealtime(speed);
        }

        yield return null;
    }
}

  
