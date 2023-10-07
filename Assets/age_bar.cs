
using UnityEngine;
using UnityEngine.UI;

public class age_bar : MonoBehaviour
{
    private Slider slider ;
    private int minAge = 0, maxAge = 80;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void set(int age)
    {
        if (age < minAge) age = minAge;
        if(age > maxAge)age =maxAge;
        slider.value = age;
    }
    public int get()
    {
        return (int)slider.value;
    }
}
