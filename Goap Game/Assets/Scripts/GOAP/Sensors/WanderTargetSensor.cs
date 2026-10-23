// using CrashKonijn.Goap.Classes;
// using CrashKonijn.Goap.Interfaces;
// using CrashKonijn.Goap.Sensors;
// using UnityEngine;
// using UnityEngine.AI; // for NavMesh

// namespace GOAP.Sensors
// {
//     public class WanderTargetSensor : LocalTargetSensorBase
//     { // want to find a position for an agent, means a local sensor

//         // global and local sensors exist in GOAP
//         public override void Created() {}

//         // Sensing occurs when GOAP system is trying to plan an action, the GOAP WorldState is NOT a source of truth!
//         // Sensors update the Agent's WorldState only when deciding the next action so the WorldState can be outdated
//         // Agents should store data in dedicated MonoBehaviours for real-time updating
//         public override ITarget Sense(IMonoAgent agent, IComponentReference references)
//         {

//             // IMonoAgent has transform position of the current agent
//             Vector3 position = GetRandomPosition(agent); 

//             return new PositionTarget(position);
    
//         }

//         public override void Update() {}

//         // trying to mitigate getting a position where you can't go anywhere
//         private Vector3 GetRandomPosition(IMonoAgent agent)
//         {
//             int count = 0;

//             while (count < 5) // try up to five times
//             {
//                 Vector2 random = Random.insideUnitCircle * 5;
//                 Vector3 position = agent.transform.position + new UnityEngine.Vector3(
//                     random.x, // xz plane only, don't care about height (y)
//                     0,
//                     random.y
//                 );

//                 if (NavMesh.SamplePosition(position, out NavMeshHit hit, 1, NavMesh.AllAreas))
//                 {
//                     return hit.position;
//                 }

//                 // else
//                 count++;
//             }

//             return agent.transform.position; // use current position if can't find anything (after 5 tries)
//         }
//     }
// }