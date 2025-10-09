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
    public Button closeButton;
    public void Start()
    {
        panel.SetActive(false);
    }

    public void ShowInfo(string name)
    {
        nameText.text = name;
        switch (name.ToLower())
        {
            case "mercury":
                descriptionText.text = "Description: Smallest planet and closest to the Sun. A rocky, cratered world with almost no atmosphere and huge temperature swings.";
                sizeText.text = "Size: Diameter 4,880 km (≈ 38% of Earth)";
                densityText.text = "Density: 5.43 g/cm³";
                orbitText.text = "Orbit: 88 Earth days";
                dayText.text = "Day: 59 Earth days";
                funFactText.text = "Fun fact: A single day on Mercury lasts nearly two Mercury years!";
                break;
        
            case "venus":
                descriptionText.text = "Description: Earth-sized planet wrapped in thick clouds of CO₂ and sulfuric acid. Surface pressure is 90× Earth's — hot enough to melt lead.";
                sizeText.text = "Size: Diameter 12,104 km (≈ 95% of Earth)";
                densityText.text = "Density: 5.24 g/cm³";
                orbitText.text = "Orbit: 225 Earth days";
                dayText.text = "Day: 243 Earth days (retrograde)";
                funFactText.text = "Fun fact: Venus spins backward — the Sun rises in the west and sets in the east.";
                break;
        
            case "earth":
                descriptionText.text = "Description: Our home planet — the only known world with liquid water, a breathable atmosphere, and life. Dynamic surface shaped by plate tectonics.";
                sizeText.text = "Size: Diameter 12,742 km";
                densityText.text = "Density: 5.51 g/cm³ (highest of all planets)";
                orbitText.text = "Orbit: 365 days";
                dayText.text = "Day: 24 hours";
                funFactText.text = "Fun fact: About 70% of Earth's surface is covered by oceans, yet water makes up less than 0.1% of Earth's total mass.";
                break;
        
            case "mars":
                descriptionText.text = "Description: Known as the Red Planet due to its iron-rich dust. Home to Olympus Mons, the largest volcano, and Valles Marineris, the deepest canyon.";
                sizeText.text = "Size: Diameter 6,779 km (≈ 53% of Earth)";
                densityText.text = "Density: 3.93 g/cm³";
                orbitText.text = "Orbit: 687 Earth days";
                dayText.text = "Day: 24.6 hours";
                funFactText.text = "Fun fact: Mars has the largest volcano in the solar system — Olympus Mons is three times taller than Mount Everest.";
                break;
        
            case "jupiter":
                descriptionText.text = "Description: The giant of the solar system — a gas giant with a powerful magnetic field and dozens of moons. Its Great Red Spot is a storm centuries old.";
                sizeText.text = "Size: Diameter 139,820 km (≈ 11× Earth)";
                densityText.text = "Density: 1.33 g/cm³";
                orbitText.text = "Orbit: 11.9 Earth years";
                dayText.text = "Day: 10 hours";
                funFactText.text = "Fun fact: Jupiter is so massive it affects the orbits of other planets and protects Earth by deflecting comets.";
                break;
        
            case "saturn":
                descriptionText.text = "Description: Gas giant with iconic rings made of ice and rock particles. Has more than 80 moons, including Titan with thick atmosphere.";
                sizeText.text = "Size: Diameter 116,460 km (≈ 9.5× Earth)";
                densityText.text = "Density: 0.69 g/cm³ (less than water)";
                orbitText.text = "Orbit: 29.5 Earth years";
                dayText.text = "Day: 10.7 hours";
                funFactText.text = "Fun fact: Saturn would float in water because it’s less dense than liquid water!";
                break;
        
            case "uranus":
                descriptionText.text = "Description: An ice giant tipped on its side with a 98° axial tilt, making it roll around the Sun. Pale blue-green color from methane gas.";
                sizeText.text = "Size: Diameter 50,724 km (≈ 4× Earth)";
                densityText.text = "Density: 1.27 g/cm³";
                orbitText.text = "Orbit: 84 Earth years";
                dayText.text = "Day: 17 hours (retrograde)";
                funFactText.text = "Fun fact: Because of its tilt, each pole gets 42 years of continuous sunlight followed by 42 years of darkness.";
                break;
        
            case "neptune":
                descriptionText.text = "Description: The farthest planet, an ice giant with deep blue color and the strongest winds in the solar system — up to 2,100 km/h.";
                sizeText.text = "Size: Diameter 49,244 km (≈ 3.9× Earth)";
                densityText.text = "Density: 1.64 g/cm³";
                orbitText.text = "Orbit: 165 Earth years";
                dayText.text = "Day: 16 hours";
                funFactText.text = "Fun fact: Neptune was the first planet found using math before it was actually seen through a telescope.";
                break;
            case "sun":
                    nameText.text = "Sun";
                    descriptionText.text = "Description: The Sun is a massive sphere of hot plasma at the center of our solar system. It provides the energy that sustains all life on Earth through light and heat produced by nuclear fusion.";
                    sizeText.text = "Size: Diameter 1,392,700 km (≈ 109× Earth)";
                    densityText.text = "Density: 1.41 g/cm³";
                    orbitText.text = "Orbit: The Sun does not orbit; planets orbit around it.";
                    dayText.text = "Day: Rotates every 25 Earth days at the equator (35 days at poles)";
                    funFactText.text = "Fun fact: The Sun makes up about 99.8% of the total mass of our entire solar system!";
                    break;
        
            default:
                break;
        }
        
        panel.SetActive(true);
    }

    public void HideInfo()
    {
        panel.SetActive(false);
    }
    public Button GetButton()
    {
        return closeButton;
    }
}
