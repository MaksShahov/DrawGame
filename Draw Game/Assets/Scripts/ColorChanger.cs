using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public LineRenderer linerenderer;
    public Material red;
    public Material blue;
    public Material darkblue;
    public Material white;
    public Material yellow;
    public Material orange;
    public Material violet;
    public Material green;
    public Material black;
    public Material eraser;
    // Start is called before the first frame update
    private void Start()
    {
        BlackColor();
    }
    public void RedColor()
    {
        linerenderer.material=red;
    }
    public void YellowColor()
    {
        linerenderer.material = yellow;
    }
    public void GreenColor()
    {
        linerenderer.material = green;
    }
    public void WhiteColor()
    {
        linerenderer.material = white;
    }
    public void OrangeColor()
    {
        linerenderer.material = orange;
    }
    public void VioletColor()
    {
        linerenderer.material = violet;
    }
    public void BlueColor()
    {
        linerenderer.material = blue;
    }
    public void DarkBlueColor()
    {
        linerenderer.material = darkblue;
    }
    public void BlackColor()
    {
        linerenderer.material = black;
    }
    public void Eraser()
    {
        linerenderer.material = eraser;
    }
}
