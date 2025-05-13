using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GazeTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float gazeTime = 2.0f; // Time in seconds to trigger action
    private float timer = 0.0f;
    private bool isGazing = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isGazing = true;
        timer = 0.0f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isGazing = false;
        timer = 0.0f;
    }

    void Update()
    {
        if (isGazing)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                Button button = GetComponent<Button>();
                if (button != null)
                {
                    button.onClick.Invoke();
                }
                timer = 0.0f; // Reset timer
            }
        }
    }
}