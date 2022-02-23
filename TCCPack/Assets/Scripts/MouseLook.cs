using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public bool travarMouse = true; //Controla se o cursor do mouse é exibido
	public float sensibilidade = 2.0f; //Controla a sensibilidade do mouse

	private float mouseX = 0.0f, mouseY = 0.0f; //Variáveis que controla a rotação do mouse

	void Start()
	{
		
	}


	void Update()
	{
		mouseX += Input.GetAxis("Mouse X") * sensibilidade; // Incrementa o valor do eixo X e multiplica pela sensibilidade
		mouseY -= Input.GetAxis("Mouse Y") * sensibilidade; // Incrementa o valor do eixo Y e multiplica pela sensibilidade. (Obs. usamos o - para inverter os valores)

		transform.eulerAngles = new Vector3(mouseY, mouseX, 0); //Executa a rotação da câmera de acordo com os eixos

		
	}
}
