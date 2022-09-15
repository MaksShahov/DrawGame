using UnityEngine;
using UnityEngine.UI;

public class ResolutionChanger : MonoBehaviour
{
    [SerializeField] private Scrollbar resolutionscroll;
    public LineRenderer line;
    public void Start()
    {
        line.startWidth = resolutionscroll.value;
        line.endWidth = resolutionscroll.value;
    }
    public void ResolutionChange()
    {
        line.startWidth = resolutionscroll.value;
        line.endWidth = resolutionscroll.value;
    }
}
