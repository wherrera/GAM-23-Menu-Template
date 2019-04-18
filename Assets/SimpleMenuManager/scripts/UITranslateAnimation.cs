using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITranslateAnimation : MonoBehaviour {

	private float m_Duration = 5f;
	private float m_Dt;
	private float m_Width;
	private Vector3 m_Start, m_End;

	private bool m_SetActive = true;

	public void AnimateOutLeft(float duration) {
		m_Duration = duration;
		m_Width = GetComponent<RectTransform>().rect.width;
		m_Start = Vector3.zero;
		m_End = new Vector3(m_Start.x-m_Width, m_Start.y, m_Start.z);
		m_SetActive = false;
	}

	public void AnimateOutRight(float duration) {
		m_Duration = duration;
		m_Width = GetComponent<RectTransform>().rect.width;
		m_Start = Vector3.zero;
		m_End = new Vector3(m_Start.x+m_Width, m_Start.y, m_Start.z);
		m_SetActive = false;
	}


	public void AnimateInLeft(float duration) {
		gameObject.SetActive(true);
		m_Duration = duration;
		m_Width = GetComponent<RectTransform>().rect.width;
		m_Start = new Vector3(m_Width, 0, 0);
		m_End = Vector3.zero;
	}

	public void AnimateInRight(float duration) {
		gameObject.SetActive(true);
		m_Duration = duration;
		m_Width = GetComponent<RectTransform>().rect.width;
		m_Start = new Vector3(-m_Width, 0, 0);
		m_End = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update ()
	{
		m_Dt += Time.unscaledDeltaTime;

		transform.localPosition = Vector3.Lerp(m_Start, m_End, m_Dt / m_Duration);

		if(m_Dt > m_Duration) {
			gameObject.SetActive(m_SetActive);
			Destroy(this);
		}
	}
}
