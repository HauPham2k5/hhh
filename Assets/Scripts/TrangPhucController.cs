using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangPhucController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TrangPhuc;
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }

   void OnClick()
    {
        ShowMenu();
    }
    public void ShowMenu()
    {
        TrangPhuc.SetActive(true);
    }
}
