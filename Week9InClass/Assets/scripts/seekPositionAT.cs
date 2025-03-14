using JetBrains.Annotations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class seekPositionAT : ActionTask {

		//tried to set target with BB
		//private BBParameter<Vector3> targetPosition;
		public Transform targetTransform;

		public NavMeshAgent navMeshAgent;


		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			NavMeshHit Hit;
			NavMesh.SamplePosition(targetTransform.position, out Hit, 400f, NavMesh.AllAreas);
			navMeshAgent.SetDestination(Hit.position);
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}