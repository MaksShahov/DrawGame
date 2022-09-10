using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public Camera cam;
    [SerializeField] private Line linePrefab;
    private Line _currentLine;
    public bool candraw=true;
    // Start is called before the first frame update
    private void Start()
    {
        cam = Camera.main;
    }
    public void CantDraw()
    {
        candraw = false;
    }
    public void CanDraw()
    {
        candraw = true;
    }
    // Update is called once per frame
    private void Update()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (candraw == true)
        {
            if (Input.GetMouseButtonDown(0)) _currentLine = Instantiate(linePrefab, mousePos, Quaternion.identity);
            if (Input.GetMouseButton(0)) _currentLine.SetPosition(mousePos);
        }
    }
}
