using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthpoints : MonoBehaviour
{   
    // En referens till en slider (eller health bar) -Henry
    public Slider slider; 

    public void SetMaxHealth(int health)
    {
        // Sätter max-värdet av slidern -Henry
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        // Sätter health-värdet av slidern till det värde som tas in -Henry
        slider.value = health;
    }
}
