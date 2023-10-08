
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    private Slider slider;
    private float minHealth = 0, maxHealth = 100;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void set(float health)
    {
       slider.value= health <  minHealth ? minHealth : health>maxHealth? maxHealth:health;
       
    }
    public float get()
    {
        return slider.value;
    }
}
