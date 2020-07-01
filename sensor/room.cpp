#include "room.h"

room::room()
{
    sensorDoor.main_sensor = &sensor_door;
    sensorDoor.related_sensor = &sensor_hall;
    sensorDoor.direction_vector = 1;

    sensorHall.main_sensor = &sensor_hall;
    sensorHall.related_sensor = &sensor_door;
    sensorHall.direction_vector = -1;
}

void room::detected_movement(sensorConnection& sensor_connection)
{
    if (sensor_connection.related_sensor -> get_state())
    {
        // people getting in
        people_in_room += sensor_connection.direction_vector;
        sensor_connection.related_sensor -> clear();
    }
    else
    {
        sensor_connection.main_sensor -> set();
    }
}

