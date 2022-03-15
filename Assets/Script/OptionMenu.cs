using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown ResolutionDropdown;


    void Start()
    {

        resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string Option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(Option);


        }

        ResolutionDropdown.AddOptions(options);

    }
}
