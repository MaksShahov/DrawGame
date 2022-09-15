using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Palette : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool opened=false;
    private bool canchange = true;
    private void Check()
    {
        if (opened == false && canchange == true)
        {
            Open();
        }
        if (opened == true && canchange == true)
        {
            Close();
        }
    }
    public void Open()
    {
        StartCoroutine(Changing());
        panel.transform.DOScaleX(1, 0.5f);
        panel.transform.DOScaleY(0.25f, 0.5f);
        opened = true;
    }
    public void Close()
    {
        StartCoroutine(Changing());
        panel.transform.DOScaleX(0, 0.5f);
        panel.transform.DOScaleY(0, 0.5f);
        opened = false;
    }
    private IEnumerator Changing()
    {
        canchange = false;
        yield return new WaitForSeconds(0.5f);
        canchange = true;
    }
}
