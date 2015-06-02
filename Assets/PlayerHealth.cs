using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100.0f;
	public float currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public float flashSpeed = 5.0f;
	public Color flashColor = new Color(0.1f,0,0,1.0f);
	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		damageImage.color =  Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		
		if(Input.GetKeyDown(KeyCode.G))
		{
			TakeDamage(Random.value*5);
		}
	}
	public void TakeDamage ( float damage )
	{
		currentHealth-= damage;
		healthSlider.value = currentHealth/startingHealth;
		
	}
}
