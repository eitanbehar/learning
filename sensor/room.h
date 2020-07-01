#include "sensor.h"
#include "sensorConnection.h"

class room
{
private:
    sensor sensor_hall;
    sensor sensor_door;

public:
    sensorConnection sensorHall;
    sensorConnection sensorDoor;
    int people_in_room = 0;
    void detected_movement(sensorConnection &sensor);
    room();
};