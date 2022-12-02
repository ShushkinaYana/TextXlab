using UnityEngine;

public class ToolChange : MonoBehaviour
{
    private int t_currentWeapon=0;
    [SerializeField] private Transform[] t_weapons;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (t_currentWeapon > t_weapons.Length)
            {
                t_currentWeapon = 0;
            }
            changeWeapon(t_currentWeapon);

            t_currentWeapon++;
        }
    }

    public void changeWeapon(int num)
    {
        for (int i = 0; i < t_weapons.Length; i++)
        {
            if (i == num)
                t_weapons[i].gameObject.SetActive(true);
            else
                t_weapons[i].gameObject.SetActive(false);
        }
    }
}
