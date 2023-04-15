using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIdDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void SetColorRandomly()
    {
        num = Random.Range(0, colorIDList.Count);
        currentColor = colorIDList[num];
    }
}
