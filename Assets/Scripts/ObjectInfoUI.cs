using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInfoUI : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI densityText;
    public TextMeshProUGUI sizeText;
    public TextMeshProUGUI orbitText;
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI funFactText;

    public void Start()
    {
        panel.SetActive(false);
    }

    public void ShowInfo(string name)
    {
        nameText.text = name;
        switch (name)
        {
            case "Mercury":
                descriptionText.text =
                    "Description: Smallest planet in the solar system and closest to the Sun. Rocky surface full of craters, similar to our Moon. Very thin atmosphere.";
                sizeText.text = "Size: Diameter 4,880 km (\u2248 38% of Earth)";
                densityText.text = "Density:  5.43 g/cm\u00b3";
                orbitText.text = "Orbit: 88 Earth days";
                dayText.text = "Day: 59 Earth days";
                funFactText.text =
                    "Fun fact: A year on Mercury is only 88 Earth days, but a single day lasts almost 59 Earth days!";
                break;
            default:
                descriptionText.text =
                    "Description: ";
                sizeText.text = "Size: ";
                densityText.text = "Density:  ";
                orbitText.text = "Orbit: ";
                dayText.text = "Day: ";
                funFactText.text =
                    "Fun fact: ";
                break;
        }
        panel.SetActive(true);
    }

    public void HideInfo()
    {
        panel.SetActive(false);
    }   
}
