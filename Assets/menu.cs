using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
  private UIDocument document;
  private Button botaotrair;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaotrair= document.rootVisualElement.Q<Button>("btn_trair");
        botaotrair.RegisterCallback<ClickEvent>(OnPlayGame);
    }
    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
}
