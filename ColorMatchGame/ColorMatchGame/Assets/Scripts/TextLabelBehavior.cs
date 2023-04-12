using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Globalization;

// [RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;
    public int value;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
