using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickExample : MonoBehaviour
{
	public Button RatsvilleButton;
	public int index;

	void Start()
	{
		Button btn = RatsvilleButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}