using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSettings : MonoBehaviour
{
    public void HideShow() => 
        gameObject.SetActive(!isActiveAndEnabled);

}
