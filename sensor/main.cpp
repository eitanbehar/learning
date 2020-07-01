#include <iostream>
#include <string>
#include <array>

#include "room.h"

using namespace std;

void main()
{
    room workRoom;

    array<int, 10> flow{1, 1, 1, -1, -1, -1, 1, -1, 1};

    // simulate process of people going in an out
    for (int i = 0; i < flow.size(); i++)
    {
        if (flow[i] == 1) // someone in
        {
            workRoom.detected_movement(workRoom.sensorHall);
            workRoom.detected_movement(workRoom.sensorDoor);
        }
        else //someone out
        {
            workRoom.detected_movement(workRoom.sensorDoor);
            workRoom.detected_movement(workRoom.sensorHall);            
        }

        cout << "People in room: " << workRoom.people_in_room << "\n\r"; 
        
    }
}