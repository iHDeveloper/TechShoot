using UnityEngine;
using System;

public class Floor : MonoBehaviour {

	[SerializeField]
	private string name = "Floor";
	public string Name {
		get{ return name; }
		set{ this.name = value; }
	}

	[SerializeField]
	private World world;
	public World World {
		get{ return world; }
		set{ this.world = value; }
	}

	[SerializeField]
	private int chunksInLoad = 1;
	public int ChunksInLoad {
		get{ return chunksInLoad; }
		set{ this.chunksInLoad = value; }
	}

	[SerializeField]
	private Block[] blocks = null;
	public Block[] Blocks {
		get{ return blocks; }
		set{ this.blocks = value; }
	}

	private void Build(Block[] blocks, Vector3 from, Vector3 to){
		int amount = from.x - to.x;
		for (int i = -1; i < amount; i++) {
			int x = from.x + i;	//X to destory
			int y = from.y + i; //Y to destory
			int z = from.z + i; //Z to destory
			Vector3 postiton = new Vector3(x, y, z); //The Postiton of the block we want to destory
			System.Random ran = new System.Random();
			int b = ran.Next (0, blocks.Length); //The Block Range to destory
			GameObject world = GameObject.Find(world.Name);
			GameObject chunk = GameObject.Find(Name);
			GameObject block = blocks[b].gameObject;
			block.transform = postiton;
		}
	}

	public void Load(){
		
		
	}


}
