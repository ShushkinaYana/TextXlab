using UnityEngine;

public class ToolChange : MonoBehaviour
{
    [SerializeField] Farmer[] m_farmer;

   public void Action()
    {
        foreach (var farmer in m_farmer)
        {
            farmer.ChangeTool();
        }
    }
}
