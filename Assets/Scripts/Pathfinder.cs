using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Pathfinder {
	
	public abstract void setPath (Node start, Node end);

	public abstract bool findPathNextStep ();

	public abstract void findPathRestSteps ();

	public abstract LinkedList<Node> findPathFast (Node start, Node end);

	public abstract LinkedList<Node> getPath ();
}
