using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IdContainerBehavior
{
    public ColorIdDataList colorIdDataListObj;

    private void Awake()
    {
        idObj = colorIdDataListObj.currentColor;
    }
}
