#include "sensor.h"

class room
{
private:
    sensor sensor_entry;
    sensor sensor_exit;
public:    
    int people_in_room = 0;   
    void set_sensor_entry();
    void set_sensor_exit();     
};