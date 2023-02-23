using System.Globalization;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehavoir : MonoBehaviour
{
    public Text label;
    public FloatData1 dataObj;


    private void Start()
    {
        label = GetComponent<Text>();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);

    }
}
