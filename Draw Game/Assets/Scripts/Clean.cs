using UnityEngine;

public class Clean : MonoBehaviour
{
    private GameObject[] lines;
    public void Cleaner()
    {
        lines = GameObject.FindGameObjectsWithTag("Line");
        for(int i = 0; i < lines.Length; i++)
        {
            Destroy(lines[i].gameObject);
        }
    }
}
