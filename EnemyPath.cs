using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour {

	// Use this for initialization


	public float xPosEnemy;
	public float yPosEnemy;
	public Vector2 enemyPos;
	private float enemySpeedX = .015f;
	private float enemySpeedY = .015f;


	void Start(){

		var instance = new EnemyClass();
		instance.populateEnemies (1);
		Debug.Log (EnemyClass.Instance.levelOneSpawn[1]);
	}
	
	// Update is called once per frame
	void Update () {

		moveEnemy (1,1);
		//Debug.Log (enemySpeedX);



	}

	void moveEnemy(int level, int spawnArea){
		
		xPosEnemy = gameObject.transform.position.x + enemySpeedX;
		yPosEnemy = gameObject.transform.position.y + enemySpeedY;
		enemyPos = new Vector2 (Mathf.Clamp (xPosEnemy, -30, 30), Mathf.Clamp (yPosEnemy, -30, 30));
		gameObject.transform.position = enemyPos;



		//////////////////////////////////////////////////////////
		///////////////////level one//////////////////////////////
		//////////////////////////////////////////////////////////*
	
		//switch(level){

		//case 1: //Level one
		//	if (spawnArea == 1) { //spawn area 1 level 1
				//create
			//}
			//if (spawnArea == 2) { //spawn area 2 level 2
				
		//	}
	}




}
